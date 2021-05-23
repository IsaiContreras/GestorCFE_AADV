namespace CFE_GestionRecibos.Administrador
{
    partial class Administrador
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
            this.st_username = new System.Windows.Forms.Label();
            this.st_identity = new System.Windows.Forms.Label();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.btn_agremp = new System.Windows.Forms.Button();
            this.btn_edtemp = new System.Windows.Forms.Button();
            this.btn_elimemp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_regact = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_desbloq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // st_username
            // 
            this.st_username.AutoSize = true;
            this.st_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_username.ForeColor = System.Drawing.SystemColors.Control;
            this.st_username.Location = new System.Drawing.Point(12, 9);
            this.st_username.Name = "st_username";
            this.st_username.Size = new System.Drawing.Size(150, 25);
            this.st_username.TabIndex = 0;
            this.st_username.Text = "Nombre usuario";
            // 
            // st_identity
            // 
            this.st_identity.AutoSize = true;
            this.st_identity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_identity.ForeColor = System.Drawing.SystemColors.Control;
            this.st_identity.Location = new System.Drawing.Point(12, 34);
            this.st_identity.Name = "st_identity";
            this.st_identity.Size = new System.Drawing.Size(31, 25);
            this.st_identity.TabIndex = 0;
            this.st_identity.Text = "ID";
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.AllowUserToAddRows = false;
            this.dgv_empleados.AllowUserToDeleteRows = false;
            this.dgv_empleados.AllowUserToResizeColumns = false;
            this.dgv_empleados.AllowUserToResizeRows = false;
            this.dgv_empleados.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Location = new System.Drawing.Point(12, 178);
            this.dgv_empleados.MultiSelect = false;
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.ReadOnly = true;
            this.dgv_empleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_empleados.RowTemplate.Height = 24;
            this.dgv_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_empleados.Size = new System.Drawing.Size(776, 313);
            this.dgv_empleados.TabIndex = 4;
            // 
            // btn_agremp
            // 
            this.btn_agremp.BackColor = System.Drawing.Color.DimGray;
            this.btn_agremp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agremp.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_agremp.Location = new System.Drawing.Point(626, 55);
            this.btn_agremp.Name = "btn_agremp";
            this.btn_agremp.Size = new System.Drawing.Size(162, 35);
            this.btn_agremp.TabIndex = 1;
            this.btn_agremp.Text = "Agregar";
            this.btn_agremp.UseVisualStyleBackColor = false;
            this.btn_agremp.Click += new System.EventHandler(this.btn_agremp_Click);
            // 
            // btn_edtemp
            // 
            this.btn_edtemp.BackColor = System.Drawing.Color.DimGray;
            this.btn_edtemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edtemp.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_edtemp.Location = new System.Drawing.Point(626, 96);
            this.btn_edtemp.Name = "btn_edtemp";
            this.btn_edtemp.Size = new System.Drawing.Size(162, 35);
            this.btn_edtemp.TabIndex = 2;
            this.btn_edtemp.Text = "Editar";
            this.btn_edtemp.UseVisualStyleBackColor = false;
            this.btn_edtemp.Click += new System.EventHandler(this.btn_edtemp_Click);
            // 
            // btn_elimemp
            // 
            this.btn_elimemp.BackColor = System.Drawing.Color.DimGray;
            this.btn_elimemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elimemp.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_elimemp.Location = new System.Drawing.Point(626, 137);
            this.btn_elimemp.Name = "btn_elimemp";
            this.btn_elimemp.Size = new System.Drawing.Size(162, 35);
            this.btn_elimemp.TabIndex = 3;
            this.btn_elimemp.Text = "Eliminar";
            this.btn_elimemp.UseVisualStyleBackColor = false;
            this.btn_elimemp.Click += new System.EventHandler(this.btn_elimemp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(610, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Empleados";
            // 
            // btn_regact
            // 
            this.btn_regact.BackColor = System.Drawing.Color.DimGray;
            this.btn_regact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regact.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_regact.Location = new System.Drawing.Point(204, 137);
            this.btn_regact.Name = "btn_regact";
            this.btn_regact.Size = new System.Drawing.Size(173, 35);
            this.btn_regact.TabIndex = 5;
            this.btn_regact.Text = "Registro de actividad";
            this.btn_regact.UseVisualStyleBackColor = false;
            this.btn_regact.Click += new System.EventHandler(this.btn_regact_Click);
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.DimGray;
            this.btn_info.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_info.Location = new System.Drawing.Point(12, 137);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(186, 35);
            this.btn_info.TabIndex = 6;
            this.btn_info.Text = "Información de empleado";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_desbloq
            // 
            this.btn_desbloq.BackColor = System.Drawing.Color.DimGray;
            this.btn_desbloq.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_desbloq.Location = new System.Drawing.Point(384, 137);
            this.btn_desbloq.Name = "btn_desbloq";
            this.btn_desbloq.Size = new System.Drawing.Size(187, 35);
            this.btn_desbloq.TabIndex = 7;
            this.btn_desbloq.Text = "Usuarios bloqueados";
            this.btn_desbloq.UseVisualStyleBackColor = false;
            this.btn_desbloq.Click += new System.EventHandler(this.btn_desbloq_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.btn_desbloq);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_regact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_elimemp);
            this.Controls.Add(this.btn_edtemp);
            this.Controls.Add(this.btn_agremp);
            this.Controls.Add(this.dgv_empleados);
            this.Controls.Add(this.st_identity);
            this.Controls.Add(this.st_username);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 550);
            this.MinimumSize = new System.Drawing.Size(818, 550);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label st_username;
        private System.Windows.Forms.Label st_identity;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.Button btn_agremp;
        private System.Windows.Forms.Button btn_edtemp;
        private System.Windows.Forms.Button btn_elimemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_regact;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_desbloq;
    }
}