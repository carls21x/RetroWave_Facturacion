namespace RetroWave_Facturacion
{
    partial class FormRFACTURA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRFACTURA));
            this.ventasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFACTURA = new RetroWave_Facturacion.DataSetFACTURA();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaDetalleVentaConProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFacturar = new System.Windows.Forms.Button();
            this.fKDetalleVeIdVen5AEE82B9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new RetroWave_Facturacion.DataSetFACTURATableAdapters.VentasTableAdapter();
            this.detalleVentaTableAdapter = new RetroWave_Facturacion.DataSetFACTURATableAdapters.DetalleVentaTableAdapter();
            this.vistaDetalleVentaConProductoTableAdapter = new RetroWave_Facturacion.DataSetFACTURATableAdapters.VistaDetalleVentaConProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFACTURA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDetalleVentaConProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDetalleVeIdVen5AEE82B9BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ventasBindingSource1
            // 
            this.ventasBindingSource1.DataMember = "Ventas";
            this.ventasBindingSource1.DataSource = this.dataSetFACTURABindingSource;
            // 
            // dataSetFACTURABindingSource
            // 
            this.dataSetFACTURABindingSource.DataSource = this.dataSetFACTURA;
            this.dataSetFACTURABindingSource.Position = 0;
            // 
            // dataSetFACTURA
            // 
            this.dataSetFACTURA.DataSetName = "DataSetFACTURA";
            this.dataSetFACTURA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataMember = "DetalleVenta";
            this.detalleVentaBindingSource.DataSource = this.dataSetFACTURABindingSource;
            // 
            // vistaDetalleVentaConProductoBindingSource
            // 
            this.vistaDetalleVentaConProductoBindingSource.DataMember = "VistaDetalleVentaConProducto";
            this.vistaDetalleVentaConProductoBindingSource.DataSource = this.dataSetFACTURABindingSource;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetF";
            reportDataSource1.Value = this.ventasBindingSource1;
            reportDataSource2.Name = "DataSetDetalle";
            reportDataSource2.Value = this.detalleVentaBindingSource;
            reportDataSource3.Name = "DataSetVISTA";
            reportDataSource3.Value = this.vistaDetalleVentaConProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RetroWave_Facturacion.ReportFACTURA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(85, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(637, 593);
            this.reportViewer1.TabIndex = 0;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.dataSetFACTURABindingSource;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.Red;
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(288, 12);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(225, 37);
            this.btnFacturar.TabIndex = 9;
            this.btnFacturar.Text = "CERRAR";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // fKDetalleVeIdVen5AEE82B9BindingSource
            // 
            this.fKDetalleVeIdVen5AEE82B9BindingSource.DataMember = "FK__DetalleVe__IdVen__5AEE82B9";
            this.fKDetalleVeIdVen5AEE82B9BindingSource.DataSource = this.ventasBindingSource1;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // detalleVentaTableAdapter
            // 
            this.detalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // vistaDetalleVentaConProductoTableAdapter
            // 
            this.vistaDetalleVentaConProductoTableAdapter.ClearBeforeFill = true;
            // 
            // FormRFACTURA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRFACTURA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURA";
            this.Load += new System.EventHandler(this.FormRFACTURA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFACTURA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDetalleVentaConProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDetalleVeIdVen5AEE82B9BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetFACTURA dataSetFACTURA;
        private System.Windows.Forms.BindingSource dataSetFACTURABindingSource;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private DataSetFACTURATableAdapters.VentasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.BindingSource ventasBindingSource1;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.BindingSource fKDetalleVeIdVen5AEE82B9BindingSource;
        private DataSetFACTURATableAdapters.DetalleVentaTableAdapter detalleVentaTableAdapter;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private System.Windows.Forms.BindingSource vistaDetalleVentaConProductoBindingSource;
        private DataSetFACTURATableAdapters.VistaDetalleVentaConProductoTableAdapter vistaDetalleVentaConProductoTableAdapter;
    }
}