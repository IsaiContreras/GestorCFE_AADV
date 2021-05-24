namespace CFE_GestionRecibos.Administrador
{
    partial class Registro
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
            this.dgv_registro = new System.Windows.Forms.DataGridView();
            this.btn_detalles = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_registro
            // 
            this.dgv_registro.AllowUserToAddRows = false;
            this.dgv_registro.AllowUserToDeleteRows = false;
            this.dgv_registro.AllowUserToResizeColumns = false;
            this.dgv_registro.AllowUserToResizeRows = false;
            this.dgv_registro.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registro.Location = new System.Drawing.Point(12, 51);
            this.dgv_registro.MultiSelect = false;
            this.dgv_registro.Name = "dgv_registro";
            this.dgv_registro.ReadOnly = true;
            this.dgv_registro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_registro.RowTemplate.Height = 24;
            this.dgv_registro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_registro.Size = new System.Drawing.Size(596, 264);
            this.dgv_registro.TabIndex = 0;
            this.dgv_registro.TabStop = false;
            // 
            // btn_detalles
            // 
            this.btn_detalles.BackColor = System.Drawing.Color.DimGray;
            this.btn_detalles.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_detalles.Location = new System.Drawing.Point(509, 12);
            this.btn_detalles.Name = "btn_detalles";
            this.btn_detalles.Size = new System.Drawing.Size(99, 29);
            this.btn_detalles.TabIndex = 1;
            this.btn_detalles.Text = "Detalles";
            this.btn_detalles.UseVisualStyleBackColor = false;
            this.btn_detalles.Click += new System.EventHandler(this.btn_detalles_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DimGray;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ok.Location = new System.Drawing.Point(453, 321);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(155, 29);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "Regresar";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(621, 357);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_detalles);
            this.Controls.Add(this.dgv_registro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registro";
            this.Text = "Registro de actividad";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_registro;
        private System.Windows.Forms.Button btn_detalles;
        private System.Windows.Forms.Button btn_ok;
    }
}