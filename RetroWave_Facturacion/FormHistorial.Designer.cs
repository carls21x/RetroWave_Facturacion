namespace RetroWave_Facturacion
{
    partial class FormHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorial));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.fnGetVentasOrdenadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetHISTORIAL = new RetroWave_Facturacion.DataSetHISTORIAL();
            this.dataSetHISTORIALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fn_GetVentasOrdenadasTableAdapter = new RetroWave_Facturacion.DataSetHISTORIALTableAdapters.fn_GetVentasOrdenadasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fnGetVentasOrdenadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHISTORIAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHISTORIALBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetH";
            reportDataSource1.Value = this.fnGetVentasOrdenadasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RetroWave_Facturacion.ReportHISTORIAL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 70);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 414);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.Red;
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(284, 16);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(225, 37);
            this.btnFacturar.TabIndex = 10;
            this.btnFacturar.Text = "CERRAR";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // fnGetVentasOrdenadasBindingSource
            // 
            this.fnGetVentasOrdenadasBindingSource.DataMember = "fn_GetVentasOrdenadas";
            this.fnGetVentasOrdenadasBindingSource.DataSource = this.dataSetHISTORIALBindingSource;
            // 
            // dataSetHISTORIAL
            // 
            this.dataSetHISTORIAL.DataSetName = "DataSetHISTORIAL";
            this.dataSetHISTORIAL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetHISTORIALBindingSource
            // 
            this.dataSetHISTORIALBindingSource.DataSource = this.dataSetHISTORIAL;
            this.dataSetHISTORIALBindingSource.Position = 0;
            // 
            // fn_GetVentasOrdenadasTableAdapter
            // 
            this.fn_GetVentasOrdenadasTableAdapter.ClearBeforeFill = true;
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Ventas";
            this.Load += new System.EventHandler(this.FormHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fnGetVentasOrdenadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHISTORIAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHISTORIALBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnFacturar;
        private DataSetHISTORIAL dataSetHISTORIAL;
        private System.Windows.Forms.BindingSource dataSetHISTORIALBindingSource;
        private System.Windows.Forms.BindingSource fnGetVentasOrdenadasBindingSource;
        private DataSetHISTORIALTableAdapters.fn_GetVentasOrdenadasTableAdapter fn_GetVentasOrdenadasTableAdapter;
    }
}