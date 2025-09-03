namespace pryDeganiVentas
{
    partial class FmrMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            lblFecha = new Label();
            date1 = new DateTimePicker();
            Lista1 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            domainUpDown1 = new DomainUpDown();
            btnSalir = new Button();
            btnCarga = new Button();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(120, 143);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(121, 210);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad";
            lblCantidad.Click += this.label2_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(128, 264);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += this.label3_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(129, 84);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha";
            lblFecha.Click += this.label4_Click;
            // 
            // date1
            // 
            date1.Location = new Point(227, 78);
            date1.Name = "date1";
            date1.Size = new Size(200, 23);
            date1.TabIndex = 8;
            date1.ValueChanged += this.date1_ValueChanged;
            // 
            // Lista1
            // 
            Lista1.FormattingEnabled = true;
            Lista1.Location = new Point(227, 140);
            Lista1.Name = "Lista1";
            Lista1.Size = new Size(121, 23);
            Lista1.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(227, 261);
            maskedTextBox1.Mask = "99999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 10;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(227, 208);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 11;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(256, 327);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 40);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += this.btnSalir_Click;
            // 
            // btnCarga
            // 
            btnCarga.Location = new Point(120, 327);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(90, 40);
            btnCarga.TabIndex = 13;
            btnCarga.Text = "Cargar";
            btnCarga.UseVisualStyleBackColor = true;
            // 
            // FmrMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 445);
            Controls.Add(btnCarga);
            Controls.Add(btnSalir);
            Controls.Add(domainUpDown1);
            Controls.Add(maskedTextBox1);
            Controls.Add(Lista1);
            Controls.Add(date1);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Name = "FmrMain";
            Text = "Registro de compras";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecio;
        private Label lblFecha;
        private DateTimePicker date1;
        private ComboBox Lista1;
        private MaskedTextBox maskedTextBox1;
        private DomainUpDown domainUpDown1;
        private Button btnSalir;
        private Button btnCarga;
    }
}
