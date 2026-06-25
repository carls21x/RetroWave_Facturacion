using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace RetroWave_Facturacion
{
    internal class Productos
    {
        private int id;
        private string nombre;
        private string precio;
        private string talla;
        private string color;
        private string stock;

        SqlConnection cn = new SqlConnection("Data Source=CARLOS;Initial Catalog=DB_RetroWave;Integrated Security=True");

        public Productos(string nombre, string precio, string talla, string color, string stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.talla = talla;
            this.color = color;
            this.stock = stock;
        }
        public Productos()
        {
            // Constructor vacío para inicializar sin parámetros
        }

        public Productos(int id)
        {
            this.id = id;

        }

        public int AgregarProducto()
        {
            
                cn.Open();
                SqlCommand consulta = new SqlCommand("INSERT INTO tb_Productos (Nombre, Precio, Talla, Color, Stock) VALUES (@Nombre, @Precio, @Talla, @Color, @Stock)", cn);
                consulta.Parameters.AddWithValue("@Nombre", nombre);
                consulta.Parameters.AddWithValue("@Precio", precio);
                consulta.Parameters.AddWithValue("@Talla", talla);
                consulta.Parameters.AddWithValue("@Color", color);
                consulta.Parameters.AddWithValue("@Stock", stock);

            int filasAfectadas = consulta.ExecuteNonQuery();
            cn.Close();

            return filasAfectadas;


        }

        public void CargarProductos(DataGridView dtg)
        {
            cn.Open();
            SqlCommand consulta = new SqlCommand("SELECT * FROM tb_Productos", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtg.DataSource = dt;
        }

        public int EliminarProducto(int id)
        {
            cn.Open();
            SqlCommand consulta = new SqlCommand("DELETE FROM tb_Productos WHERE IdProducto = @codigo", cn);
            consulta.Parameters.AddWithValue("@codigo", id);
            int filasAfectadas = consulta.ExecuteNonQuery();
            cn.Close();
            return filasAfectadas;
        }

        public int ActualizarProducto(int id, string nombre, string precio, string talla, string color, string stock)
        {
            cn.Open();
            SqlCommand consulta = new SqlCommand(
                "UPDATE tb_Productos SET Nombre = @Nombre, Precio = @Precio, Talla = @Talla, Color = @Color, Stock = @Stock WHERE IdProducto = @IdProducto", cn);
            consulta.Parameters.AddWithValue("@Nombre", nombre);
            consulta.Parameters.AddWithValue("@Precio", precio);
            consulta.Parameters.AddWithValue("@Talla", talla);
            consulta.Parameters.AddWithValue("@Color", color);
            consulta.Parameters.AddWithValue("@Stock", stock);
            consulta.Parameters.AddWithValue("@IdProducto", id);

            int filasAfectadas = consulta.ExecuteNonQuery();
            cn.Close();
            return filasAfectadas;
        }

        public void BuscarProductoPorNombre(DataGridView dtg, string nombre)
        {
            cn.Open();
            SqlCommand consulta = new SqlCommand(
                "SELECT * FROM tb_Productos WHERE Nombre LIKE @Nombre", cn);
            consulta.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtg.DataSource = dt;
            cn.Close();
        }
    }
}