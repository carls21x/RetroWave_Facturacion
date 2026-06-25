using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;

namespace RetroWave_Facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Producto_Load;
            this.Load += FormMenu_Load;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Producto_Load(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.CargarProductos(dtgproductos);
        }

        private void LoadData()
        {
            Productos producto = new Productos();
            producto.CargarProductos(dtgproductos);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombre = txtnombre.Text;
            string precio = txtprecio.Text;
            string talla = txttalla.Text;
            string color = txtcolor.Text;
            string stock = txtstock.Text;
            LoadData(); 



            if (nombre == "" || precio == "" || talla == "" || color == "" || stock == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Productos producto = new Productos(nombre, precio, talla, color, stock);
                int resultado = producto.AgregarProducto();

                if (resultado == 1)
                {
                    MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetearForm();
                    LoadData(); 

                }
                else
                {
                    MessageBox.Show("Error al agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        
        public void ResetearForm()
            {
            txtnombre.Clear();
            txtprecio.Clear();
            txttalla.Clear();
            txtcolor.Clear();
            txtstock.Clear();
            }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtid.Text;
            int id = Convert.ToInt32(codigo);

            DialogResult confirmar = MessageBox.Show("¿Está seguro de eliminar este Producto?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmar == DialogResult.OK)
            {
                Productos producto = new Productos(id);
                int fila = producto.EliminarProducto(id);

                if (fila == 1)
                {
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnactualizar.Enabled = false;
                    btneliminar.Enabled = false;
                    btnguardar.Enabled = true;
                    ResetearForm();
                    LoadData();


                }
                else
                {
                    MessageBox.Show("Ocurrió un problema al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice ==-1 || dtgproductos.SelectedCells[1].Value.ToString() == "")
            {
                MessageBox.Show("Por favor, seleccione un Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtid.Text = dtgproductos.Rows[indice].Cells[0].Value.ToString();
                txtnombre.Text = dtgproductos.Rows[indice].Cells[1].Value.ToString();
                txtprecio.Text = dtgproductos.Rows[indice].Cells[2].Value.ToString();
                txttalla.Text = dtgproductos.Rows[indice].Cells[3].Value.ToString();
                txtcolor.Text = dtgproductos.Rows[indice].Cells[4].Value.ToString();
                txtstock.Text = dtgproductos.Rows[indice].Cells[5].Value.ToString();
                btnactualizar.Enabled = true;
                btneliminar.Enabled = true;
                btnguardar.Enabled = false;
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            string nombre = txtnombre.Text;
            string precio = txtprecio.Text;
            string talla = txttalla.Text;
            string color = txtcolor.Text;
            string stock = txtstock.Text;

            Productos producto = new Productos();
            int resultado = producto.ActualizarProducto(id, nombre, precio, talla, color, stock);

            if (resultado == 1)
            {
                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetearForm();
                LoadData();
                btnactualizar.Enabled = false;
                btneliminar.Enabled = false;
                btnguardar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error al actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            ResetearForm();
            dtgproductos.ClearSelection();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtbuscar.Text;
            Productos producto = new Productos();
            producto.BuscarProductoPorNombre(dtgproductos, nombre);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            NotificarBajoStock();
        }

        private void NotificarBajoStock()
        {
            using (var conn = new SqlConnection("Data Source=CARLOS;Initial Catalog=DB_RetroWave;Integrated Security=True"))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT Nombre, Stock FROM tb_Productos WHERE Stock <= 5", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    var productosBajoStock = new List<string>();
                    while (reader.Read())
                    {
                        string nombre = reader["Nombre"].ToString();
                        int stock = Convert.ToInt32(reader["Stock"]);
                        productosBajoStock.Add($"{nombre} (Stock: {stock})");
                    }

                    if (productosBajoStock.Count > 0)
                    {
                        MessageBox.Show(
                            "¡Atención! Los siguientes productos tienen bajo stock:\n\n" +
                            string.Join("\n", productosBajoStock),
                            "Alerta de Stock Bajo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}

