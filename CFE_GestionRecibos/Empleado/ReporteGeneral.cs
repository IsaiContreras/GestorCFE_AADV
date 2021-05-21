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
    public partial class ReporteGeneral : Form
    {
        public ReporteGeneral()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReporteGeneral_Load(object sender, EventArgs e)
        {
            cbx_tiposerv.SelectedIndex = 0;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
