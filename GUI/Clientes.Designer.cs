namespace GUI
{
    partial class Clientes
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.txtTelefonoCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIDcli = new System.Windows.Forms.Label();
            this.datagridCli = new System.Windows.Forms.DataGridView();
            this.btnAgregarCli = new System.Windows.Forms.Button();
            this.btnEditarCli = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCli)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(644, 55);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(550, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 55);
            this.button1.TabIndex = 30;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.Location = new System.Drawing.Point(115, 103);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(155, 24);
            this.txtNombreCli.TabIndex = 2;
            // 
            // txtTelefonoCli
            // 
            this.txtTelefonoCli.Location = new System.Drawing.Point(115, 162);
            this.txtTelefonoCli.Name = "txtTelefonoCli";
            this.txtTelefonoCli.Size = new System.Drawing.Size(155, 24);
            this.txtTelefonoCli.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono:";
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.Location = new System.Drawing.Point(115, 196);
            this.txtEmailCli.Name = "txtEmailCli";
            this.txtEmailCli.Size = new System.Drawing.Size(155, 24);
            this.txtEmailCli.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Id:";
            // 
            // lblIDcli
            // 
            this.lblIDcli.AutoSize = true;
            this.lblIDcli.Location = new System.Drawing.Point(111, 72);
            this.lblIDcli.Name = "lblIDcli";
            this.lblIDcli.Size = new System.Drawing.Size(21, 19);
            this.lblIDcli.TabIndex = 8;
            this.lblIDcli.Text = "...";
            // 
            // datagridCli
            // 
            this.datagridCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCli.Location = new System.Drawing.Point(18, 257);
            this.datagridCli.Name = "datagridCli";
            this.datagridCli.RowHeadersWidth = 51;
            this.datagridCli.RowTemplate.Height = 24;
            this.datagridCli.Size = new System.Drawing.Size(548, 181);
            this.datagridCli.TabIndex = 9;
            this.datagridCli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridCli_CellClick);
            // 
            // btnAgregarCli
            // 
            this.btnAgregarCli.Location = new System.Drawing.Point(582, 217);
            this.btnAgregarCli.Name = "btnAgregarCli";
            this.btnAgregarCli.Size = new System.Drawing.Size(49, 44);
            this.btnAgregarCli.TabIndex = 10;
            this.btnAgregarCli.Text = "+";
            this.btnAgregarCli.UseVisualStyleBackColor = true;
            this.btnAgregarCli.Click += new System.EventHandler(this.btnAgregarCli_Click);
            // 
            // btnEditarCli
            // 
            this.btnEditarCli.Location = new System.Drawing.Point(582, 267);
            this.btnEditarCli.Name = "btnEditarCli";
            this.btnEditarCli.Size = new System.Drawing.Size(49, 44);
            this.btnEditarCli.TabIndex = 12;
            this.btnEditarCli.Text = "...";
            this.btnEditarCli.UseVisualStyleBackColor = true;
            this.btnEditarCli.Click += new System.EventHandler(this.btnEditarCli_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(115, 133);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 24);
            this.txtApellido.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Apellido:";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(644, 460);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditarCli);
            this.Controls.Add(this.btnAgregarCli);
            this.Controls.Add(this.datagridCli);
            this.Controls.Add(this.lblIDcli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmailCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefonoCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.TextBox txtTelefonoCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIDcli;
        private System.Windows.Forms.DataGridView datagridCli;
        private System.Windows.Forms.Button btnAgregarCli;
        private System.Windows.Forms.Button btnEditarCli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label6;
    }
}