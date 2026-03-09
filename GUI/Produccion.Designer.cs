namespace GUI
{
    partial class Produccion
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
            this.datagridPedidosAprobados = new System.Windows.Forms.DataGridView();
            this.btnIniciarProduccion = new System.Windows.Forms.Button();
            this.btnFinalizarProduccion = new System.Windows.Forms.Button();
            this.datagridPedidosenProd = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.lblCantAprobados = new System.Windows.Forms.Label();
            this.lblCantEnProduccion = new System.Windows.Forms.Label();
            this.lblFinalizadosHoy = new System.Windows.Forms.Label();
            this.controlBusqueda1 = new GUI.Controles.ControlBusqueda();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidosAprobados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidosenProd)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pedidos Aprobados";
            // 
            // datagridPedidosAprobados
            // 
            this.datagridPedidosAprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPedidosAprobados.Location = new System.Drawing.Point(17, 261);
            this.datagridPedidosAprobados.Name = "datagridPedidosAprobados";
            this.datagridPedidosAprobados.RowHeadersWidth = 51;
            this.datagridPedidosAprobados.RowTemplate.Height = 24;
            this.datagridPedidosAprobados.Size = new System.Drawing.Size(476, 133);
            this.datagridPedidosAprobados.TabIndex = 2;
            // 
            // btnIniciarProduccion
            // 
            this.btnIniciarProduccion.Location = new System.Drawing.Point(505, 261);
            this.btnIniciarProduccion.Name = "btnIniciarProduccion";
            this.btnIniciarProduccion.Size = new System.Drawing.Size(152, 38);
            this.btnIniciarProduccion.TabIndex = 3;
            this.btnIniciarProduccion.Text = "Iniciar Produccion";
            this.btnIniciarProduccion.UseVisualStyleBackColor = true;
            this.btnIniciarProduccion.Click += new System.EventHandler(this.btnIniciarProduccion_Click);
            // 
            // btnFinalizarProduccion
            // 
            this.btnFinalizarProduccion.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarProduccion.Location = new System.Drawing.Point(505, 46);
            this.btnFinalizarProduccion.Name = "btnFinalizarProduccion";
            this.btnFinalizarProduccion.Size = new System.Drawing.Size(152, 48);
            this.btnFinalizarProduccion.TabIndex = 5;
            this.btnFinalizarProduccion.Text = "Finalizar Produccion";
            this.btnFinalizarProduccion.UseVisualStyleBackColor = false;
            this.btnFinalizarProduccion.Click += new System.EventHandler(this.btnFinalizarProduccion_Click);
            // 
            // datagridPedidosenProd
            // 
            this.datagridPedidosenProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPedidosenProd.Location = new System.Drawing.Point(17, 46);
            this.datagridPedidosenProd.Name = "datagridPedidosenProd";
            this.datagridPedidosenProd.RowHeadersWidth = 51;
            this.datagridPedidosenProd.RowTemplate.Height = 24;
            this.datagridPedidosenProd.Size = new System.Drawing.Size(476, 147);
            this.datagridPedidosenProd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pedidos en Produccion";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnFinalizarProduccion);
            this.panel2.Controls.Add(this.datagridPedidosenProd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 258);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 104);
            this.panel3.TabIndex = 9;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.lblFinalizadosHoy);
            this.panelDashboard.Controls.Add(this.lblCantEnProduccion);
            this.panelDashboard.Controls.Add(this.lblCantAprobados);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashboard.Location = new System.Drawing.Point(0, 50);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(669, 70);
            this.panelDashboard.TabIndex = 9;
            // 
            // lblCantAprobados
            // 
            this.lblCantAprobados.AutoSize = true;
            this.lblCantAprobados.Location = new System.Drawing.Point(18, 22);
            this.lblCantAprobados.Name = "lblCantAprobados";
            this.lblCantAprobados.Size = new System.Drawing.Size(89, 19);
            this.lblCantAprobados.TabIndex = 0;
            this.lblCantAprobados.Text = "Aprobados:";
            // 
            // lblCantEnProduccion
            // 
            this.lblCantEnProduccion.AutoSize = true;
            this.lblCantEnProduccion.Location = new System.Drawing.Point(243, 22);
            this.lblCantEnProduccion.Name = "lblCantEnProduccion";
            this.lblCantEnProduccion.Size = new System.Drawing.Size(113, 19);
            this.lblCantEnProduccion.TabIndex = 1;
            this.lblCantEnProduccion.Text = "En Produccion:";
            // 
            // lblFinalizadosHoy
            // 
            this.lblFinalizadosHoy.AutoSize = true;
            this.lblFinalizadosHoy.Location = new System.Drawing.Point(480, 22);
            this.lblFinalizadosHoy.Name = "lblFinalizadosHoy";
            this.lblFinalizadosHoy.Size = new System.Drawing.Size(88, 19);
            this.lblFinalizadosHoy.TabIndex = 2;
            this.lblFinalizadosHoy.Text = "Finalizados:";
            // 
            // controlBusqueda1
            // 
            this.controlBusqueda1.DataSource = null;
            this.controlBusqueda1.DisplayMember = "";
            this.controlBusqueda1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlBusqueda1.Location = new System.Drawing.Point(-9, 157);
            this.controlBusqueda1.Margin = new System.Windows.Forms.Padding(4);
            this.controlBusqueda1.Name = "controlBusqueda1";
            this.controlBusqueda1.SelectedIndex = -1;
            this.controlBusqueda1.Size = new System.Drawing.Size(304, 97);
            this.controlBusqueda1.TabIndex = 8;
            this.controlBusqueda1.TextoBoton = "Buscar";
            this.controlBusqueda1.TextoLabel = "Cliente";
            this.controlBusqueda1.ValueMember = "";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(552, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 50);
            this.button1.TabIndex = 29;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(669, 672);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.controlBusqueda1);
            this.Controls.Add(this.btnIniciarProduccion);
            this.Controls.Add(this.datagridPedidosAprobados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Produccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.Produccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidosAprobados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidosenProd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagridPedidosAprobados;
        private System.Windows.Forms.Button btnIniciarProduccion;
        private System.Windows.Forms.Button btnFinalizarProduccion;
        private System.Windows.Forms.DataGridView datagridPedidosenProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private Controles.ControlBusqueda controlBusqueda1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label lblFinalizadosHoy;
        private System.Windows.Forms.Label lblCantEnProduccion;
        private System.Windows.Forms.Label lblCantAprobados;
        private System.Windows.Forms.Button button1;
    }
}