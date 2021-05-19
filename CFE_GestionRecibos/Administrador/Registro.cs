using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFE_GestionRecibos.Administrador
{
    public partial class Registro : Form
    {
        public int id = 00;

        public Registro()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_detalles_Click(object sender, EventArgs e)
        {
            RegistroDetalles dialogRD = new RegistroDetalles();
            dialogRD.id = Convert.ToInt64(dgv_registro.SelectedRows[0].Cells[0].Value);
            dialogRD.ShowDialog();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            //EnlaceDB link = new EnlaceDB();
            //dgv_registro.DataSource = link.LlenarRegistroAct(id);
            //dgv_registro.AutoResizeColumns();
        }
    }
}
