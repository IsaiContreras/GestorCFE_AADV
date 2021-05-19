using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFE_GestionRecibos
{
    public partial class Teléfono : Form
    {
        public Teléfono()
        {
            InitializeComponent();
        }

        public bool validar()
        {
            if (tbx_tel.TextLength == 0)
            {
                MessageBox.Show("", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_tel.Text))
            {
                MessageBox.Show("", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            return true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
