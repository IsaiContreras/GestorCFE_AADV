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
        public Guid id;

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
            dialogRD.id = (Guid)dgv_registro.SelectedRows[0].Cells[2].Value;
            dialogRD.id_emp = id;
            dialogRD.ShowDialog();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            EnlaceCassandra link = new EnlaceCassandra();
            dgv_registro.DataSource = link.LlenarRegistroAct(id);
            dgv_registro.AutoResizeColumns();
        }
    }
}