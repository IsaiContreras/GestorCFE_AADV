namespace CFE_GestionRecibos.Cliente
{
    partial class PagoTransf
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
            this.tbx_numcuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_cuentas = new System.Windows.Forms.ComboBox();
            this.cbx_entidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DimGray;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(319, 204);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(143, 36);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_pagar
            // 
            this.btn_pagar.BackColor = System.Drawing.Color.DimGray;
            this.btn_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_pagar.Location = new System.Drawing.Point(103, 204);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(210, 36);
            this.btn_pagar.TabIndex = 7;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = false;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(326, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "MXN $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(100, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad: ";
            // 
            // tbx_cantidad
            // 
            this.tbx_cantidad.BackColor = System.Drawing.Color.DimGray;
            this.tbx_cantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_cantidad.Location = new System.Drawing.Point(100, 168);
            this.tbx_cantidad.MaxLength = 30;
            this.tbx_cantidad.Name = "tbx_cantidad";
            this.tbx_cantidad.Size = new System.Drawing.Size(219, 22);
            this.tbx_cantidad.TabIndex = 4;
            // 
            // tbx_numcuenta
            // 
            this.tbx_numcuenta.BackColor = System.Drawing.Color.DimGray;
            this.tbx_numcuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_numcuenta.Location = new System.Drawing.Point(100, 72);
            this.tbx_numcuenta.MaxLength = 18;
            this.tbx_numcuenta.Name = "tbx_numcuenta";
            this.tbx_numcuenta.Size = new System.Drawing.Size(276, 22);
            this.tbx_numcuenta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(100, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número de cuenta";
            // 
            // cbx_cuentas
            // 
            this.cbx_cuentas.BackColor = System.Drawing.Color.DimGray;
            this.cbx_cuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_cuentas.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_cuentas.FormattingEnabled = true;
            this.cbx_cuentas.Location = new System.Drawing.Point(100, 25);
            this.cbx_cuentas.Name = "cbx_cuentas";
            this.cbx_cuentas.Size = new System.Drawing.Size(233, 24);
            this.cbx_cuentas.TabIndex = 1;
            // 
            // cbx_entidad
            // 
            this.cbx_entidad.BackColor = System.Drawing.Color.DimGray;
            this.cbx_entidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_entidad.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_entidad.FormattingEnabled = true;
            this.cbx_entidad.Items.AddRange(new object[] {
            "Banorte",
            "Afirme",
            "Santander",
            "Bancomer",
            "Banregio",
            "HSBC",
            "Banamex",
            "BBVA",
            "STP"});
            this.cbx_entidad.Location = new System.Drawing.Point(100, 118);
            this.cbx_entidad.Name = "cbx_entidad";
            this.cbx_entidad.Size = new System.Drawing.Size(121, 24);
            this.cbx_entidad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(100, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cuentas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(100, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Entidad Bancaria";
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.DimGray;
            this.btn_del.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_del.Location = new System.Drawing.Point(376, 25);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(30, 30);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "-";
            this.btn_del.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DimGray;
            this.btn_add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add.Location = new System.Drawing.Point(339, 25);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(30, 30);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // PagoTransf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(474, 252);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_entidad);
            this.Controls.Add(this.cbx_cuentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_numcuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_cantidad);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_pagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(492, 299);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(492, 299);
            this.Name = "PagoTransf";
            this.Text = "Pago por transferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_cantidad;
        private System.Windows.Forms.TextBox tbx_numcuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_cuentas;
        private System.Windows.Forms.ComboBox cbx_entidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
    }
}