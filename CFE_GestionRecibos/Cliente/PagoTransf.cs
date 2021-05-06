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
    public partial class PagoTransf : Form
    {
        public PagoTransf()
        {
            InitializeComponent();
        }

        private void PagoTransf_FormClosing(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
