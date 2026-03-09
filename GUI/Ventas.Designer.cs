namespace GUI
{
    partial class Ventas
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
            this.btnIniciarProduccion = new System.Windows.Forms.Button();
            this.datagridPedidosAprobados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalFacturado = new System.Windows.Forms.Label();
            this.lblVentasHoy = new System.Windows.Forms.Label();
            this.controlBusqueda1 = new GUI.Controles.ControlBusqueda();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidosAprobados)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarProduccion
            // 
            this.btnIniciarProduccion.Location = new System.Drawing.Point(506, 249);
            this.btnIniciarProduccion.Name = "btnIniciarProduccion";
            this.btnIniciarProduccion.Size = new System.Drawing.Size(133, 38);
            this.btnIniciarProduccion.TabIndex = 7;
            this.btnIniciarProduccion.Text = "Generar Factura";
            this.btnIniciarProduccion.UseVisualStyleBackColor = true;
            this.btnIniciarProduccion.Click += new System.EventHandler(this.btnIniciarProduccion_Click);
            // 
            // datagridPedidosAprobados
            // 
            this.datagridPedidosAprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPedidosAprobados.Location = new System.Drawing.Point(19, 249);
            this.datagridPedidosAprobados.Name = "datagridPedidosAprobados";
            this.datagridPedidosAprobados.RowHeadersWidth = 51;
            this.datagridPedidosAprobados.RowTemplate.Height = 24;
            this.datagridPedidosAprobados.Size = new System.Drawing.Size(481, 143);
            this.datagridPedidosAprobados.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pedidos Finalizados";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 46);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(484, 133);
            this.dataGridView1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ventas Realizadas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 225);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotalFacturado);
            this.panel3.Controls.Add(this.lblVentasHoy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 52);
            this.panel3.TabIndex = 11;
            // 
            // lblTotalFacturado
            // 
            this.lblTotalFacturado.AutoSize = true;
            this.lblTotalFacturado.Location = new System.Drawing.Point(330, 16);
            this.lblTotalFacturado.Name = "lblTotalFacturado";
            this.lblTotalFacturado.Size = new System.Drawing.Size(153, 19);
            this.lblTotalFacturado.TabIndex = 1;
            this.lblTotalFacturado.Text = "Total Facturado Hoy:";
            // 
            // lblVentasHoy
            // 
            this.lblVentasHoy.AutoSize = true;
            this.lblVentasHoy.Location = new System.Drawing.Point(15, 16);
            this.lblVentasHoy.Name = "lblVentasHoy";
            this.lblVentasHoy.Size = new System.Drawing.Size(91, 19);
            this.lblVentasHoy.TabIndex = 0;
            this.lblVentasHoy.Text = "Ventas Hoy:";
            // 
            // controlBusqueda1
            // 
            this.controlBusqueda1.DataSource = null;
            this.controlBusqueda1.DisplayMember = "";
            this.controlBusqueda1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlBusqueda1.Location = new System.Drawing.Point(0, 142);
            this.controlBusqueda1.Margin = new System.Windows.Forms.Padding(4);
            this.controlBusqueda1.Name = "controlBusqueda1";
            this.controlBusqueda1.SelectedIndex = -1;
            this.controlBusqueda1.Size = new System.Drawing.Size(264, 100);
            this.controlBusqueda1.TabIndex = 12;
            this.controlBusqueda1.TextoBoton = "Buscar";
            this.controlBusqueda1.TextoLabel = "Cliente";
            this.controlBusqueda1.ValueMember = "";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(534, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 46);
            this.button1.TabIndex = 30;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(651, 634);
            this.Controls.Add(this.controlBusqueda1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnIniciarProduccion);
            this.Controls.Add(this.datagridPedidosAprobados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidosAprobados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarProduccion;
        private System.Windows.Forms.DataGridView datagridPedidosAprobados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalFacturado;
        private System.Windows.Forms.Label lblVentasHoy;
        private Controles.ControlBusqueda controlBusqueda1;
        private System.Windows.Forms.Button button1;
    }
}