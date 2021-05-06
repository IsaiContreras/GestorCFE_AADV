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
    public partial class Recibos : Form
    {
        public Recibos()
        {
            InitializeComponent();
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            var res = DialogResult.Cancel;
            if (rdb_efectivo.Checked == true)
            {
                PagoEfectivo dialogPE = new PagoEfectivo();
                res = dialogPE.ShowDialog();
            }
            else if (rdb_tarjeta.Checked == true)
            {
                PagoTarjeta dialogPT = new PagoTarjeta();
                res = dialogPT.ShowDialog();
            }
            else
            {
                PagoTransf dialogPTr = new PagoTransf();
                res = dialogPTr.ShowDialog();
            }
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Pago realizado con éxito.", "Información");
                Close();
            }
        }

        private void Recibos_Load(object sender, EventArgs e)
        {
            rdb_efectivo.Checked = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Recibos_FormClosing(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
