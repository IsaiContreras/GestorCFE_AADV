namespace CFE_GestionRecibos.Empleado
{
    partial class Empleado
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
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.dgv_servicios = new System.Windows.Forms.DataGridView();
            this.tbx_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_agrclient = new System.Windows.Forms.Button();
            this.btn_modclient = new System.Windows.Forms.Button();
            this.btn_elimclient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.st_agrserv = new System.Windows.Forms.Button();
            this.btn_modserv = new System.Windows.Forms.Button();
            this.st_elimserv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_infoempl = new System.Windows.Forms.Button();
            this.btn_regtaf = new System.Windows.Forms.Button();
            this.btn_regcons = new System.Windows.Forms.Button();
            this.btn_reptaf = new System.Windows.Forms.Button();
            this.btn_repcons = new System.Windows.Forms.Button();
            this.btn_conshist = new System.Windows.Forms.Button();
            this.btn_repgen = new System.Windows.Forms.Button();
            this.btn_infocliente = new System.Windows.Forms.Button();
            this.btn_genrec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).BeginInit();
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
            // dgv_clientes
            // 
            this.dgv_clientes.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(13, 165);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.RowTemplate.Height = 24;
            this.dgv_clientes.Size = new System.Drawing.Size(416, 252);
            this.dgv_clientes.TabIndex = 7;
            // 
            // dgv_servicios
            // 
            this.dgv_servicios.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicios.Location = new System.Drawing.Point(437, 165);
            this.dgv_servicios.Name = "dgv_servicios";
            this.dgv_servicios.RowTemplate.Height = 24;
            this.dgv_servicios.Size = new System.Drawing.Size(416, 252);
            this.dgv_servicios.TabIndex = 11;
            // 
            // tbx_buscar
            // 
            this.tbx_buscar.BackColor = System.Drawing.Color.DimGray;
            this.tbx_buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_buscar.Location = new System.Drawing.Point(13, 137);
            this.tbx_buscar.Name = "tbx_buscar";
            this.tbx_buscar.Size = new System.Drawing.Size(209, 22);
            this.tbx_buscar.TabIndex = 4;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.DimGray;
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_buscar.Location = new System.Drawing.Point(228, 130);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(69, 29);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // btn_agrclient
            // 
            this.btn_agrclient.BackColor = System.Drawing.Color.DimGray;
            this.btn_agrclient.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_agrclient.Location = new System.Drawing.Point(13, 95);
            this.btn_agrclient.Name = "btn_agrclient";
            this.btn_agrclient.Size = new System.Drawing.Size(139, 29);
            this.btn_agrclient.TabIndex = 1;
            this.btn_agrclient.Text = "Agregar";
            this.btn_agrclient.UseVisualStyleBackColor = false;
            this.btn_agrclient.Click += new System.EventHandler(this.btn_agrclient_Click);
            // 
            // btn_modclient
            // 
            this.btn_modclient.BackColor = System.Drawing.Color.DimGray;
            this.btn_modclient.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_modclient.Location = new System.Drawing.Point(158, 95);
            this.btn_modclient.Name = "btn_modclient";
            this.btn_modclient.Size = new System.Drawing.Size(139, 29);
            this.btn_modclient.TabIndex = 2;
            this.btn_modclient.Text = "Modificar";
            this.btn_modclient.UseVisualStyleBackColor = false;
            this.btn_modclient.Click += new System.EventHandler(this.btn_modclient_Click);
            // 
            // btn_elimclient
            // 
            this.btn_elimclient.BackColor = System.Drawing.Color.DimGray;
            this.btn_elimclient.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_elimclient.Location = new System.Drawing.Point(303, 95);
            this.btn_elimclient.Name = "btn_elimclient";
            this.btn_elimclient.Size = new System.Drawing.Size(126, 29);
            this.btn_elimclient.TabIndex = 3;
            this.btn_elimclient.Text = "Eliminar";
            this.btn_elimclient.UseVisualStyleBackColor = false;
            this.btn_elimclient.Click += new System.EventHandler(this.btn_elimclient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de clientes";
            // 
            // st_agrserv
            // 
            this.st_agrserv.BackColor = System.Drawing.Color.DimGray;
            this.st_agrserv.ForeColor = System.Drawing.SystemColors.Control;
            this.st_agrserv.Location = new System.Drawing.Point(438, 95);
            this.st_agrserv.Name = "st_agrserv";
            this.st_agrserv.Size = new System.Drawing.Size(139, 29);
            this.st_agrserv.TabIndex = 8;
            this.st_agrserv.Text = "Agregar";
            this.st_agrserv.UseVisualStyleBackColor = false;
            this.st_agrserv.Click += new System.EventHandler(this.st_agrserv_Click);
            // 
            // btn_modserv
            // 
            this.btn_modserv.BackColor = System.Drawing.Color.DimGray;
            this.btn_modserv.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_modserv.Location = new System.Drawing.Point(583, 95);
            this.btn_modserv.Name = "btn_modserv";
            this.btn_modserv.Size = new System.Drawing.Size(139, 29);
            this.btn_modserv.TabIndex = 9;
            this.btn_modserv.Text = "Modificar";
            this.btn_modserv.UseVisualStyleBackColor = false;
            this.btn_modserv.Click += new System.EventHandler(this.btn_modserv_Click);
            // 
            // st_elimserv
            // 
            this.st_elimserv.BackColor = System.Drawing.Color.DimGray;
            this.st_elimserv.ForeColor = System.Drawing.SystemColors.Control;
            this.st_elimserv.Location = new System.Drawing.Point(728, 95);
            this.st_elimserv.Name = "st_elimserv";
            this.st_elimserv.Size = new System.Drawing.Size(125, 29);
            this.st_elimserv.TabIndex = 10;
            this.st_elimserv.Text = "Eliminar";
            this.st_elimserv.UseVisualStyleBackColor = false;
            this.st_elimserv.Click += new System.EventHandler(this.st_elimserv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(433, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gestión de servicios";
            // 
            // btn_infoempl
            // 
            this.btn_infoempl.BackColor = System.Drawing.Color.DimGray;
            this.btn_infoempl.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_infoempl.Location = new System.Drawing.Point(673, 12);
            this.btn_infoempl.Name = "btn_infoempl";
            this.btn_infoempl.Size = new System.Drawing.Size(180, 29);
            this.btn_infoempl.TabIndex = 12;
            this.btn_infoempl.Text = "Información de empleado";
            this.btn_infoempl.UseVisualStyleBackColor = false;
            this.btn_infoempl.Click += new System.EventHandler(this.btn_infoempl_Click);
            // 
            // btn_regtaf
            // 
            this.btn_regtaf.BackColor = System.Drawing.Color.DimGray;
            this.btn_regtaf.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_regtaf.Location = new System.Drawing.Point(13, 427);
            this.btn_regtaf.Name = "btn_regtaf";
            this.btn_regtaf.Size = new System.Drawing.Size(150, 29);
            this.btn_regtaf.TabIndex = 13;
            this.btn_regtaf.Text = "Registrar tarifas";
            this.btn_regtaf.UseVisualStyleBackColor = false;
            // 
            // btn_regcons
            // 
            this.btn_regcons.BackColor = System.Drawing.Color.DimGray;
            this.btn_regcons.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_regcons.Location = new System.Drawing.Point(169, 427);
            this.btn_regcons.Name = "btn_regcons";
            this.btn_regcons.Size = new System.Drawing.Size(150, 29);
            this.btn_regcons.TabIndex = 14;
            this.btn_regcons.Text = "Registrar consumos";
            this.btn_regcons.UseVisualStyleBackColor = false;
            // 
            // btn_reptaf
            // 
            this.btn_reptaf.BackColor = System.Drawing.Color.DimGray;
            this.btn_reptaf.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_reptaf.Location = new System.Drawing.Point(13, 462);
            this.btn_reptaf.Name = "btn_reptaf";
            this.btn_reptaf.Size = new System.Drawing.Size(150, 29);
            this.btn_reptaf.TabIndex = 16;
            this.btn_reptaf.Text = "Reporte tarifas";
            this.btn_reptaf.UseVisualStyleBackColor = false;
            this.btn_reptaf.Click += new System.EventHandler(this.btn_reptaf_Click);
            // 
            // btn_repcons
            // 
            this.btn_repcons.BackColor = System.Drawing.Color.DimGray;
            this.btn_repcons.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_repcons.Location = new System.Drawing.Point(169, 462);
            this.btn_repcons.Name = "btn_repcons";
            this.btn_repcons.Size = new System.Drawing.Size(150, 29);
            this.btn_repcons.TabIndex = 17;
            this.btn_repcons.Text = "Reporte consumos";
            this.btn_repcons.UseVisualStyleBackColor = false;
            this.btn_repcons.Click += new System.EventHandler(this.btn_repcons_Click);
            // 
            // btn_conshist
            // 
            this.btn_conshist.BackColor = System.Drawing.Color.DimGray;
            this.btn_conshist.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_conshist.Location = new System.Drawing.Point(689, 462);
            this.btn_conshist.Name = "btn_conshist";
            this.btn_conshist.Size = new System.Drawing.Size(164, 29);
            this.btn_conshist.TabIndex = 19;
            this.btn_conshist.Text = "Consumo histórico";
            this.btn_conshist.UseVisualStyleBackColor = false;
            this.btn_conshist.Click += new System.EventHandler(this.btn_conshist_Click);
            // 
            // btn_repgen
            // 
            this.btn_repgen.BackColor = System.Drawing.Color.DimGray;
            this.btn_repgen.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_repgen.Location = new System.Drawing.Point(325, 462);
            this.btn_repgen.Name = "btn_repgen";
            this.btn_repgen.Size = new System.Drawing.Size(150, 29);
            this.btn_repgen.TabIndex = 18;
            this.btn_repgen.Text = "Reporte General";
            this.btn_repgen.UseVisualStyleBackColor = false;
            this.btn_repgen.Click += new System.EventHandler(this.btn_repgen_Click);
            // 
            // btn_infocliente
            // 
            this.btn_infocliente.BackColor = System.Drawing.Color.DimGray;
            this.btn_infocliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_infocliente.Location = new System.Drawing.Point(304, 130);
            this.btn_infocliente.Name = "btn_infocliente";
            this.btn_infocliente.Size = new System.Drawing.Size(125, 29);
            this.btn_infocliente.TabIndex = 6;
            this.btn_infocliente.Text = "Información";
            this.btn_infocliente.UseVisualStyleBackColor = false;
            this.btn_infocliente.Click += new System.EventHandler(this.btn_infocliente_Click);
            // 
            // btn_genrec
            // 
            this.btn_genrec.BackColor = System.Drawing.Color.DimGray;
            this.btn_genrec.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_genrec.Location = new System.Drawing.Point(326, 427);
            this.btn_genrec.Name = "btn_genrec";
            this.btn_genrec.Size = new System.Drawing.Size(149, 29);
            this.btn_genrec.TabIndex = 15;
            this.btn_genrec.Text = "Generar Recibos";
            this.btn_genrec.UseVisualStyleBackColor = false;
            this.btn_genrec.Click += new System.EventHandler(this.btn_genrec_Click);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(865, 503);
            this.Controls.Add(this.btn_genrec);
            this.Controls.Add(this.btn_infocliente);
            this.Controls.Add(this.btn_repgen);
            this.Controls.Add(this.btn_conshist);
            this.Controls.Add(this.btn_repcons);
            this.Controls.Add(this.btn_reptaf);
            this.Controls.Add(this.btn_regcons);
            this.Controls.Add(this.btn_regtaf);
            this.Controls.Add(this.btn_infoempl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.st_elimserv);
            this.Controls.Add(this.btn_modserv);
            this.Controls.Add(this.st_agrserv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_elimclient);
            this.Controls.Add(this.btn_modclient);
            this.Controls.Add(this.btn_agrclient);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.tbx_buscar);
            this.Controls.Add(this.dgv_servicios);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.st_identity);
            this.Controls.Add(this.st_username);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(883, 550);
            this.MinimumSize = new System.Drawing.Size(883, 550);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label st_username;
        private System.Windows.Forms.Label st_identity;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.DataGridView dgv_servicios;
        private System.Windows.Forms.TextBox tbx_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_agrclient;
        private System.Windows.Forms.Button btn_modclient;
        private System.Windows.Forms.Button btn_elimclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button st_agrserv;
        private System.Windows.Forms.Button btn_modserv;
        private System.Windows.Forms.Button st_elimserv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_infoempl;
        private System.Windows.Forms.Button btn_regtaf;
        private System.Windows.Forms.Button btn_regcons;
        private System.Windows.Forms.Button btn_reptaf;
        private System.Windows.Forms.Button btn_repcons;
        private System.Windows.Forms.Button btn_conshist;
        private System.Windows.Forms.Button btn_repgen;
        private System.Windows.Forms.Button btn_infocliente;
        private System.Windows.Forms.Button btn_genrec;
    }
}