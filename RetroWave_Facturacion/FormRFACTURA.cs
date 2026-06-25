using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroWave_Facturacion
{
    public partial class FormRFACTURA : Form
    {
        public FormRFACTURA()
        {
            InitializeComponent();
        }

        private void FormRFACTURA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetFACTURA.VistaDetalleVentaConProducto' table. You can move, or remove it, as needed.
            this.vistaDetalleVentaConProductoTableAdapter.Fill(this.dataSetFACTURA.VistaDetalleVentaConProducto);
            // TODO: This line of code loads data into the 'dataSetFACTURA.DetalleVenta' table. You can move, or remove it, as needed.
            this.detalleVentaTableAdapter.Fill(this.dataSetFACTURA.DetalleVenta);
            // TODO: This line of code loads data into the 'dataSetFACTURA.Ventas' table. You can move, or remove it, as needed.
            this.ventasTableAdapter.Fill(this.dataSetFACTURA.Ventas);

            this.reportViewer1.RefreshReport();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            FormFactura formFactura = new FormFactura();
            formFactura.Show();
            this.Hide();
        }
    }
}
