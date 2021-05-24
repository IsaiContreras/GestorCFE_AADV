namespace CFE_GestionRecibos.Empleado
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.st_edad = new System.Windows.Forms.Label();
            this.st_fecnac = new System.Windows.Forms.Label();
            this.st_email = new System.Windows.Forms.Label();
            this.st_username = new System.Windows.Forms.Label();
            this.st_identity = new System.Windows.Forms.Label();
            this.st_curp = new System.Windows.Forms.Label();
            this.st_rfc = new System.Windows.Forms.Label();
            this.lbx_telefonos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DimGray;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ok.Location = new System.Drawing.Point(281, 326);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(239, 28);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Regresar";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // st_edad
            // 
            this.st_edad.AutoSize = true;
            this.st_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_edad.ForeColor = System.Drawing.SystemColors.Control;
            this.st_edad.Location = new System.Drawing.Point(12, 180);
            this.st_edad.Name = "st_edad";
            this.st_edad.Size = new System.Drawing.Size(47, 20);
            this.st_edad.TabIndex = 0;
            this.st_edad.Text = "Edad";
            // 
            // st_fecnac
            // 
            this.st_fecnac.AutoSize = true;
            this.st_fecnac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_fecnac.ForeColor = System.Drawing.SystemColors.Control;
            this.st_fecnac.Location = new System.Drawing.Point(12, 160);
            this.st_fecnac.Name = "st_fecnac";
            this.st_fecnac.Size = new System.Drawing.Size(164, 20);
            this.st_fecnac.TabIndex = 0;
            this.st_fecnac.Text = "Fecha de nacimiento";
            // 
            // st_email
            // 
            this.st_email.AutoSize = true;
            this.st_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_email.ForeColor = System.Drawing.SystemColors.Control;
            this.st_email.Location = new System.Drawing.Point(12, 63);
            this.st_email.Name = "st_email";
            this.st_email.Size = new System.Drawing.Size(147, 20);
            this.st_email.TabIndex = 0;
            this.st_email.Text = "Correo electrónico";
            // 
            // st_username
            // 
            this.st_username.AutoSize = true;
            this.st_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_username.ForeColor = System.Drawing.SystemColors.Control;
            this.st_username.Location = new System.Drawing.Point(12, 43);
            this.st_username.Name = "st_username";
            this.st_username.Size = new System.Drawing.Size(151, 20);
            this.st_username.TabIndex = 0;
            this.st_username.Text = "Nombre de usuario";
            // 
            // st_identity
            // 
            this.st_identity.AutoSize = true;
            this.st_identity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_identity.ForeColor = System.Drawing.SystemColors.Control;
            this.st_identity.Location = new System.Drawing.Point(12, 9);
            this.st_identity.Name = "st_identity";
            this.st_identity.Size = new System.Drawing.Size(26, 20);
            this.st_identity.TabIndex = 0;
            this.st_identity.Text = "ID";
            // 
            // st_curp
            // 
            this.st_curp.AutoSize = true;
            this.st_curp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_curp.ForeColor = System.Drawing.SystemColors.Control;
            this.st_curp.Location = new System.Drawing.Point(11, 105);
            this.st_curp.Name = "st_curp";
            this.st_curp.Size = new System.Drawing.Size(56, 20);
            this.st_curp.TabIndex = 0;
            this.st_curp.Text = "CURP";
            // 
            // st_rfc
            // 
            this.st_rfc.AutoSize = true;
            this.st_rfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_rfc.ForeColor = System.Drawing.SystemColors.Control;
            this.st_rfc.Location = new System.Drawing.Point(12, 125);
            this.st_rfc.Name = "st_rfc";
            this.st_rfc.Size = new System.Drawing.Size(43, 20);
            this.st_rfc.TabIndex = 0;
            this.st_rfc.Text = "RFC";
            // 
            // lbx_telefonos
            // 
            this.lbx_telefonos.BackColor = System.Drawing.Color.DimGray;
            this.lbx_telefonos.ForeColor = System.Drawing.SystemColors.Control;
            this.lbx_telefonos.FormattingEnabled = true;
            this.lbx_telefonos.ItemHeight = 16;
            this.lbx_telefonos.Location = new System.Drawing.Point(17, 270);
            this.lbx_telefonos.Name = "lbx_telefonos";
            this.lbx_telefonos.Size = new System.Drawing.Size(258, 84);
            this.lbx_telefonos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 250);
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
            this.ClientSize = new System.Drawing.Size(532, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_telefonos);
            this.Controls.Add(this.st_rfc);
            this.Controls.Add(this.st_curp);
            this.Controls.Add(this.st_edad);
            this.Controls.Add(this.st_fecnac);
            this.Controls.Add(this.st_email);
            this.Controls.Add(this.st_username);
            this.Controls.Add(this.st_identity);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 424);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 424);
            this.Name = "Información";
            this.Text = "Información de empleado";
            this.Load += new System.EventHandler(this.Información_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label st_edad;
        private System.Windows.Forms.Label st_fecnac;
        private System.Windows.Forms.Label st_email;
        private System.Windows.Forms.Label st_username;
        private System.Windows.Forms.Label st_identity;
        private System.Windows.Forms.Label st_curp;
        private System.Windows.Forms.Label st_rfc;
        private System.Windows.Forms.ListBox lbx_telefonos;
        private System.Windows.Forms.Label label1;
    }
}