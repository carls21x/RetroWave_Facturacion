using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RetroWave_Facturacion
{
    public partial class FormFactura : Form
    {
        private decimal totalFactura = 0m;

        private DataTable dtFactura;

        public FormFactura()
        {
            InitializeComponent();
            txtPago.TextChanged += txtPago_TextChanged;
            btnFacturar.Click += btnFacturar_Click;
            this.Load += FormFactura_Load;
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            string usuario = Environment.UserName; 

            using (var conn = new SqlConnection("Data Source=CARLOS;Initial Catalog=DB_RetroWave;Integrated Security=True"))
            {
                conn.Open();
                using (var cmd = new SqlCommand("usp_GetProductos", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SoloDisponibles", 1);

                    using (var da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        
                        if (!dt.Columns.Contains("Cantidad"))
                            dt.Columns.Add("Cantidad", typeof(int));

                        foreach (DataRow row in dt.Rows)
                            row["Cantidad"] = 0; 

                        dgvProductos.DataSource = dt;

                        
                        foreach (DataGridViewColumn col in dgvProductos.Columns)
                            col.ReadOnly = col.Name != "Cantidad";

                        
                        dgvProductos.Columns["Cantidad"].Visible = false;
                    }
                }

                using (var cmd = new SqlCommand("SELECT SYSTEM_USER", conn))
                {
                    lblCajero.Text = "" + cmd.ExecuteScalar().ToString();
                }
            }

            // Inicializa la tabla de la factura
            dtFactura = new DataTable();
            dtFactura.Columns.Add("IdProducto", typeof(int)); 
            dtFactura.Columns.Add("Nombre", typeof(string));
            dtFactura.Columns.Add("Precio", typeof(decimal));
            dtFactura.Columns.Add("Talla", typeof(string));
            dtFactura.Columns.Add("Color", typeof(string));
            dtFactura.Columns.Add("Cantidad", typeof(int));
            dtFactura.Columns.Add("Stock", typeof(int));

            dgvFactura.DataSource = dtFactura;

            dgvProductos.CellValueChanged += dgvProductos_CellValueChanged;
            dgvProductos.CurrentCellDirtyStateChanged += dgvProductos_CurrentCellDirtyStateChanged;

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            totalFactura = 0m;
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Cells["Precio"]?.Value != null && row.Cells["Cantidad"]?.Value != null)
                {
                    decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                    int cantidad = 0;
                    int.TryParse(row.Cells["Cantidad"].Value.ToString(), out cantidad);
                    totalFactura += precio * cantidad;
                }
            }
            lblTotal.Text = totalFactura.ToString("0.00");
            txtPago_TextChanged(null, null); // Actualiza el cambio
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            decimal montoPago;
            if (decimal.TryParse(txtPago.Text, out montoPago))
            {
                decimal cambio = montoPago - totalFactura;
                lblCambio.Text = cambio >= 0 ? cambio.ToString("0.00") : "0.00";
            }
            else
            {
                lblCambio.Text = "0.00";
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            string cliente = txtCliente.Text.Trim();
            decimal montoPago;
            if (!decimal.TryParse(txtPago.Text, out montoPago) || montoPago < totalFactura)
            {
                MessageBox.Show("El monto pagado es insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.IsNewRow) continue;
                int cantidad = 0;
                int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out cantidad);
                if (cantidad <= 0) continue;

                int stock = Convert.ToInt32(row.Cells["Stock"].Value);
                if (cantidad > stock)
                {
                    MessageBox.Show($"La cantidad solicitada para '{row.Cells["nombre"].Value}' supera el stock disponible ({stock}).", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            using (var conn = new SqlConnection("Data Source=CARLOS;Initial Catalog=DB_RetroWave;Integrated Security=True"))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    var cmdVenta = new SqlCommand(
                        "INSERT INTO ventas (NombreCliente, Total, Usuario, Fecha) VALUES (@cliente, @total, @usuario, GETDATE()); SELECT SCOPE_IDENTITY();",
                        conn, transaction);
                    cmdVenta.Parameters.AddWithValue("@cliente", string.IsNullOrEmpty(cliente) ? (object)DBNull.Value : cliente);
                    cmdVenta.Parameters.AddWithValue("@total", totalFactura);
                    cmdVenta.Parameters.AddWithValue("@usuario", Environment.UserName);
                    int ventaId = Convert.ToInt32(cmdVenta.ExecuteScalar());

                    foreach (DataRow row in dtFactura.Rows)
                    {
                        int productoId = Convert.ToInt32(row["IdProducto"]);
                        int cantidad = Convert.ToInt32(row["Cantidad"]);
                        decimal precio = Convert.ToDecimal(row["Precio"]);
                        AgregarDetalleVenta(conn, transaction, ventaId, productoId, cantidad, precio);
                    }

                    foreach (DataGridViewRow row in dgvFactura.Rows)
                    {
                        if (row.IsNewRow) continue; // Ignora la fila vacía al final

                        int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        decimal precioUnitario = Convert.ToDecimal(row.Cells["Precio"].Value);

                        using (var cmd = new SqlCommand(
                            "INSERT INTO DetalleVenta (IdVenta, IdProducto, Cantidad, PrecioUnitario) VALUES (@ventaId, @productoId, @cantidad, @precio)", conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ventaId", ventaId);
                            cmd.Parameters.AddWithValue("@productoId", idProducto);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@precio", precioUnitario);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Venta realizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 
                    
                    FormRFACTURA formRFACTURA = new FormRFACTURA();
                    formRFACTURA.Show();
                    this.Hide();



                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al facturar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "Cantidad")
                CalcularTotal();
        }

        private void dgvProductos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProductos.IsCurrentCellDirty)
                dgvProductos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida.");
                return;
            }

            int stock = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Stock"].Value);
            if (cantidad > stock)
            {
                MessageBox.Show("No hay suficiente stock.");
                return;
            }

            // Agrega el producto a la factura
            dtFactura.Rows.Add(
                dgvProductos.CurrentRow.Cells["IdProducto"].Value,
                dgvProductos.CurrentRow.Cells["Nombre"].Value,
                dgvProductos.CurrentRow.Cells["Precio"].Value,
                dgvProductos.CurrentRow.Cells["Talla"].Value,
                dgvProductos.CurrentRow.Cells["Color"].Value,
                cantidad, 
                stock
            );

            CalcularTotalFactura();
        }

        private void CalcularTotalFactura()
        {
            totalFactura = 0m;
            foreach (DataRow row in dtFactura.Rows)
            {
                decimal precio = Convert.ToDecimal(row["Precio"]);
                int cantidad = Convert.ToInt32(row["Cantidad"]);
                totalFactura += precio * cantidad;
            }
            lblTotal.Text = totalFactura.ToString("0.00");
            txtPago_TextChanged(null, null);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }

        private void btnFacturar_Click_1(object sender, EventArgs e)
        {
            dtFactura = new DataTable();
            
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida.");
                return;
            }

            int stock = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Stock"].Value);
            if (cantidad > stock)
            {
                MessageBox.Show("No hay suficiente stock.");
                return;
            }

            // Agrega el producto a la factura
            dtFactura.Rows.Add(
                dgvProductos.CurrentRow.Cells["IdProducto"].Value,
                dgvProductos.CurrentRow.Cells["Nombre"].Value,
                dgvProductos.CurrentRow.Cells["Precio"].Value,
                dgvProductos.CurrentRow.Cells["Talla"].Value,
                dgvProductos.CurrentRow.Cells["Color"].Value,
                cantidad,
                stock
            );

            CalcularTotalFactura();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox dentro del groupBoxFactura
            foreach (Control control in groupBoxFactura.Controls)
            {
                if (control is TextBox textBox)
                    textBox.Clear();
            }

            // Limpiar el DataTable de la factura y refrescar el DataGridView
            if (dtFactura != null)
            {
                dtFactura.Clear();
                dgvFactura.DataSource = dtFactura;
            }

            // Limpiar totales y cambio
            lblTotal.Text = "0.00";
            lblCambio.Text = "0.00";

            //limpiar el DataGridView de productos
            if (dgvProductos.DataSource is DataTable dtProductos)
            {
                dtProductos.Clear();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            // Limpiar los TextBox dentro del groupBoxFactura
            foreach (Control control in groupBoxFactura.Controls)
            {
                if (control is TextBox textBox)
                    textBox.Clear();
            }

            // Limpiar el DataTable de la factura y refrescar el DataGridView
            if (dtFactura != null)
            {
                dtFactura.Clear();
                dgvFactura.DataSource = dtFactura;
            }

            // Limpiar totales y cambio
            lblTotal.Text = "0.00";
            lblCambio.Text = "0.00";
        }

        private void AgregarDetalleVenta(SqlConnection conn, SqlTransaction transaction, int idVenta, int idProducto, int cantidad, decimal precioUnitario)
        {
            using (var cmd = new SqlCommand(
                "INSERT INTO DetalleVenta (IdVenta, IdProducto, Cantidad, PrecioUnitario) VALUES (@ventaId, @productoId, @cantidad, @precio)", conn, transaction))
            {
                cmd.Parameters.AddWithValue("@ventaId", idVenta);
                cmd.Parameters.AddWithValue("@productoId", idProducto);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@precio", precioUnitario);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtbuscar.Text.Trim();

            using (var conn = new SqlConnection("Data Source=CARLOS;Initial Catalog=DB_RetroWave;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT IdProducto, Nombre, Precio, Talla, Color, Stock FROM tb_Productos WHERE Nombre LIKE @nombre";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", "%" + textoBusqueda + "%");
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                       
                        dgvProductos.DataSource = dt;
                    }
                }
            }
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminarP_Click_1(object sender, EventArgs e)
        {
            if (dgvFactura.CurrentRow != null && !dgvFactura.CurrentRow.IsNewRow)
            {
                dgvFactura.Rows.RemoveAt(dgvFactura.CurrentRow.Index);
                
                CalcularTotalFactura();
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            if (dgvFactura.CurrentRow != null && !dgvFactura.CurrentRow.IsNewRow)
            {
                int nuevaCantidad;
                if (int.TryParse(txtCantidad.Text, out nuevaCantidad) && nuevaCantidad > 0)
                {
                    dgvFactura.CurrentRow.Cells["Cantidad"].Value = nuevaCantidad;
                    CalcularTotalFactura();
                }
                else
                {
                    MessageBox.Show("Ingresa una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
