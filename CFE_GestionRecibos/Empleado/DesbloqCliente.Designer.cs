namespace CFE_GestionRecibos.Empleado
{
    partial class DesbloqCliente
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
            this.dgv_bloqueados = new System.Windows.Forms.DataGridView();
            this.btn_desbloq = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bloqueados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bloqueados
            // 
            this.dgv_bloqueados.AllowUserToAddRows = false;
            this.dgv_bloqueados.AllowUserToDeleteRows = false;
            this.dgv_bloqueados.AllowUserToResizeColumns = false;
            this.dgv_bloqueados.AllowUserToResizeRows = false;
            this.dgv_bloqueados.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_bloqueados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bloqueados.Location = new System.Drawing.Point(12, 12);
            this.dgv_bloqueados.MultiSelect = false;
            this.dgv_bloqueados.Name = "dgv_bloqueados";
            this.dgv_bloqueados.ReadOnly = true;
            this.dgv_bloqueados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_bloqueados.RowTemplate.Height = 24;
            this.dgv_bloqueados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bloqueados.Size = new System.Drawing.Size(564, 203);
            this.dgv_bloqueados.TabIndex = 1;
            // 
            // btn_desbloq
            // 
            this.btn_desbloq.BackColor = System.Drawing.Color.DimGray;
            this.btn_desbloq.Enabled = false;
            this.btn_desbloq.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_desbloq.Location = new System.Drawing.Point(302, 221);
            this.btn_desbloq.Name = "btn_desbloq";
            this.btn_desbloq.Size = new System.Drawing.Size(134, 31);
            this.btn_desbloq.TabIndex = 2;
            this.btn_desbloq.Text = "Desbloquear";
            this.btn_desbloq.UseVisualStyleBackColor = false;
            this.btn_desbloq.Click += new System.EventHandler(this.btn_desbloq_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.DimGray;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_salir.Location = new System.Drawing.Point(442, 221);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(134, 31);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Regresar";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // DesbloqCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(589, 265);
            this.Controls.Add(this.dgv_bloqueados);
            this.Controls.Add(this.btn_desbloq);
            this.Controls.Add(this.btn_salir);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(607, 312);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(607, 312);
            this.Name = "DesbloqCliente";
            this.Text = "Clientes bloqueados";
            this.Load += new System.EventHandler(this.DesbloqCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bloqueados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bloqueados;
        private System.Windows.Forms.Button btn_desbloq;
        private System.Windows.Forms.Button btn_salir;
    }
}