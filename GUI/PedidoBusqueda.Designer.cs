namespace GUI
{
    partial class PedidoBusqueda
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridPedidos = new System.Windows.Forms.DataGridView();
            this.cmbClientePedi = new System.Windows.Forms.ComboBox();
            this.cmbEstadoPedi = new System.Windows.Forms.ComboBox();
            this.btnNuevoPedi = new System.Windows.Forms.Button();
            this.btnEditarPedi = new System.Windows.Forms.Button();
            this.btnAprobarPedi = new System.Windows.Forms.Button();
            this.btnCancelarPedi = new System.Windows.Forms.Button();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.listBoxDetalles = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 90);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 90);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // datagridPedidos
            // 
            this.datagridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPedidos.Location = new System.Drawing.Point(18, 215);
            this.datagridPedidos.Name = "datagridPedidos";
            this.datagridPedidos.RowHeadersWidth = 51;
            this.datagridPedidos.RowTemplate.Height = 24;
            this.datagridPedidos.Size = new System.Drawing.Size(663, 207);
            this.datagridPedidos.TabIndex = 1;
            this.datagridPedidos.SelectionChanged += new System.EventHandler(this.datagridPedidos_SelectionChanged);
            // 
            // cmbClientePedi
            // 
            this.cmbClientePedi.FormattingEnabled = true;
            this.cmbClientePedi.Location = new System.Drawing.Point(90, 101);
            this.cmbClientePedi.Name = "cmbClientePedi";
            this.cmbClientePedi.Size = new System.Drawing.Size(153, 27);
            this.cmbClientePedi.TabIndex = 2;
            // 
            // cmbEstadoPedi
            // 
            this.cmbEstadoPedi.FormattingEnabled = true;
            this.cmbEstadoPedi.Location = new System.Drawing.Point(90, 136);
            this.cmbEstadoPedi.Name = "cmbEstadoPedi";
            this.cmbEstadoPedi.Size = new System.Drawing.Size(153, 27);
            this.cmbEstadoPedi.TabIndex = 3;
            // 
            // btnNuevoPedi
            // 
            this.btnNuevoPedi.Location = new System.Drawing.Point(694, 214);
            this.btnNuevoPedi.Name = "btnNuevoPedi";
            this.btnNuevoPedi.Size = new System.Drawing.Size(99, 34);
            this.btnNuevoPedi.TabIndex = 5;
            this.btnNuevoPedi.Text = "+";
            this.btnNuevoPedi.UseVisualStyleBackColor = true;
            this.btnNuevoPedi.Click += new System.EventHandler(this.btnNuevoPedi_Click);
            // 
            // btnEditarPedi
            // 
            this.btnEditarPedi.Location = new System.Drawing.Point(694, 254);
            this.btnEditarPedi.Name = "btnEditarPedi";
            this.btnEditarPedi.Size = new System.Drawing.Size(99, 34);
            this.btnEditarPedi.TabIndex = 6;
            this.btnEditarPedi.Text = "...";
            this.btnEditarPedi.UseVisualStyleBackColor = true;
            this.btnEditarPedi.Click += new System.EventHandler(this.btnEditarPedi_Click);
            // 
            // btnAprobarPedi
            // 
            this.btnAprobarPedi.Location = new System.Drawing.Point(694, 294);
            this.btnAprobarPedi.Name = "btnAprobarPedi";
            this.btnAprobarPedi.Size = new System.Drawing.Size(99, 36);
            this.btnAprobarPedi.TabIndex = 7;
            this.btnAprobarPedi.Text = "Aprobar";
            this.btnAprobarPedi.UseVisualStyleBackColor = true;
            this.btnAprobarPedi.Click += new System.EventHandler(this.btnAprobarPedi_Click);
            // 
            // btnCancelarPedi
            // 
            this.btnCancelarPedi.Location = new System.Drawing.Point(694, 336);
            this.btnCancelarPedi.Name = "btnCancelarPedi";
            this.btnCancelarPedi.Size = new System.Drawing.Size(99, 37);
            this.btnCancelarPedi.TabIndex = 8;
            this.btnCancelarPedi.Text = "Cancelar";
            this.btnCancelarPedi.UseVisualStyleBackColor = true;
            this.btnCancelarPedi.Click += new System.EventHandler(this.btnCancelarPedi_Click);
            // 
            // dtDesde
            // 
            this.dtDesde.Location = new System.Drawing.Point(335, 102);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(200, 24);
            this.dtDesde.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Detalles Pedido";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(0, 441);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 49);
            this.panel3.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(20, 169);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(223, 27);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hasta";
            // 
            // dtHasta
            // 
            this.dtHasta.Location = new System.Drawing.Point(335, 134);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(200, 24);
            this.dtHasta.TabIndex = 16;
            // 
            // listBoxDetalles
            // 
            this.listBoxDetalles.FormattingEnabled = true;
            this.listBoxDetalles.ItemHeight = 19;
            this.listBoxDetalles.Location = new System.Drawing.Point(18, 497);
            this.listBoxDetalles.Name = "listBoxDetalles";
            this.listBoxDetalles.Size = new System.Drawing.Size(663, 232);
            this.listBoxDetalles.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(688, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 90);
            this.button1.TabIndex = 29;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PedidoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(805, 748);
            this.Controls.Add(this.listBoxDetalles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.btnCancelarPedi);
            this.Controls.Add(this.btnAprobarPedi);
            this.Controls.Add(this.btnEditarPedi);
            this.Controls.Add(this.btnNuevoPedi);
            this.Controls.Add(this.cmbEstadoPedi);
            this.Controls.Add(this.cmbClientePedi);
            this.Controls.Add(this.datagridPedidos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PedidoBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidoBusqueda";
            this.Load += new System.EventHandler(this.PedidoBusqueda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridPedidos;
        private System.Windows.Forms.ComboBox cmbClientePedi;
        private System.Windows.Forms.ComboBox cmbEstadoPedi;
        private System.Windows.Forms.Button btnNuevoPedi;
        private System.Windows.Forms.Button btnEditarPedi;
        private System.Windows.Forms.Button btnAprobarPedi;
        private System.Windows.Forms.Button btnCancelarPedi;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.ListBox listBoxDetalles;
        private System.Windows.Forms.Button button1;
    }
}