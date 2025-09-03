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
            dtpFecha = new DateTimePicker();
            lstProductos = new ComboBox();
            txtPrecio = new MaskedTextBox();
            dudCantidad = new DomainUpDown();
            btnSalir = new Button();
            btnCarga = new Button();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(50, 92);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(51, 159);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(58, 213);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(59, 33);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(157, 27);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 8;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.Location = new Point(157, 89);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(168, 23);
            lstProductos.TabIndex = 9;
            lstProductos.SelectedIndexChanged += lstProductos_SelectedIndexChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(157, 210);
            txtPrecio.Mask = "99999";
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 10;
            txtPrecio.ValidatingType = typeof(int);
            // 
            // dudCantidad
            // 
            dudCantidad.Location = new Point(157, 157);
            dudCantidad.Name = "dudCantidad";
            dudCantidad.Size = new Size(120, 23);
            dudCantidad.TabIndex = 11;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(58, 274);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 40);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCarga
            // 
            btnCarga.Location = new Point(178, 274);
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
            ClientSize = new Size(391, 343);
            Controls.Add(btnCarga);
            Controls.Add(btnSalir);
            Controls.Add(dudCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(lstProductos);
            Controls.Add(dtpFecha);
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
        private DateTimePicker dtpFecha;
        private ComboBox lstProductos;
        private MaskedTextBox txtPrecio;
        private DomainUpDown dudCantidad;
        private Button btnSalir;
        private Button btnCarga;
    }
}
