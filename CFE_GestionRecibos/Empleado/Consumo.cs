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
    public partial class Consumo : Form
    {
        ConsumoClass consumo;

        public Consumo()
        {
            InitializeComponent();
        }

        private bool validar()
        {
            if (tbx_medidor.TextLength == 0)
            {
                MessageBox.Show("Llene el campo medidor.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_medidor.Text))
            {
                MessageBox.Show("El medidor no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
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
            if (tbx_consumo.TextLength == 0)
            {
                MessageBox.Show("Capture el consumo del servicio.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_consumo.Text))
            {
                MessageBox.Show("El consumo no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            consumo = new ConsumoClass(
                Convert.ToInt32(tbx_año.Text),    
                Convert.ToSByte(cbx_mes.Text),
                Convert.ToInt64(tbx_medidor.Text),
                Convert.ToInt32(tbx_consumo.Text)
            );

            return true;
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
                if (link.AgregarConsumo(consumo))
                {
                    MessageBox.Show("Consumo capturado.", "Información");
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el consumo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }
            }
        }
    }
}
