using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFE_GestionRecibos.Cliente
{
    public partial class Cliente : Form
    {
        public Guid id;
        public string username = "Default Costumer";

        public Cliente()
        {
            InitializeComponent();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Información dialogInfo = new Información();
            dialogInfo.id_cli = id;
            dialogInfo.ShowDialog();
        }

        private void btn_recibo_Click(object sender, EventArgs e)
        {
            Recibos dialogR = new Recibos();
            dialogR.id_cli = id;
            dialogR.username = username;
            dialogR.id_serv = (Guid)cbx_servicios.SelectedValue;
            dialogR.id_rec = (Guid)dgv_recibos.SelectedRows[0].Cells[6].Value;
            dialogR.ShowDialog();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            st_identity.Text = "ID: " + id.ToString();
            st_username.Text = "Usuario: " + username;
            EnlaceCassandra link = new EnlaceCassandra();
            cbx_servicios.DisplayMember = "medidor";
            cbx_servicios.ValueMember = "id_serv";
            cbx_servicios.DataSource = link.LlenarServicios(id);
        }

        private void cbx_servicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnlaceCassandra link = new EnlaceCassandra();
            dgv_recibos.DataSource = link.LlenarRecibos((Guid)cbx_servicios.SelectedValue);
        }
    }
}
