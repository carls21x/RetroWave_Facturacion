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
    public partial class FormHistorial : Form
    {
        public FormHistorial()
        {
            InitializeComponent();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetHISTORIAL.fn_GetVentasOrdenadas' table. You can move, or remove it, as needed.
            this.fn_GetVentasOrdenadasTableAdapter.Fill(this.dataSetHISTORIAL.fn_GetVentasOrdenadas);

            this.reportViewer1.RefreshReport();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }
    }
}
