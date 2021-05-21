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
    public partial class Tarifa : Form
    {
        TarifaClass tarifa;

        public Guid id_emp;
        public string username;

        public Tarifa()
        {
            InitializeComponent();
        }

        private bool validar()
        {
            if (tbx_año.TextLength == 0)
            {
                MessageBox.Show("Escriba el año del periodo de facturación.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_año.Text))
            {
                MessageBox.Show("El año no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (cbx_mes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el mes del periodo de facturación.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_tarbas.TextLength == 0)
            {
                MessageBox.Show("Capture la tarifa básica.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsDecimalNumber(tbx_tarbas.Text))
            {
                MessageBox.Show("La tarifa básica no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_tarint.TextLength == 0)
            {
                MessageBox.Show("Capture la tarifa intermedia.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsDecimalNumber(tbx_tarint.Text))
            {
                MessageBox.Show("La tarifa intermedia no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_tarexc.TextLength == 0)
            {
                MessageBox.Show("Capture la tarifa excedente.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsDecimalNumber(tbx_tarexc.Text))
            {
                MessageBox.Show("La tarifa excedente no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            tarifa = new TarifaClass(
                Convert.ToInt32(tbx_año.Text),
                Convert.ToSByte(cbx_mes.Text),
                Convert.ToBoolean(cbx_tiposerv.SelectedIndex),
                Convert.ToDecimal(tbx_tarbas.Text),
                Convert.ToDecimal(tbx_tarint.Text),
                Convert.ToDecimal(tbx_tarexc.Text)
            );

            return true;
        }

        private void Tarifa_Load(object sender, EventArgs e)
        {
            cbx_tiposerv.SelectedIndex = 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                EnlaceCassandra link = new EnlaceCassandra();
                if (link.AgregarTarifa(tarifa, id_emp, username))
                {
                    MessageBox.Show("Tarifa capturada.", "Información");
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la tarifa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }
            }
        }
    }
}
