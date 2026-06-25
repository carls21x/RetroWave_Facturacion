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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form1 formProductos = new Form1();
            formProductos.Show();
            this.Hide();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            FormFactura formFactura = new FormFactura();
            formFactura.Show();
            this.Hide(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void btnreportes_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormHistorial formHistorial = new FormHistorial();
            formHistorial.Show();
            this.Hide();
        }
    }
}
