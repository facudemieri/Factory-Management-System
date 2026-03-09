namespace GUI
{
    partial class CompraInsumos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagridCompraInsumos = new System.Windows.Forms.DataGridView();
            this.btnAgregarProdInsumos = new System.Windows.Forms.Button();
            this.btnEliminarProdInsumos = new System.Windows.Forms.Button();
            this.btnGuardarCompraInsumos = new System.Windows.Forms.Button();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.cmbProveedorInsumos = new System.Windows.Forms.ComboBox();
            this.dtFehcaInsumos = new System.Windows.Forms.DateTimePicker();
            this.txtComprobanteInsumos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCompraInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compra Insumos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comprobante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Detalle Compra";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 50);
            this.panel2.TabIndex = 5;
            // 
            // datagridCompraInsumos
            // 
            this.datagridCompraInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCompraInsumos.Location = new System.Drawing.Point(12, 279);
            this.datagridCompraInsumos.Name = "datagridCompraInsumos";
            this.datagridCompraInsumos.RowHeadersWidth = 51;
            this.datagridCompraInsumos.RowTemplate.Height = 24;
            this.datagridCompraInsumos.Size = new System.Drawing.Size(529, 163);
            this.datagridCompraInsumos.TabIndex = 6;
            this.datagridCompraInsumos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridCompraInsumos_CellEndEdit);
            // 
            // btnAgregarProdInsumos
            // 
            this.btnAgregarProdInsumos.Location = new System.Drawing.Point(557, 291);
            this.btnAgregarProdInsumos.Name = "btnAgregarProdInsumos";
            this.btnAgregarProdInsumos.Size = new System.Drawing.Size(45, 43);
            this.btnAgregarProdInsumos.TabIndex = 7;
            this.btnAgregarProdInsumos.Text = "+";
            this.btnAgregarProdInsumos.UseVisualStyleBackColor = true;
            this.btnAgregarProdInsumos.Click += new System.EventHandler(this.btnAgregarProdInsumos_Click);
            // 
            // btnEliminarProdInsumos
            // 
            this.btnEliminarProdInsumos.Location = new System.Drawing.Point(557, 340);
            this.btnEliminarProdInsumos.Name = "btnEliminarProdInsumos";
            this.btnEliminarProdInsumos.Size = new System.Drawing.Size(45, 40);
            this.btnEliminarProdInsumos.TabIndex = 8;
            this.btnEliminarProdInsumos.Text = "-";
            this.btnEliminarProdInsumos.UseVisualStyleBackColor = true;
            this.btnEliminarProdInsumos.Click += new System.EventHandler(this.btnEliminarProdInsumos_Click);
            // 
            // btnGuardarCompraInsumos
            // 
            this.btnGuardarCompraInsumos.Location = new System.Drawing.Point(374, 457);
            this.btnGuardarCompraInsumos.Name = "btnGuardarCompraInsumos";
            this.btnGuardarCompraInsumos.Size = new System.Drawing.Size(167, 32);
            this.btnGuardarCompraInsumos.TabIndex = 9;
            this.btnGuardarCompraInsumos.Text = "Guardar Compra";
            this.btnGuardarCompraInsumos.UseVisualStyleBackColor = true;
            this.btnGuardarCompraInsumos.Click += new System.EventHandler(this.btnGuardarCompraInsumos_Click);
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Location = new System.Drawing.Point(12, 457);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(106, 19);
            this.lblTotalCompra.TabIndex = 10;
            this.lblTotalCompra.Text = "Total Compra:";
            // 
            // cmbProveedorInsumos
            // 
            this.cmbProveedorInsumos.FormattingEnabled = true;
            this.cmbProveedorInsumos.Location = new System.Drawing.Point(153, 63);
            this.cmbProveedorInsumos.Name = "cmbProveedorInsumos";
            this.cmbProveedorInsumos.Size = new System.Drawing.Size(143, 27);
            this.cmbProveedorInsumos.TabIndex = 11;
            // 
            // dtFehcaInsumos
            // 
            this.dtFehcaInsumos.Location = new System.Drawing.Point(153, 99);
            this.dtFehcaInsumos.Name = "dtFehcaInsumos";
            this.dtFehcaInsumos.Size = new System.Drawing.Size(200, 24);
            this.dtFehcaInsumos.TabIndex = 12;
            // 
            // txtComprobanteInsumos
            // 
            this.txtComprobanteInsumos.Location = new System.Drawing.Point(153, 134);
            this.txtComprobanteInsumos.Name = "txtComprobanteInsumos";
            this.txtComprobanteInsumos.Size = new System.Drawing.Size(143, 24);
            this.txtComprobanteInsumos.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(534, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 48);
            this.button1.TabIndex = 27;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CompraInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(618, 514);
            this.Controls.Add(this.txtComprobanteInsumos);
            this.Controls.Add(this.dtFehcaInsumos);
            this.Controls.Add(this.cmbProveedorInsumos);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.btnGuardarCompraInsumos);
            this.Controls.Add(this.btnEliminarProdInsumos);
            this.Controls.Add(this.btnAgregarProdInsumos);
            this.Controls.Add(this.datagridCompraInsumos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompraInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompraInsumos";
            this.Load += new System.EventHandler(this.CompraInsumos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCompraInsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView datagridCompraInsumos;
        private System.Windows.Forms.Button btnAgregarProdInsumos;
        private System.Windows.Forms.Button btnEliminarProdInsumos;
        private System.Windows.Forms.Button btnGuardarCompraInsumos;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.ComboBox cmbProveedorInsumos;
        private System.Windows.Forms.DateTimePicker dtFehcaInsumos;
        private System.Windows.Forms.TextBox txtComprobanteInsumos;
        private System.Windows.Forms.Button button1;
    }
}