using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFE_GestionRecibos.Empleado
{
    public partial class DesbloqCliente : Form
    {
        public DesbloqCliente()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_desbloq_Click(object sender, EventArgs e)
        {
            EnlaceCassandra link = new EnlaceCassandra();
            link.DesbloquearCliente(dgv_bloqueados.SelectedRows[0].Cells[0].Value.ToString());
            dgv_bloqueados.DataSource = link.LogsBloqueados(0);
            if (dgv_bloqueados.Rows.Count != 0)
                btn_desbloq.Enabled = true;
            else btn_desbloq.Enabled = false;
        }

        private void DesbloqCliente_Load(object sender, EventArgs e)
        {
            EnlaceCassandra link = new EnlaceCassandra();
            dgv_bloqueados.DataSource = link.LogsBloqueados(0);
            if (dgv_bloqueados.Rows.Count != 0)
                btn_desbloq.Enabled = true;
        }
    }
}
