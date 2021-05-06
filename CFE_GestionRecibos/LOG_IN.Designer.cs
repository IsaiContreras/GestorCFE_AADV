namespace CFE_GestionRecibos
{
    partial class LOG_IN
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.cbx_usertype = new System.Windows.Forms.ComboBox();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chb_rememberme = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbx_username
            // 
            this.tbx_username.BackColor = System.Drawing.Color.DimGray;
            this.tbx_username.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_username.Location = new System.Drawing.Point(53, 140);
            this.tbx_username.MaxLength = 50;
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(228, 22);
            this.tbx_username.TabIndex = 1;
            // 
            // cbx_usertype
            // 
            this.cbx_usertype.BackColor = System.Drawing.Color.DimGray;
            this.cbx_usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_usertype.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_usertype.FormattingEnabled = true;
            this.cbx_usertype.Items.AddRange(new object[] {
            "Cliente",
            "Empleado",
            "Administrador"});
            this.cbx_usertype.Location = new System.Drawing.Point(53, 74);
            this.cbx_usertype.Name = "cbx_usertype";
            this.cbx_usertype.Size = new System.Drawing.Size(141, 24);
            this.cbx_usertype.TabIndex = 0;
            // 
            // PASSWORD
            // 
            this.PASSWORD.BackColor = System.Drawing.Color.DimGray;
            this.PASSWORD.ForeColor = System.Drawing.SystemColors.Control;
            this.PASSWORD.Location = new System.Drawing.Point(53, 192);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.PasswordChar = '*';
            this.PASSWORD.Size = new System.Drawing.Size(228, 22);
            this.PASSWORD.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DimGray;
            this.btn_login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_login.Location = new System.Drawing.Point(112, 289);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(112, 37);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(50, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(50, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // chb_rememberme
            // 
            this.chb_rememberme.AutoSize = true;
            this.chb_rememberme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chb_rememberme.ForeColor = System.Drawing.SystemColors.Control;
            this.chb_rememberme.Location = new System.Drawing.Point(117, 220);
            this.chb_rememberme.Name = "chb_rememberme";
            this.chb_rememberme.Size = new System.Drawing.Size(164, 21);
            this.chb_rememberme.TabIndex = 3;
            this.chb_rememberme.Text = "Recordar contraseña";
            this.chb_rememberme.UseVisualStyleBackColor = false;
            // 
            // LOG_IN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(342, 353);
            this.Controls.Add(this.chb_rememberme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.cbx_usertype);
            this.Controls.Add(this.tbx_username);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 400);
            this.MinimumSize = new System.Drawing.Size(360, 400);
            this.Name = "LOG_IN";
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.LOG_IN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.ComboBox cbx_usertype;
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chb_rememberme;
    }
}

