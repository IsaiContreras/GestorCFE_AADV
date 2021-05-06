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
            this.btn_ok.TabIndex = 5;
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
            this.dgv_reporte.TabIndex = 4;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.DimGray;
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_buscar.Location = new System.Drawing.Point(398, 10);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(141, 43);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // tbx_año
            // 
            this.tbx_año.BackColor = System.Drawing.Color.DimGray;
            this.tbx_año.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_año.Location = new System.Drawing.Point(12, 12);
            this.tbx_año.MaxLength = 10;
            this.tbx_año.Name = "tbx_año";
            this.tbx_año.Size = new System.Drawing.Size(231, 22);
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
            this.comboBox1.Location = new System.Drawing.Point(249, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(246, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mes";
            // 
            // ReporteGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(551, 385);
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
    }
}