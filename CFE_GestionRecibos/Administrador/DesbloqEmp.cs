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
    public partial class DesbloqEmp : Form
    {
        public DesbloqEmp()
        {
            InitializeComponent();
        }

        private void DesbloqEmp_Load(object sender, EventArgs e)
        {
            EnlaceCassandra link = new EnlaceCassandra();
            dgv_bloqueados.DataSource = link.LogsBloqueados(1);
            if (dgv_bloqueados.Rows.Count != 0)
                btn_desbloq.Enabled = true;
        }

        private void btn_desbloq_Click(object sender, EventArgs e)
        {
            EnlaceCassandra link = new EnlaceCassandra();
            link.DesbloquearEmpleado(dgv_bloqueados.SelectedRows[0].Cells[0].Value.ToString());
            dgv_bloqueados.DataSource = link.LogsBloqueados(1);
            if (dgv_bloqueados.Rows.Count != 0)
                btn_desbloq.Enabled = true;
            else btn_desbloq.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
