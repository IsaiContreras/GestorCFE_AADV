namespace CFE_GestionRecibos.Administrador
{
    partial class RegistroDetalles
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
            this.st_registroid = new System.Windows.Forms.Label();
            this.st_numempl = new System.Windows.Forms.Label();
            this.st_actividad = new System.Windows.Forms.Label();
            this.st_desc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DimGray;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ok.Location = new System.Drawing.Point(261, 307);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(108, 26);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Aceptar";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // st_registroid
            // 
            this.st_registroid.AutoSize = true;
            this.st_registroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_registroid.ForeColor = System.Drawing.SystemColors.Control;
            this.st_registroid.Location = new System.Drawing.Point(13, 13);
            this.st_registroid.Name = "st_registroid";
            this.st_registroid.Size = new System.Drawing.Size(99, 20);
            this.st_registroid.TabIndex = 0;
            this.st_registroid.Text = "ID Registro:";
            // 
            // st_numempl
            // 
            this.st_numempl.AutoSize = true;
            this.st_numempl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_numempl.ForeColor = System.Drawing.SystemColors.Control;
            this.st_numempl.Location = new System.Drawing.Point(13, 69);
            this.st_numempl.Name = "st_numempl";
            this.st_numempl.Size = new System.Drawing.Size(158, 20);
            this.st_numempl.TabIndex = 0;
            this.st_numempl.Text = "Núm. de empleado: ";
            // 
            // st_actividad
            // 
            this.st_actividad.AutoSize = true;
            this.st_actividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_actividad.ForeColor = System.Drawing.SystemColors.Control;
            this.st_actividad.Location = new System.Drawing.Point(13, 130);
            this.st_actividad.Name = "st_actividad";
            this.st_actividad.Size = new System.Drawing.Size(82, 20);
            this.st_actividad.TabIndex = 0;
            this.st_actividad.Text = "Actividad:";
            // 
            // st_desc
            // 
            this.st_desc.AutoSize = true;
            this.st_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_desc.ForeColor = System.Drawing.SystemColors.Control;
            this.st_desc.Location = new System.Drawing.Point(13, 193);
            this.st_desc.Name = "st_desc";
            this.st_desc.Size = new System.Drawing.Size(109, 20);
            this.st_desc.TabIndex = 0;
            this.st_desc.Text = "Descripción: ";
            // 
            // RegistroDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(381, 345);
            this.Controls.Add(this.st_desc);
            this.Controls.Add(this.st_actividad);
            this.Controls.Add(this.st_numempl);
            this.Controls.Add(this.st_registroid);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(399, 392);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(399, 392);
            this.Name = "RegistroDetalles";
            this.Text = "Detalles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label st_registroid;
        private System.Windows.Forms.Label st_numempl;
        private System.Windows.Forms.Label st_actividad;
        private System.Windows.Forms.Label st_desc;
    }
}