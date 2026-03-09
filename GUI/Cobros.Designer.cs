namespace GUI
{
    partial class Cobros
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridVentasCobros = new System.Windows.Forms.DataGridView();
            this.lblTotalCobro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaldoCobros = new System.Windows.Forms.Label();
            this.cmbMetodoCobros = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrarCobro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPendienteVenta = new System.Windows.Forms.Label();
            this.lblValidaNumero1 = new GUI.Controles.lblValidaNumero();
            this.controlBusqueda1 = new GUI.Controles.ControlBusqueda();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVentasCobros)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 61);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(494, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 61);
            this.button1.TabIndex = 30;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cobros";
            // 
            // datagridVentasCobros
            // 
            this.datagridVentasCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridVentasCobros.Location = new System.Drawing.Point(14, 172);
            this.datagridVentasCobros.Name = "datagridVentasCobros";
            this.datagridVentasCobros.RowHeadersWidth = 51;
            this.datagridVentasCobros.RowTemplate.Height = 24;
            this.datagridVentasCobros.Size = new System.Drawing.Size(558, 171);
            this.datagridVentasCobros.TabIndex = 5;
            this.datagridVentasCobros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridVentasCobros_CellClick);
            this.datagridVentasCobros.SelectionChanged += new System.EventHandler(this.datagridVentasCobros_SelectionChanged);
            // 
            // lblTotalCobro
            // 
            this.lblTotalCobro.AutoSize = true;
            this.lblTotalCobro.Location = new System.Drawing.Point(16, 439);
            this.lblTotalCobro.Name = "lblTotalCobro";
            this.lblTotalCobro.Size = new System.Drawing.Size(114, 19);
            this.lblTotalCobro.TabIndex = 7;
            this.lblTotalCobro.Text = "Total de Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(8, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Registrar Cobro";
            // 
            // lblSaldoCobros
            // 
            this.lblSaldoCobros.AutoSize = true;
            this.lblSaldoCobros.Location = new System.Drawing.Point(16, 472);
            this.lblSaldoCobros.Name = "lblSaldoCobros";
            this.lblSaldoCobros.Size = new System.Drawing.Size(52, 19);
            this.lblSaldoCobros.TabIndex = 8;
            this.lblSaldoCobros.Text = "Saldo:";
            // 
            // cmbMetodoCobros
            // 
            this.cmbMetodoCobros.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMetodoCobros.FormattingEnabled = true;
            this.cmbMetodoCobros.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia",
            "Cheque"});
            this.cmbMetodoCobros.Location = new System.Drawing.Point(470, 482);
            this.cmbMetodoCobros.Name = "cmbMetodoCobros";
            this.cmbMetodoCobros.Size = new System.Drawing.Size(106, 24);
            this.cmbMetodoCobros.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Metodo de Pago";
            // 
            // btnRegistrarCobro
            // 
            this.btnRegistrarCobro.Location = new System.Drawing.Point(332, 519);
            this.btnRegistrarCobro.Name = "btnRegistrarCobro";
            this.btnRegistrarCobro.Size = new System.Drawing.Size(244, 34);
            this.btnRegistrarCobro.TabIndex = 13;
            this.btnRegistrarCobro.Text = "Registrar Cobro";
            this.btnRegistrarCobro.UseVisualStyleBackColor = true;
            this.btnRegistrarCobro.Click += new System.EventHandler(this.btnRegistrarCobro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-4, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 54);
            this.panel2.TabIndex = 14;
            // 
            // lblPendienteVenta
            // 
            this.lblPendienteVenta.AutoSize = true;
            this.lblPendienteVenta.Location = new System.Drawing.Point(16, 503);
            this.lblPendienteVenta.Name = "lblPendienteVenta";
            this.lblPendienteVenta.Size = new System.Drawing.Size(152, 19);
            this.lblPendienteVenta.TabIndex = 17;
            this.lblPendienteVenta.Text = "Pendiente de venta:";
            // 
            // lblValidaNumero1
            // 
            this.lblValidaNumero1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidaNumero1.Location = new System.Drawing.Point(389, 421);
            this.lblValidaNumero1.Margin = new System.Windows.Forms.Padding(4);
            this.lblValidaNumero1.Name = "lblValidaNumero1";
            this.lblValidaNumero1.Size = new System.Drawing.Size(210, 54);
            this.lblValidaNumero1.TabIndex = 16;
            this.lblValidaNumero1.TextoLabel = "Monto";
            // 
            // controlBusqueda1
            // 
            this.controlBusqueda1.DataSource = null;
            this.controlBusqueda1.DisplayMember = "";
            this.controlBusqueda1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlBusqueda1.Location = new System.Drawing.Point(-4, 68);
            this.controlBusqueda1.Margin = new System.Windows.Forms.Padding(4);
            this.controlBusqueda1.Name = "controlBusqueda1";
            this.controlBusqueda1.SelectedIndex = -1;
            this.controlBusqueda1.Size = new System.Drawing.Size(304, 97);
            this.controlBusqueda1.TabIndex = 15;
            this.controlBusqueda1.TextoBoton = "Buscar";
            this.controlBusqueda1.TextoLabel = "Cliente";
            this.controlBusqueda1.ValueMember = "";
            // 
            // Cobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(588, 565);
            this.Controls.Add(this.lblPendienteVenta);
            this.Controls.Add(this.lblValidaNumero1);
            this.Controls.Add(this.controlBusqueda1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRegistrarCobro);
            this.Controls.Add(this.cmbMetodoCobros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSaldoCobros);
            this.Controls.Add(this.lblTotalCobro);
            this.Controls.Add(this.datagridVentasCobros);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cobros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobros";
            this.Load += new System.EventHandler(this.Cobros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVentasCobros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridVentasCobros;
        private System.Windows.Forms.Label lblTotalCobro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaldoCobros;
        private System.Windows.Forms.ComboBox cmbMetodoCobros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrarCobro;
        private System.Windows.Forms.Panel panel2;
        private Controles.ControlBusqueda controlBusqueda1;
        private Controles.lblValidaNumero lblValidaNumero1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPendienteVenta;
    }
}