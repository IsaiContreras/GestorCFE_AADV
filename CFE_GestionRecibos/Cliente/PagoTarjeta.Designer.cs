namespace CFE_GestionRecibos.Cliente
{
    partial class PagoTarjeta
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_cantidad = new System.Windows.Forms.TextBox();
            this.tbx_numtarj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_mes = new System.Windows.Forms.TextBox();
            this.tbx_año = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_cvv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_tarjetas = new System.Windows.Forms.ComboBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DimGray;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(319, 254);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(143, 36);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_pagar
            // 
            this.btn_pagar.BackColor = System.Drawing.Color.DimGray;
            this.btn_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_pagar.Location = new System.Drawing.Point(103, 254);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(210, 36);
            this.btn_pagar.TabIndex = 9;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = false;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(326, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "MXN $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(100, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad: ";
            // 
            // tbx_cantidad
            // 
            this.tbx_cantidad.BackColor = System.Drawing.Color.DimGray;
            this.tbx_cantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_cantidad.Location = new System.Drawing.Point(101, 212);
            this.tbx_cantidad.MaxLength = 30;
            this.tbx_cantidad.Name = "tbx_cantidad";
            this.tbx_cantidad.Size = new System.Drawing.Size(219, 22);
            this.tbx_cantidad.TabIndex = 6;
            // 
            // tbx_numtarj
            // 
            this.tbx_numtarj.BackColor = System.Drawing.Color.DimGray;
            this.tbx_numtarj.Location = new System.Drawing.Point(97, 83);
            this.tbx_numtarj.MaxLength = 16;
            this.tbx_numtarj.Name = "tbx_numtarj";
            this.tbx_numtarj.Size = new System.Drawing.Size(276, 22);
            this.tbx_numtarj.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(100, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número de tarjeta - Sin guiones";
            // 
            // tbx_mes
            // 
            this.tbx_mes.BackColor = System.Drawing.Color.DimGray;
            this.tbx_mes.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_mes.Location = new System.Drawing.Point(97, 128);
            this.tbx_mes.MaxLength = 2;
            this.tbx_mes.Name = "tbx_mes";
            this.tbx_mes.Size = new System.Drawing.Size(58, 22);
            this.tbx_mes.TabIndex = 3;
            // 
            // tbx_año
            // 
            this.tbx_año.BackColor = System.Drawing.Color.DimGray;
            this.tbx_año.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_año.Location = new System.Drawing.Point(164, 128);
            this.tbx_año.MaxLength = 2;
            this.tbx_año.Name = "tbx_año";
            this.tbx_año.Size = new System.Drawing.Size(58, 22);
            this.tbx_año.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(100, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vigencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(94, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(161, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Año";
            // 
            // tbx_cvv
            // 
            this.tbx_cvv.BackColor = System.Drawing.Color.DimGray;
            this.tbx_cvv.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_cvv.Location = new System.Drawing.Point(249, 128);
            this.tbx_cvv.MaxLength = 3;
            this.tbx_cvv.Name = "tbx_cvv";
            this.tbx_cvv.Size = new System.Drawing.Size(67, 22);
            this.tbx_cvv.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(249, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "CVV*";
            // 
            // cbx_tarjetas
            // 
            this.cbx_tarjetas.BackColor = System.Drawing.Color.DimGray;
            this.cbx_tarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tarjetas.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_tarjetas.FormattingEnabled = true;
            this.cbx_tarjetas.Location = new System.Drawing.Point(50, 12);
            this.cbx_tarjetas.Name = "cbx_tarjetas";
            this.cbx_tarjetas.Size = new System.Drawing.Size(298, 24);
            this.cbx_tarjetas.TabIndex = 1;
            this.cbx_tarjetas.SelectedIndexChanged += new System.EventHandler(this.cbx_tarjetas_SelectedIndexChanged);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.DimGray;
            this.btn_del.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_del.Location = new System.Drawing.Point(391, 12);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(30, 30);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "-";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DimGray;
            this.btn_add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add.Location = new System.Drawing.Point(354, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(30, 30);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // PagoTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(474, 302);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cbx_tarjetas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_cvv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_año);
            this.Controls.Add(this.tbx_mes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_numtarj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_cantidad);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_pagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(492, 349);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(492, 349);
            this.Name = "PagoTarjeta";
            this.Text = "Pago con tarjeta";
            this.Load += new System.EventHandler(this.PagoTarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_cantidad;
        private System.Windows.Forms.TextBox tbx_numtarj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_mes;
        private System.Windows.Forms.TextBox tbx_año;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_cvv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_tarjetas;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
    }
}