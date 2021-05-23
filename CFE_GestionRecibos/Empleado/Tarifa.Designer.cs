namespace CFE_GestionRecibos.Empleado
{
    partial class Tarifa
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_tiposerv = new System.Windows.Forms.ComboBox();
            this.cbx_mes = new System.Windows.Forms.ComboBox();
            this.tbx_año = new System.Windows.Forms.TextBox();
            this.tbx_tarbas = new System.Windows.Forms.TextBox();
            this.tbx_tarint = new System.Windows.Forms.TextBox();
            this.tbx_tarexc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_archivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(122, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodo de facturación";
            // 
            // cbx_tiposerv
            // 
            this.cbx_tiposerv.BackColor = System.Drawing.Color.DimGray;
            this.cbx_tiposerv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tiposerv.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_tiposerv.FormattingEnabled = true;
            this.cbx_tiposerv.Items.AddRange(new object[] {
            "Doméstico",
            "Industrial"});
            this.cbx_tiposerv.Location = new System.Drawing.Point(12, 113);
            this.cbx_tiposerv.Name = "cbx_tiposerv";
            this.cbx_tiposerv.Size = new System.Drawing.Size(224, 24);
            this.cbx_tiposerv.TabIndex = 3;
            // 
            // cbx_mes
            // 
            this.cbx_mes.BackColor = System.Drawing.Color.DimGray;
            this.cbx_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mes.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_mes.FormattingEnabled = true;
            this.cbx_mes.Items.AddRange(new object[] {
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
            this.cbx_mes.Location = new System.Drawing.Point(122, 29);
            this.cbx_mes.Name = "cbx_mes";
            this.cbx_mes.Size = new System.Drawing.Size(114, 24);
            this.cbx_mes.TabIndex = 2;
            // 
            // tbx_año
            // 
            this.tbx_año.BackColor = System.Drawing.Color.DimGray;
            this.tbx_año.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_año.Location = new System.Drawing.Point(12, 29);
            this.tbx_año.MaxLength = 5;
            this.tbx_año.Name = "tbx_año";
            this.tbx_año.Size = new System.Drawing.Size(104, 22);
            this.tbx_año.TabIndex = 1;
            // 
            // tbx_tarbas
            // 
            this.tbx_tarbas.BackColor = System.Drawing.Color.DimGray;
            this.tbx_tarbas.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_tarbas.Location = new System.Drawing.Point(12, 179);
            this.tbx_tarbas.MaxLength = 6;
            this.tbx_tarbas.Name = "tbx_tarbas";
            this.tbx_tarbas.Size = new System.Drawing.Size(108, 22);
            this.tbx_tarbas.TabIndex = 4;
            // 
            // tbx_tarint
            // 
            this.tbx_tarint.BackColor = System.Drawing.Color.DimGray;
            this.tbx_tarint.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_tarint.Location = new System.Drawing.Point(12, 224);
            this.tbx_tarint.MaxLength = 6;
            this.tbx_tarint.Name = "tbx_tarint";
            this.tbx_tarint.Size = new System.Drawing.Size(108, 22);
            this.tbx_tarint.TabIndex = 5;
            // 
            // tbx_tarexc
            // 
            this.tbx_tarexc.BackColor = System.Drawing.Color.DimGray;
            this.tbx_tarexc.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_tarexc.Location = new System.Drawing.Point(12, 272);
            this.tbx_tarexc.MaxLength = 6;
            this.tbx_tarexc.Name = "tbx_tarexc";
            this.tbx_tarexc.Size = new System.Drawing.Size(108, 22);
            this.tbx_tarexc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tarifa básica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tarifa intermedia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(12, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tarífa excedente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(126, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(126, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(126, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "$";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DimGray;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(162, 385);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(86, 26);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Salir";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DimGray;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ok.Location = new System.Drawing.Point(70, 385);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(86, 26);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "Agregar";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_archivo
            // 
            this.btn_archivo.BackColor = System.Drawing.Color.DimGray;
            this.btn_archivo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_archivo.Location = new System.Drawing.Point(107, 327);
            this.btn_archivo.Name = "btn_archivo";
            this.btn_archivo.Size = new System.Drawing.Size(141, 26);
            this.btn_archivo.TabIndex = 9;
            this.btn_archivo.Text = "Desde archivo";
            this.btn_archivo.UseVisualStyleBackColor = false;
            this.btn_archivo.Click += new System.EventHandler(this.btn_archivo_Click);
            // 
            // Tarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(255, 423);
            this.Controls.Add(this.btn_archivo);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_tarexc);
            this.Controls.Add(this.tbx_tarint);
            this.Controls.Add(this.tbx_tarbas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_tiposerv);
            this.Controls.Add(this.cbx_mes);
            this.Controls.Add(this.tbx_año);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(273, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(273, 470);
            this.Name = "Tarifa";
            this.Text = "Cargar tarifa";
            this.Load += new System.EventHandler(this.Tarifa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_tiposerv;
        private System.Windows.Forms.ComboBox cbx_mes;
        private System.Windows.Forms.TextBox tbx_año;
        private System.Windows.Forms.TextBox tbx_tarbas;
        private System.Windows.Forms.TextBox tbx_tarint;
        private System.Windows.Forms.TextBox tbx_tarexc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_archivo;
    }
}