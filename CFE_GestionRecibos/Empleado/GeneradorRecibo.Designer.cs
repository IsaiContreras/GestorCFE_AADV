namespace CFE_GestionRecibos.Empleado
{
    partial class GeneradorRecibo
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
            this.tbx_año = new System.Windows.Forms.TextBox();
            this.cbx_mes = new System.Windows.Forms.ComboBox();
            this.cbx_tiposerv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_año
            // 
            this.tbx_año.BackColor = System.Drawing.Color.DimGray;
            this.tbx_año.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_año.Location = new System.Drawing.Point(12, 33);
            this.tbx_año.MaxLength = 5;
            this.tbx_año.Name = "tbx_año";
            this.tbx_año.Size = new System.Drawing.Size(104, 22);
            this.tbx_año.TabIndex = 1;
            // 
            // cbx_mes
            // 
            this.cbx_mes.BackColor = System.Drawing.Color.DimGray;
            this.cbx_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mes.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_mes.FormattingEnabled = true;
            this.cbx_mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbx_mes.Location = new System.Drawing.Point(122, 33);
            this.cbx_mes.Name = "cbx_mes";
            this.cbx_mes.Size = new System.Drawing.Size(114, 24);
            this.cbx_mes.TabIndex = 2;
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
            this.cbx_tiposerv.Location = new System.Drawing.Point(12, 117);
            this.cbx_tiposerv.Name = "cbx_tiposerv";
            this.cbx_tiposerv.Size = new System.Drawing.Size(224, 24);
            this.cbx_tiposerv.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodo de facturación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(122, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de servicio";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DimGray;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(299, 171);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(116, 32);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DimGray;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ok.Location = new System.Drawing.Point(177, 171);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(116, 32);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "Aceptar";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // GeneradorRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(427, 215);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_tiposerv);
            this.Controls.Add(this.cbx_mes);
            this.Controls.Add(this.tbx_año);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 262);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(445, 262);
            this.Name = "GeneradorRecibo";
            this.Text = "Generar recibo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_año;
        private System.Windows.Forms.ComboBox cbx_mes;
        private System.Windows.Forms.ComboBox cbx_tiposerv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
    }
}