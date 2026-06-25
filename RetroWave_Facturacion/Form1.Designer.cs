namespace RetroWave_Facturacion
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxRegistro = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txttalla = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.dtgproductos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgproductos)).BeginInit();
            this.groupBoxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRegistro
            // 
            this.groupBoxRegistro.Controls.Add(this.txtid);
            this.groupBoxRegistro.Controls.Add(this.label6);
            this.groupBoxRegistro.Controls.Add(this.txtstock);
            this.groupBoxRegistro.Controls.Add(this.txtcolor);
            this.groupBoxRegistro.Controls.Add(this.txttalla);
            this.groupBoxRegistro.Controls.Add(this.txtprecio);
            this.groupBoxRegistro.Controls.Add(this.txtnombre);
            this.groupBoxRegistro.Controls.Add(this.label5);
            this.groupBoxRegistro.Controls.Add(this.label4);
            this.groupBoxRegistro.Controls.Add(this.label3);
            this.groupBoxRegistro.Controls.Add(this.label2);
            this.groupBoxRegistro.Controls.Add(this.label1);
            this.groupBoxRegistro.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegistro.ForeColor = System.Drawing.Color.White;
            this.groupBoxRegistro.Location = new System.Drawing.Point(114, 95);
            this.groupBoxRegistro.Name = "groupBoxRegistro";
            this.groupBoxRegistro.Size = new System.Drawing.Size(328, 257);
            this.groupBoxRegistro.TabIndex = 0;
            this.groupBoxRegistro.TabStop = false;
            this.groupBoxRegistro.Text = "Registrar Producto";
            this.groupBoxRegistro.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Gainsboro;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(84, 32);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(211, 22);
            this.txtid.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(84, 213);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(211, 22);
            this.txtstock.TabIndex = 9;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(84, 177);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(211, 22);
            this.txtcolor.TabIndex = 8;
            // 
            // txttalla
            // 
            this.txttalla.Location = new System.Drawing.Point(84, 139);
            this.txttalla.Name = "txttalla";
            this.txttalla.Size = new System.Drawing.Size(211, 22);
            this.txttalla.TabIndex = 7;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(84, 102);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(211, 22);
            this.txtprecio.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(84, 65);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(211, 22);
            this.txtnombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Talla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Red;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(114, 359);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(105, 23);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Red;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(114, 390);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(328, 23);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "LIMPIAR";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Red;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Enabled = false;
            this.btneliminar.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(226, 359);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(105, 23);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.Red;
            this.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnactualizar.Enabled = false;
            this.btnactualizar.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.White;
            this.btnactualizar.Location = new System.Drawing.Point(337, 359);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(105, 23);
            this.btnactualizar.TabIndex = 6;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // dtgproductos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgproductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgproductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgproductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgproductos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgproductos.Location = new System.Drawing.Point(541, 165);
            this.dtgproductos.Name = "dtgproductos";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgproductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgproductos.Size = new System.Drawing.Size(617, 248);
            this.dtgproductos.TabIndex = 7;
            this.dtgproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgproductos_CellClick);
            this.dtgproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgproductos_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("ITC Benguiat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(108, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 33);
            this.label7.TabIndex = 8;
            this.label7.Text = "RETRO WAVE";
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Controls.Add(this.btnbuscar);
            this.groupBoxBuscar.Controls.Add(this.txtbuscar);
            this.groupBoxBuscar.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscar.ForeColor = System.Drawing.Color.White;
            this.groupBoxBuscar.Location = new System.Drawing.Point(541, 95);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(617, 64);
            this.groupBoxBuscar.TabIndex = 10;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "BUSCADOR";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Red;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.Location = new System.Drawing.Point(513, 16);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(91, 35);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(11, 27);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(488, 18);
            this.txtbuscar.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(29, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 33);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "MENU";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Alfredino Semimono Semimono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(361, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "© 2025 Carlos Velasquez. Todos los derechos reservados.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1294, 512);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgproductos);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBoxRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRegistro.ResumeLayout(false);
            this.groupBoxRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgproductos)).EndInit();
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txttalla;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgproductos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label8;
    }
}

