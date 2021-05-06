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
    public partial class GeneradorRecibo : Form
    {
        public GeneradorRecibo()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // GENERAR RECIBOS

            string msg = "Recibos de " + cbx_mes.Text + " de " + tbx_año.Text + " del tipo " + cbx_tiposerv.Text + " generados.";
            MessageBox.Show(msg, "Información");
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
