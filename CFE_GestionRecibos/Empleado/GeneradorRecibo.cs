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
        public Guid id_emp;
        public string username;

        public GeneradorRecibo()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // GENERAR RECIBOS
            if (tbx_año.TextLength == 0)
            {
                MessageBox.Show("Capture el año del periodo de facturación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_año.Text))
            {
                MessageBox.Show("El año no debe contener letras.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (cbx_mes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el mes del periodo de facturación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            EnlaceCassandra link = new EnlaceCassandra();
            if(link.GenerarRecibos(id_emp, username, Convert.ToInt32(tbx_año.Text), Convert.ToSByte(cbx_mes.Text), Convert.ToBoolean(cbx_tiposerv.SelectedIndex)))
            {
                string msg = "Recibos de " + cbx_mes.Text + " de " + tbx_año.Text + " del tipo " + cbx_tiposerv.Text + " generados.";
                MessageBox.Show(msg, "Información");
                Close();
            }
            else
            {
                MessageBox.Show("No se pudo completar la operación.", "Generador de recibos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GeneradorRecibo_Load(object sender, EventArgs e)
        {
            cbx_tiposerv.SelectedIndex = 0;
        }
    }
}
