namespace CFE_GestionRecibos.Cliente
{
    partial class Información
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
            this.st_identity = new System.Windows.Forms.Label();
            this.st_username = new System.Windows.Forms.Label();
            this.st_email = new System.Windows.Forms.Label();
            this.st_domicilio = new System.Windows.Forms.Label();
            this.st_fecnac = new System.Windows.Forms.Label();
            this.st_edad = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbx_telefonos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // st_identity
            // 
            this.st_identity.AutoSize = true;
            this.st_identity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_identity.ForeColor = System.Drawing.SystemColors.Control;
            this.st_identity.Location = new System.Drawing.Point(13, 13);
            this.st_identity.Name = "st_identity";
            this.st_identity.Size = new System.Drawing.Size(31, 25);
            this.st_identity.TabIndex = 0;
            this.st_identity.Text = "ID";
            // 
            // st_username
            // 
            this.st_username.AutoSize = true;
            this.st_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_username.ForeColor = System.Drawing.SystemColors.Control;
            this.st_username.Location = new System.Drawing.Point(15, 38);
            this.st_username.Name = "st_username";
            this.st_username.Size = new System.Drawing.Size(177, 25);
            this.st_username.TabIndex = 0;
            this.st_username.Text = "Nombre de usuario";
            // 
            // st_email
            // 
            this.st_email.AutoSize = true;
            this.st_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_email.ForeColor = System.Drawing.SystemColors.Control;
            this.st_email.Location = new System.Drawing.Point(13, 90);
            this.st_email.Name = "st_email";
            this.st_email.Size = new System.Drawing.Size(171, 25);
            this.st_email.TabIndex = 0;
            this.st_email.Text = "Correo electrónico";
            // 
            // st_domicilio
            // 
            this.st_domicilio.AutoSize = true;
            this.st_domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_domicilio.ForeColor = System.Drawing.SystemColors.Control;
            this.st_domicilio.Location = new System.Drawing.Point(13, 115);
            this.st_domicilio.Name = "st_domicilio";
            this.st_domicilio.Size = new System.Drawing.Size(90, 25);
            this.st_domicilio.TabIndex = 0;
            this.st_domicilio.Text = "Domicilio";
            // 
            // st_fecnac
            // 
            this.st_fecnac.AutoSize = true;
            this.st_fecnac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_fecnac.ForeColor = System.Drawing.SystemColors.Control;
            this.st_fecnac.Location = new System.Drawing.Point(15, 171);
            this.st_fecnac.Name = "st_fecnac";
            this.st_fecnac.Size = new System.Drawing.Size(193, 25);
            this.st_fecnac.TabIndex = 0;
            this.st_fecnac.Text = "Fecha de nacimiento";
            // 
            // st_edad
            // 
            this.st_edad.AutoSize = true;
            this.st_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_edad.ForeColor = System.Drawing.SystemColors.Control;
            this.st_edad.Location = new System.Drawing.Point(15, 196);
            this.st_edad.Name = "st_edad";
            this.st_edad.Size = new System.Drawing.Size(58, 25);
            this.st_edad.TabIndex = 0;
            this.st_edad.Text = "Edad";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DimGray;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ok.Location = new System.Drawing.Point(301, 337);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(112, 28);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Aceptar";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbx_telefonos
            // 
            this.lbx_telefonos.BackColor = System.Drawing.Color.DimGray;
            this.lbx_telefonos.ForeColor = System.Drawing.SystemColors.Control;
            this.lbx_telefonos.FormattingEnabled = true;
            this.lbx_telefonos.ItemHeight = 16;
            this.lbx_telefonos.Location = new System.Drawing.Point(18, 256);
            this.lbx_telefonos.Name = "lbx_telefonos";
            this.lbx_telefonos.Size = new System.Drawing.Size(261, 100);
            this.lbx_telefonos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teléfonos";
            // 
            // Información
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(425, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_telefonos);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.st_edad);
            this.Controls.Add(this.st_fecnac);
            this.Controls.Add(this.st_domicilio);
            this.Controls.Add(this.st_email);
            this.Controls.Add(this.st_username);
            this.Controls.Add(this.st_identity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(443, 424);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(443, 324);
            this.Name = "Información";
            this.Text = "Información de usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label st_identity;
        private System.Windows.Forms.Label st_username;
        private System.Windows.Forms.Label st_email;
        private System.Windows.Forms.Label st_domicilio;
        private System.Windows.Forms.Label st_fecnac;
        private System.Windows.Forms.Label st_edad;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ListBox lbx_telefonos;
        private System.Windows.Forms.Label label1;
    }
}