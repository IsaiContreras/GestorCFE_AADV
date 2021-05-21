namespace CFE_GestionRecibos.Empleado
{
    partial class ReporteGeneral
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
            this.dgv_reporte = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.tbx_año = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_tiposerv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DimGray;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ok.Location = new System.Drawing.Point(426, 340);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(113, 31);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "Aceptar";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // dgv_reporte
            // 
            this.dgv_reporte.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reporte.Location = new System.Drawing.Point(13, 71);
            this.dgv_reporte.Name = "dgv_reporte";
            this.dgv_reporte.RowTemplate.Height = 24;
            this.dgv_reporte.Size = new System.Drawing.Size(526, 263);
            this.dgv_reporte.TabIndex = 5;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.DimGray;
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_buscar.Location = new System.Drawing.Point(398, 10);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(141, 43);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // tbx_año
            // 
            this.tbx_año.BackColor = System.Drawing.Color.DimGray;
            this.tbx_año.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_año.Location = new System.Drawing.Point(12, 29);
            this.tbx_año.MaxLength = 10;
            this.tbx_año.Name = "tbx_año";
            this.tbx_año.Size = new System.Drawing.Size(123, 22);
            this.tbx_año.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DimGray;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
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
            this.comboBox1.Location = new System.Drawing.Point(141, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mes";
            // 
            // cbx_tiposerv
            // 
            this.cbx_tiposerv.BackColor = System.Drawing.Color.DimGray;
            this.cbx_tiposerv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tiposerv.FormattingEnabled = true;
            this.cbx_tiposerv.Items.AddRange(new object[] {
            "Doméstico",
            "Industrial"});
            this.cbx_tiposerv.Location = new System.Drawing.Point(240, 27);
            this.cbx_tiposerv.Name = "cbx_tiposerv";
            this.cbx_tiposerv.Size = new System.Drawing.Size(152, 24);
            this.cbx_tiposerv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(237, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de servicio";
            // 
            // ReporteGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(551, 385);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_tiposerv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.dgv_reporte);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.tbx_año);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(569, 432);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(569, 432);
            this.Name = "ReporteGeneral";
            this.Text = "Reporte general";
            this.Load += new System.EventHandler(this.ReporteGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DataGridView dgv_reporte;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox tbx_año;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_tiposerv;
        private System.Windows.Forms.Label label3;
    }
}