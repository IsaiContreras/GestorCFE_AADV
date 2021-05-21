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
            this.st_fechahora = new System.Windows.Forms.Label();
            this.st_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DimGray;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ok.Location = new System.Drawing.Point(361, 307);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(209, 26);
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
            this.st_numempl.Location = new System.Drawing.Point(12, 52);
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
            this.st_actividad.Location = new System.Drawing.Point(13, 158);
            this.st_actividad.Name = "st_actividad";
            this.st_actividad.Size = new System.Drawing.Size(82, 20);
            this.st_actividad.TabIndex = 0;
            this.st_actividad.Text = "Actividad:";
            // 
            // st_fechahora
            // 
            this.st_fechahora.AutoSize = true;
            this.st_fechahora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_fechahora.ForeColor = System.Drawing.SystemColors.Control;
            this.st_fechahora.Location = new System.Drawing.Point(12, 92);
            this.st_fechahora.Name = "st_fechahora";
            this.st_fechahora.Size = new System.Drawing.Size(116, 20);
            this.st_fechahora.TabIndex = 0;
            this.st_fechahora.Text = "Fecha y hora: ";
            // 
            // st_descripcion
            // 
            this.st_descripcion.BackColor = System.Drawing.Color.DimGray;
            this.st_descripcion.ForeColor = System.Drawing.SystemColors.Control;
            this.st_descripcion.Location = new System.Drawing.Point(16, 214);
            this.st_descripcion.MaxLength = 512;
            this.st_descripcion.Multiline = true;
            this.st_descripcion.Name = "st_descripcion";
            this.st_descripcion.ReadOnly = true;
            this.st_descripcion.Size = new System.Drawing.Size(339, 119);
            this.st_descripcion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripción:";
            // 
            // RegistroDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(582, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.st_descripcion);
            this.Controls.Add(this.st_fechahora);
            this.Controls.Add(this.st_actividad);
            this.Controls.Add(this.st_numempl);
            this.Controls.Add(this.st_registroid);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 392);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 392);
            this.Name = "RegistroDetalles";
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.RegistroDetalles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label st_registroid;
        private System.Windows.Forms.Label st_numempl;
        private System.Windows.Forms.Label st_actividad;
        private System.Windows.Forms.Label st_fechahora;
        private System.Windows.Forms.TextBox st_descripcion;
        private System.Windows.Forms.Label label1;
    }
}