namespace CFE_GestionRecibos.Cliente
{
    partial class Recibos
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
            this.st_medidor = new System.Windows.Forms.Label();
            this.st_tiposerv = new System.Windows.Forms.Label();
            this.st_domicilio = new System.Windows.Forms.Label();
            this.st_periodo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.st_prebas = new System.Windows.Forms.Label();
            this.st_preint = new System.Windows.Forms.Label();
            this.st_preexc = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.st_pabas = new System.Windows.Forms.Label();
            this.st_paint = new System.Windows.Forms.Label();
            this.st_paexc = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.st_paiva = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.st_patot = new System.Windows.Forms.Label();
            this.rdb_efectivo = new System.Windows.Forms.RadioButton();
            this.rdb_transfer = new System.Windows.Forms.RadioButton();
            this.rdb_tarjeta = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.st_papend = new System.Windows.Forms.Label();
            this.st_consbas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.st_consint = new System.Windows.Forms.Label();
            this.st_consexced = new System.Windows.Forms.Label();
            this.st_pretot = new System.Windows.Forms.Label();
            this.st_constot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // st_username
            // 
            this.st_username.AutoSize = true;
            this.st_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_username.ForeColor = System.Drawing.SystemColors.Control;
            this.st_username.Location = new System.Drawing.Point(13, 9);
            this.st_username.Name = "st_username";
            this.st_username.Size = new System.Drawing.Size(150, 25);
            this.st_username.TabIndex = 0;
            this.st_username.Text = "Nombre usuario";
            // 
            // st_identity
            // 
            this.st_identity.AutoSize = true;
            this.st_identity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_identity.ForeColor = System.Drawing.SystemColors.Control;
            this.st_identity.Location = new System.Drawing.Point(14, 38);
            this.st_identity.Name = "st_identity";
            this.st_identity.Size = new System.Drawing.Size(26, 20);
            this.st_identity.TabIndex = 0;
            this.st_identity.Text = "ID";
            // 
            // st_medidor
            // 
            this.st_medidor.AutoSize = true;
            this.st_medidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_medidor.ForeColor = System.Drawing.SystemColors.Control;
            this.st_medidor.Location = new System.Drawing.Point(14, 70);
            this.st_medidor.Name = "st_medidor";
            this.st_medidor.Size = new System.Drawing.Size(83, 25);
            this.st_medidor.TabIndex = 0;
            this.st_medidor.Text = "Medidor";
            // 
            // st_tiposerv
            // 
            this.st_tiposerv.AutoSize = true;
            this.st_tiposerv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_tiposerv.ForeColor = System.Drawing.SystemColors.Control;
            this.st_tiposerv.Location = new System.Drawing.Point(14, 105);
            this.st_tiposerv.Name = "st_tiposerv";
            this.st_tiposerv.Size = new System.Drawing.Size(104, 20);
            this.st_tiposerv.TabIndex = 0;
            this.st_tiposerv.Text = "Tipo servicio";
            // 
            // st_domicilio
            // 
            this.st_domicilio.AutoSize = true;
            this.st_domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_domicilio.ForeColor = System.Drawing.SystemColors.Control;
            this.st_domicilio.Location = new System.Drawing.Point(14, 134);
            this.st_domicilio.Name = "st_domicilio";
            this.st_domicilio.Size = new System.Drawing.Size(79, 20);
            this.st_domicilio.TabIndex = 0;
            this.st_domicilio.Text = "Domicilio";
            // 
            // st_periodo
            // 
            this.st_periodo.AutoSize = true;
            this.st_periodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_periodo.ForeColor = System.Drawing.SystemColors.Control;
            this.st_periodo.Location = new System.Drawing.Point(13, 167);
            this.st_periodo.Name = "st_periodo";
            this.st_periodo.Size = new System.Drawing.Size(79, 25);
            this.st_periodo.TabIndex = 5;
            this.st_periodo.Text = "Periodo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(230, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Consumo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(14, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Básico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(14, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Intermedio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(14, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Excedente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(417, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Precio";
            // 
            // st_prebas
            // 
            this.st_prebas.AutoSize = true;
            this.st_prebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_prebas.ForeColor = System.Drawing.SystemColors.Control;
            this.st_prebas.Location = new System.Drawing.Point(418, 240);
            this.st_prebas.Name = "st_prebas";
            this.st_prebas.Size = new System.Drawing.Size(56, 20);
            this.st_prebas.TabIndex = 0;
            this.st_prebas.Text = "P_bas";
            // 
            // st_preint
            // 
            this.st_preint.AutoSize = true;
            this.st_preint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_preint.ForeColor = System.Drawing.SystemColors.Control;
            this.st_preint.Location = new System.Drawing.Point(418, 260);
            this.st_preint.Name = "st_preint";
            this.st_preint.Size = new System.Drawing.Size(47, 20);
            this.st_preint.TabIndex = 0;
            this.st_preint.Text = "P_int";
            // 
            // st_preexc
            // 
            this.st_preexc.AutoSize = true;
            this.st_preexc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_preexc.ForeColor = System.Drawing.SystemColors.Control;
            this.st_preexc.Location = new System.Drawing.Point(418, 280);
            this.st_preexc.Name = "st_preexc";
            this.st_preexc.Size = new System.Drawing.Size(55, 20);
            this.st_preexc.TabIndex = 0;
            this.st_preexc.Text = "P_exc";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(585, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Pago";
            // 
            // st_pabas
            // 
            this.st_pabas.AutoSize = true;
            this.st_pabas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_pabas.ForeColor = System.Drawing.SystemColors.Control;
            this.st_pabas.Location = new System.Drawing.Point(586, 240);
            this.st_pabas.Name = "st_pabas";
            this.st_pabas.Size = new System.Drawing.Size(65, 20);
            this.st_pabas.TabIndex = 0;
            this.st_pabas.Text = "Pa_bas";
            // 
            // st_paint
            // 
            this.st_paint.AutoSize = true;
            this.st_paint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_paint.ForeColor = System.Drawing.SystemColors.Control;
            this.st_paint.Location = new System.Drawing.Point(586, 260);
            this.st_paint.Name = "st_paint";
            this.st_paint.Size = new System.Drawing.Size(56, 20);
            this.st_paint.TabIndex = 0;
            this.st_paint.Text = "Pa_int";
            // 
            // st_paexc
            // 
            this.st_paexc.AutoSize = true;
            this.st_paexc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_paexc.ForeColor = System.Drawing.SystemColors.Control;
            this.st_paexc.Location = new System.Drawing.Point(586, 280);
            this.st_paexc.Name = "st_paexc";
            this.st_paexc.Size = new System.Drawing.Size(64, 20);
            this.st_paexc.TabIndex = 0;
            this.st_paexc.Text = "Pa_exc";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(13, 339);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "Pago IVA";
            // 
            // st_paiva
            // 
            this.st_paiva.AutoSize = true;
            this.st_paiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_paiva.ForeColor = System.Drawing.SystemColors.Control;
            this.st_paiva.Location = new System.Drawing.Point(586, 343);
            this.st_paiva.Name = "st_paiva";
            this.st_paiva.Size = new System.Drawing.Size(59, 20);
            this.st_paiva.TabIndex = 0;
            this.st_paiva.Text = "Pa_iva";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(13, 389);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 25);
            this.label20.TabIndex = 0;
            this.label20.Text = "Pago total";
            // 
            // st_patot
            // 
            this.st_patot.AutoSize = true;
            this.st_patot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_patot.ForeColor = System.Drawing.SystemColors.Control;
            this.st_patot.Location = new System.Drawing.Point(585, 389);
            this.st_patot.Name = "st_patot";
            this.st_patot.Size = new System.Drawing.Size(68, 25);
            this.st_patot.TabIndex = 0;
            this.st_patot.Text = "Pa_tot";
            // 
            // rdb_efectivo
            // 
            this.rdb_efectivo.AutoSize = true;
            this.rdb_efectivo.ForeColor = System.Drawing.SystemColors.Control;
            this.rdb_efectivo.Location = new System.Drawing.Point(18, 462);
            this.rdb_efectivo.Name = "rdb_efectivo";
            this.rdb_efectivo.Size = new System.Drawing.Size(79, 21);
            this.rdb_efectivo.TabIndex = 1;
            this.rdb_efectivo.TabStop = true;
            this.rdb_efectivo.Text = "Efectivo";
            this.rdb_efectivo.UseVisualStyleBackColor = true;
            // 
            // rdb_transfer
            // 
            this.rdb_transfer.AutoSize = true;
            this.rdb_transfer.ForeColor = System.Drawing.SystemColors.Control;
            this.rdb_transfer.Location = new System.Drawing.Point(18, 489);
            this.rdb_transfer.Name = "rdb_transfer";
            this.rdb_transfer.Size = new System.Drawing.Size(117, 21);
            this.rdb_transfer.TabIndex = 2;
            this.rdb_transfer.TabStop = true;
            this.rdb_transfer.Text = "Transferencia";
            this.rdb_transfer.UseVisualStyleBackColor = true;
            // 
            // rdb_tarjeta
            // 
            this.rdb_tarjeta.AutoSize = true;
            this.rdb_tarjeta.ForeColor = System.Drawing.SystemColors.Control;
            this.rdb_tarjeta.Location = new System.Drawing.Point(18, 516);
            this.rdb_tarjeta.Name = "rdb_tarjeta";
            this.rdb_tarjeta.Size = new System.Drawing.Size(74, 21);
            this.rdb_tarjeta.TabIndex = 3;
            this.rdb_tarjeta.TabStop = true;
            this.rdb_tarjeta.Text = "Tarjeta";
            this.rdb_tarjeta.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Control;
            this.label22.Location = new System.Drawing.Point(14, 439);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 20);
            this.label22.TabIndex = 0;
            this.label22.Text = "Forma de pago";
            // 
            // btn_pagar
            // 
            this.btn_pagar.BackColor = System.Drawing.Color.DimGray;
            this.btn_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_pagar.Location = new System.Drawing.Point(465, 440);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(249, 58);
            this.btn_pagar.TabIndex = 4;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = false;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DimGray;
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Location = new System.Drawing.Point(465, 501);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(249, 36);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.Control;
            this.label23.Location = new System.Drawing.Point(13, 364);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(149, 25);
            this.label23.TabIndex = 0;
            this.label23.Text = "Pago pendiente";
            // 
            // st_papend
            // 
            this.st_papend.AutoSize = true;
            this.st_papend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_papend.ForeColor = System.Drawing.SystemColors.Control;
            this.st_papend.Location = new System.Drawing.Point(586, 368);
            this.st_papend.Name = "st_papend";
            this.st_papend.Size = new System.Drawing.Size(74, 20);
            this.st_papend.TabIndex = 0;
            this.st_papend.Text = "Pa_pend";
            // 
            // st_consbas
            // 
            this.st_consbas.AutoSize = true;
            this.st_consbas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_consbas.ForeColor = System.Drawing.SystemColors.Control;
            this.st_consbas.Location = new System.Drawing.Point(231, 240);
            this.st_consbas.Name = "st_consbas";
            this.st_consbas.Size = new System.Drawing.Size(57, 20);
            this.st_consbas.TabIndex = 6;
            this.st_consbas.Text = "C_bas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total";
            // 
            // st_consint
            // 
            this.st_consint.AutoSize = true;
            this.st_consint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_consint.ForeColor = System.Drawing.SystemColors.Control;
            this.st_consint.Location = new System.Drawing.Point(231, 260);
            this.st_consint.Name = "st_consint";
            this.st_consint.Size = new System.Drawing.Size(48, 20);
            this.st_consint.TabIndex = 8;
            this.st_consint.Text = "C_int";
            // 
            // st_consexced
            // 
            this.st_consexced.AutoSize = true;
            this.st_consexced.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_consexced.ForeColor = System.Drawing.SystemColors.Control;
            this.st_consexced.Location = new System.Drawing.Point(231, 280);
            this.st_consexced.Name = "st_consexced";
            this.st_consexced.Size = new System.Drawing.Size(74, 20);
            this.st_consexced.TabIndex = 9;
            this.st_consexced.Text = "C_exced";
            // 
            // st_pretot
            // 
            this.st_pretot.AutoSize = true;
            this.st_pretot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_pretot.ForeColor = System.Drawing.SystemColors.Control;
            this.st_pretot.Location = new System.Drawing.Point(586, 309);
            this.st_pretot.Name = "st_pretot";
            this.st_pretot.Size = new System.Drawing.Size(48, 20);
            this.st_pretot.TabIndex = 10;
            this.st_pretot.Text = "P_tot";
            // 
            // st_constot
            // 
            this.st_constot.AutoSize = true;
            this.st_constot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_constot.ForeColor = System.Drawing.SystemColors.Control;
            this.st_constot.Location = new System.Drawing.Point(231, 309);
            this.st_constot.Name = "st_constot";
            this.st_constot.Size = new System.Drawing.Size(49, 20);
            this.st_constot.TabIndex = 11;
            this.st_constot.Text = "C_tot";
            // 
            // Recibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(726, 548);
            this.Controls.Add(this.st_constot);
            this.Controls.Add(this.st_pretot);
            this.Controls.Add(this.st_consexced);
            this.Controls.Add(this.st_consint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.st_consbas);
            this.Controls.Add(this.st_papend);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.rdb_tarjeta);
            this.Controls.Add(this.rdb_transfer);
            this.Controls.Add(this.rdb_efectivo);
            this.Controls.Add(this.st_patot);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.st_paiva);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.st_paexc);
            this.Controls.Add(this.st_paint);
            this.Controls.Add(this.st_pabas);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.st_preexc);
            this.Controls.Add(this.st_preint);
            this.Controls.Add(this.st_prebas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.st_periodo);
            this.Controls.Add(this.st_domicilio);
            this.Controls.Add(this.st_tiposerv);
            this.Controls.Add(this.st_medidor);
            this.Controls.Add(this.st_identity);
            this.Controls.Add(this.st_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 595);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(744, 595);
            this.Name = "Recibos";
            this.Text = "Recibo";
            this.Load += new System.EventHandler(this.Recibos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label st_username;
        private System.Windows.Forms.Label st_identity;
        private System.Windows.Forms.Label st_medidor;
        private System.Windows.Forms.Label st_tiposerv;
        private System.Windows.Forms.Label st_domicilio;
        private System.Windows.Forms.Label st_periodo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label st_prebas;
        private System.Windows.Forms.Label st_preint;
        private System.Windows.Forms.Label st_preexc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label st_pabas;
        private System.Windows.Forms.Label st_paint;
        private System.Windows.Forms.Label st_paexc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label st_paiva;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label st_patot;
        private System.Windows.Forms.RadioButton rdb_efectivo;
        private System.Windows.Forms.RadioButton rdb_transfer;
        private System.Windows.Forms.RadioButton rdb_tarjeta;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label st_papend;
        private System.Windows.Forms.Label st_consbas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label st_consint;
        private System.Windows.Forms.Label st_consexced;
        private System.Windows.Forms.Label st_pretot;
        private System.Windows.Forms.Label st_constot;
    }
}