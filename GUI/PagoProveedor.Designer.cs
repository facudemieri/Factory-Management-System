namespace GUI
{
    partial class PagoProveedor
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.cmbMetodoPagos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSaldoPagos = new System.Windows.Forms.Label();
            this.lblTotalPagos = new System.Windows.Forms.Label();
            this.datagridPagos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.controlBusqueda1 = new GUI.Controles.ControlBusqueda();
            this.lblValidaNumero1 = new GUI.Controles.lblValidaNumero();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPagos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 305);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 44);
            this.panel2.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Registrar Pago";
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPago.Location = new System.Drawing.Point(270, 453);
            this.btnRegistrarPago.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(186, 29);
            this.btnRegistrarPago.TabIndex = 26;
            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // cmbMetodoPagos
            // 
            this.cmbMetodoPagos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMetodoPagos.FormattingEnabled = true;
            this.cmbMetodoPagos.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia",
            "Cheque"});
            this.cmbMetodoPagos.Location = new System.Drawing.Point(351, 419);
            this.cmbMetodoPagos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMetodoPagos.Name = "cmbMetodoPagos";
            this.cmbMetodoPagos.Size = new System.Drawing.Size(105, 27);
            this.cmbMetodoPagos.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(221, 422);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Metodo de Pago";
            // 
            // lblSaldoPagos
            // 
            this.lblSaldoPagos.AutoSize = true;
            this.lblSaldoPagos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoPagos.Location = new System.Drawing.Point(11, 423);
            this.lblSaldoPagos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldoPagos.Name = "lblSaldoPagos";
            this.lblSaldoPagos.Size = new System.Drawing.Size(52, 19);
            this.lblSaldoPagos.TabIndex = 21;
            this.lblSaldoPagos.Text = "Saldo:";
            // 
            // lblTotalPagos
            // 
            this.lblTotalPagos.AutoSize = true;
            this.lblTotalPagos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagos.Location = new System.Drawing.Point(11, 396);
            this.lblTotalPagos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPagos.Name = "lblTotalPagos";
            this.lblTotalPagos.Size = new System.Drawing.Size(45, 19);
            this.lblTotalPagos.TabIndex = 20;
            this.lblTotalPagos.Text = "Total:";
            // 
            // datagridPagos
            // 
            this.datagridPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPagos.Location = new System.Drawing.Point(11, 163);
            this.datagridPagos.Margin = new System.Windows.Forms.Padding(2);
            this.datagridPagos.Name = "datagridPagos";
            this.datagridPagos.RowHeadersWidth = 51;
            this.datagridPagos.RowTemplate.Height = 24;
            this.datagridPagos.Size = new System.Drawing.Size(445, 111);
            this.datagridPagos.TabIndex = 19;
            this.datagridPagos.SelectionChanged += new System.EventHandler(this.datagridPagos_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 48);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(373, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 48);
            this.button1.TabIndex = 29;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagos";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.Location = new System.Drawing.Point(11, 453);
            this.lblAviso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(21, 19);
            this.lblAviso.TabIndex = 30;
            this.lblAviso.Text = "...";
            // 
            // controlBusqueda1
            // 
            this.controlBusqueda1.DataSource = null;
            this.controlBusqueda1.DisplayMember = "";
            this.controlBusqueda1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlBusqueda1.Location = new System.Drawing.Point(-2, 54);
            this.controlBusqueda1.Margin = new System.Windows.Forms.Padding(4);
            this.controlBusqueda1.Name = "controlBusqueda1";
            this.controlBusqueda1.SelectedIndex = -1;
            this.controlBusqueda1.Size = new System.Drawing.Size(254, 97);
            this.controlBusqueda1.TabIndex = 29;
            this.controlBusqueda1.TextoBoton = "Buscar";
            this.controlBusqueda1.TextoLabel = "Proveedor";
            this.controlBusqueda1.ValueMember = "";
            // 
            // lblValidaNumero1
            // 
            this.lblValidaNumero1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblValidaNumero1.BackColor = System.Drawing.Color.Transparent;
            this.lblValidaNumero1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidaNumero1.Location = new System.Drawing.Point(270, 358);
            this.lblValidaNumero1.Margin = new System.Windows.Forms.Padding(4);
            this.lblValidaNumero1.Name = "lblValidaNumero1";
            this.lblValidaNumero1.Size = new System.Drawing.Size(218, 57);
            this.lblValidaNumero1.TabIndex = 28;
            this.lblValidaNumero1.TextoLabel = "Monto";
            // 
            // PagoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(467, 493);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.controlBusqueda1);
            this.Controls.Add(this.lblValidaNumero1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.cmbMetodoPagos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSaldoPagos);
            this.Controls.Add(this.lblTotalPagos);
            this.Controls.Add(this.datagridPagos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PagoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoProveedor";
            this.Load += new System.EventHandler(this.PagoProveedor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPagos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.ComboBox cmbMetodoPagos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSaldoPagos;
        private System.Windows.Forms.Label lblTotalPagos;
        private System.Windows.Forms.DataGridView datagridPagos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Controles.lblValidaNumero lblValidaNumero1;
        private Controles.ControlBusqueda controlBusqueda1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAviso;
    }
}