namespace CFE_GestionRecibos.Cliente
{
    partial class Cliente
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
            this.dgv_recibos = new System.Windows.Forms.DataGridView();
            this.cbx_servicios = new System.Windows.Forms.ComboBox();
            this.btn_recibo = new System.Windows.Forms.Button();
            this.btn_descarga = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recibos)).BeginInit();
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
            // dgv_recibos
            // 
            this.dgv_recibos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_recibos.Location = new System.Drawing.Point(13, 130);
            this.dgv_recibos.Name = "dgv_recibos";
            this.dgv_recibos.RowTemplate.Height = 24;
            this.dgv_recibos.Size = new System.Drawing.Size(600, 361);
            this.dgv_recibos.TabIndex = 2;
            // 
            // cbx_servicios
            // 
            this.cbx_servicios.BackColor = System.Drawing.Color.DimGray;
            this.cbx_servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_servicios.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_servicios.FormattingEnabled = true;
            this.cbx_servicios.Location = new System.Drawing.Point(12, 100);
            this.cbx_servicios.Name = "cbx_servicios";
            this.cbx_servicios.Size = new System.Drawing.Size(601, 24);
            this.cbx_servicios.TabIndex = 1;
            // 
            // btn_recibo
            // 
            this.btn_recibo.BackColor = System.Drawing.Color.DimGray;
            this.btn_recibo.Location = new System.Drawing.Point(620, 94);
            this.btn_recibo.Name = "btn_recibo";
            this.btn_recibo.Size = new System.Drawing.Size(168, 30);
            this.btn_recibo.TabIndex = 3;
            this.btn_recibo.Text = "Ver recibo";
            this.btn_recibo.UseVisualStyleBackColor = false;
            this.btn_recibo.Click += new System.EventHandler(this.btn_recibo_Click);
            // 
            // btn_descarga
            // 
            this.btn_descarga.BackColor = System.Drawing.Color.DimGray;
            this.btn_descarga.Location = new System.Drawing.Point(619, 130);
            this.btn_descarga.Name = "btn_descarga";
            this.btn_descarga.Size = new System.Drawing.Size(168, 32);
            this.btn_descarga.TabIndex = 4;
            this.btn_descarga.Text = "Descargar";
            this.btn_descarga.UseVisualStyleBackColor = false;
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.DimGray;
            this.btn_info.Location = new System.Drawing.Point(599, 9);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(189, 25);
            this.btn_info.TabIndex = 5;
            this.btn_info.Text = "Ver información de cliente";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio:";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_descarga);
            this.Controls.Add(this.btn_recibo);
            this.Controls.Add(this.cbx_servicios);
            this.Controls.Add(this.dgv_recibos);
            this.Controls.Add(this.st_identity);
            this.Controls.Add(this.st_username);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 550);
            this.MinimumSize = new System.Drawing.Size(818, 550);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label st_username;
        private System.Windows.Forms.Label st_identity;
        private System.Windows.Forms.DataGridView dgv_recibos;
        private System.Windows.Forms.ComboBox cbx_servicios;
        private System.Windows.Forms.Button btn_recibo;
        private System.Windows.Forms.Button btn_descarga;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Label label1;
    }
}