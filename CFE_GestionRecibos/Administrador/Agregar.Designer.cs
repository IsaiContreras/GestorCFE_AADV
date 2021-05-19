namespace CFE_GestionRecibos.Administrador
{
    partial class Agregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_nombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_apellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_dianac = new System.Windows.Forms.ComboBox();
            this.cbx_mesnac = new System.Windows.Forms.ComboBox();
            this.tbx_añonac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_curp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_rfc = new System.Windows.Forms.TextBox();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_deltel = new System.Windows.Forms.Button();
            this.btn_addtel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lbx_telefonos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres*";
            // 
            // tbx_nombres
            // 
            this.tbx_nombres.BackColor = System.Drawing.Color.DimGray;
            this.tbx_nombres.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_nombres.Location = new System.Drawing.Point(13, 34);
            this.tbx_nombres.MaxLength = 50;
            this.tbx_nombres.Name = "tbx_nombres";
            this.tbx_nombres.Size = new System.Drawing.Size(258, 22);
            this.tbx_nombres.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellidos*";
            // 
            // tbx_apellidos
            // 
            this.tbx_apellidos.BackColor = System.Drawing.Color.DimGray;
            this.tbx_apellidos.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_apellidos.Location = new System.Drawing.Point(13, 84);
            this.tbx_apellidos.MaxLength = 50;
            this.tbx_apellidos.Name = "tbx_apellidos";
            this.tbx_apellidos.Size = new System.Drawing.Size(258, 22);
            this.tbx_apellidos.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha de nacimiento*";
            // 
            // cbx_dianac
            // 
            this.cbx_dianac.BackColor = System.Drawing.Color.DimGray;
            this.cbx_dianac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_dianac.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_dianac.FormattingEnabled = true;
            this.cbx_dianac.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbx_dianac.Location = new System.Drawing.Point(117, 134);
            this.cbx_dianac.Name = "cbx_dianac";
            this.cbx_dianac.Size = new System.Drawing.Size(65, 24);
            this.cbx_dianac.TabIndex = 4;
            // 
            // cbx_mesnac
            // 
            this.cbx_mesnac.BackColor = System.Drawing.Color.DimGray;
            this.cbx_mesnac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mesnac.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_mesnac.FormattingEnabled = true;
            this.cbx_mesnac.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbx_mesnac.Location = new System.Drawing.Point(13, 134);
            this.cbx_mesnac.Name = "cbx_mesnac";
            this.cbx_mesnac.Size = new System.Drawing.Size(98, 24);
            this.cbx_mesnac.TabIndex = 3;
            this.cbx_mesnac.Tag = "";
            // 
            // tbx_añonac
            // 
            this.tbx_añonac.BackColor = System.Drawing.Color.DimGray;
            this.tbx_añonac.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_añonac.Location = new System.Drawing.Point(189, 134);
            this.tbx_añonac.MaxLength = 5;
            this.tbx_añonac.Name = "tbx_añonac";
            this.tbx_añonac.Size = new System.Drawing.Size(82, 22);
            this.tbx_añonac.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(10, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(114, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(186, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Año";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(16, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "CURP*";
            // 
            // tbx_curp
            // 
            this.tbx_curp.BackColor = System.Drawing.Color.DimGray;
            this.tbx_curp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_curp.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_curp.Location = new System.Drawing.Point(12, 227);
            this.tbx_curp.MaxLength = 18;
            this.tbx_curp.Name = "tbx_curp";
            this.tbx_curp.Size = new System.Drawing.Size(258, 22);
            this.tbx_curp.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(301, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "RFC";
            // 
            // tbx_rfc
            // 
            this.tbx_rfc.BackColor = System.Drawing.Color.DimGray;
            this.tbx_rfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_rfc.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_rfc.Location = new System.Drawing.Point(301, 33);
            this.tbx_rfc.MaxLength = 13;
            this.tbx_rfc.Name = "tbx_rfc";
            this.tbx_rfc.Size = new System.Drawing.Size(258, 22);
            this.tbx_rfc.TabIndex = 7;
            // 
            // tbx_email
            // 
            this.tbx_email.BackColor = System.Drawing.Color.DimGray;
            this.tbx_email.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_email.Location = new System.Drawing.Point(301, 84);
            this.tbx_email.MaxLength = 50;
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(258, 22);
            this.tbx_email.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(301, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Correo electrónico*";
            // 
            // tbx_password
            // 
            this.tbx_password.BackColor = System.Drawing.Color.DimGray;
            this.tbx_password.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_password.Location = new System.Drawing.Point(301, 134);
            this.tbx_password.MaxLength = 8;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(258, 22);
            this.tbx_password.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(301, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Contraseña*";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DimGray;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ok.Location = new System.Drawing.Point(301, 304);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(157, 27);
            this.btn_ok.TabIndex = 12;
            this.btn_ok.Text = "Agregar";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DimGray;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(466, 304);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(95, 27);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_deltel
            // 
            this.btn_deltel.BackColor = System.Drawing.Color.DimGray;
            this.btn_deltel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deltel.Location = new System.Drawing.Point(530, 255);
            this.btn_deltel.Name = "btn_deltel";
            this.btn_deltel.Size = new System.Drawing.Size(30, 30);
            this.btn_deltel.TabIndex = 11;
            this.btn_deltel.Text = "-";
            this.btn_deltel.UseVisualStyleBackColor = false;
            this.btn_deltel.Click += new System.EventHandler(this.btn_deltel_Click);
            // 
            // btn_addtel
            // 
            this.btn_addtel.BackColor = System.Drawing.Color.DimGray;
            this.btn_addtel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addtel.Location = new System.Drawing.Point(493, 255);
            this.btn_addtel.Name = "btn_addtel";
            this.btn_addtel.Size = new System.Drawing.Size(30, 30);
            this.btn_addtel.TabIndex = 10;
            this.btn_addtel.Text = "+";
            this.btn_addtel.UseVisualStyleBackColor = false;
            this.btn_addtel.Click += new System.EventHandler(this.btn_addtel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(298, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Teléfonos";
            // 
            // lbx_telefonos
            // 
            this.lbx_telefonos.BackColor = System.Drawing.Color.DimGray;
            this.lbx_telefonos.ForeColor = System.Drawing.SystemColors.Control;
            this.lbx_telefonos.FormattingEnabled = true;
            this.lbx_telefonos.ItemHeight = 16;
            this.lbx_telefonos.Location = new System.Drawing.Point(300, 181);
            this.lbx_telefonos.Name = "lbx_telefonos";
            this.lbx_telefonos.Size = new System.Drawing.Size(260, 68);
            this.lbx_telefonos.TabIndex = 0;
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(573, 343);
            this.Controls.Add(this.btn_deltel);
            this.Controls.Add(this.btn_addtel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbx_telefonos);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.tbx_rfc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_curp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_añonac);
            this.Controls.Add(this.cbx_mesnac);
            this.Controls.Add(this.cbx_dianac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_apellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_nombres);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(591, 390);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(591, 302);
            this.Name = "Agregar";
            this.Text = "Agregar empleado";
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_nombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_apellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_dianac;
        private System.Windows.Forms.ComboBox cbx_mesnac;
        private System.Windows.Forms.TextBox tbx_añonac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_curp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_rfc;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_deltel;
        private System.Windows.Forms.Button btn_addtel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lbx_telefonos;
    }
}