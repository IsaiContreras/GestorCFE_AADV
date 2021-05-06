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
        public int id = 001;
        public string username = "Default Costumer";

        public Cliente()
        {
            InitializeComponent();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Información dialogInfo = new Información();
            dialogInfo.ShowDialog();
        }

        private void btn_recibo_Click(object sender, EventArgs e)
        {
            Recibos dialogR = new Recibos();
            dialogR.ShowDialog();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            st_identity.Text = "ID: " + id.ToString();
            st_username.Text = "Usuario: " + username;
        }
    }
}
