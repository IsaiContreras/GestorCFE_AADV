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
    public partial class PagoTarjeta : Form
    {
        public Guid id_cli;
        public Guid id_serv;
        public Guid id_rec;

        TarjetaClass tarjeta_n;
        List<TarjetaClass> tarjetas;

        public PagoTarjeta()
        {
            InitializeComponent();
        }

        public bool validarTarjeta()
        {
            if (tbx_numtarj.TextLength == 0)
            {
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_numtarj.Text))
            {
                return false;
            }
            if (tbx_mes.TextLength == 0)
            {
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_mes.Text))
            {
                return false;
            }
            if (tbx_año.TextLength == 0)
            {
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_año.Text))
            {
                return false;
            }
            if (tbx_cvv.TextLength == 0)
            {
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_cvv.Text))
            {
                return false;
            }
            return true;
        }

        public bool validar()
        {
            if (!validarTarjeta())
            {
                return false;
            }
            if (tbx_cantidad.TextLength == 0)
            {
                return false;
            }
            else if (!RegexUtilities.IsDecimalNumber(tbx_cantidad.Text))
            {
                return false;
            }
            return true;
        }

        private void PagoTarjeta_FormClosing(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                EnlaceCassandra link = new EnlaceCassandra();
                link.Pago(id_cli, id_serv, id_rec, Convert.ToDecimal(tbx_cantidad.Text));
                link.AgregarTarjeta(id_cli, tarjetas);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void PagoTarjeta_Load(object sender, EventArgs e)
        {
            EnlaceCassandra link = new EnlaceCassandra();
            tarjetas = link.Tarjetas(id_cli);
            foreach(TarjetaClass tar in tarjetas)
            {
                tar.split();
            }
            cbx_tarjetas.DisplayMember = "numero";
            cbx_tarjetas.DataSource = tarjetas;
            cbx_tarjetas.SelectedIndex = -1;
        }

        private void cbx_tarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_tarjetas.SelectedIndex == -1)
            {
                TarjetaClass show = tarjetas.Find(x => x.numero == cbx_tarjetas.Text);
                tbx_numtarj.Text = show.numero;
                tbx_año.Text = show.año;
                tbx_mes.Text = show.mes;
                tbx_cvv.Text = show.cvv;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            foreach (TarjetaClass tar in tarjetas)
            {
                if (tbx_numtarj.Text == tar.numero)
                {
                    MessageBox.Show("Esta tarjeta ya existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            if (validarTarjeta())
            {
                tarjetas.Add(new TarjetaClass(
                    tbx_numtarj.Text,
                    tbx_mes.Text,
                    tbx_año.Text,
                    tbx_cvv.Text
                ));
            }
            cbx_tarjetas.DataSource = null;
            cbx_tarjetas.DataSource = tarjetas;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            TarjetaClass rem = tarjetas.Find(x => x.numero == cbx_tarjetas.Text);
            tarjetas.Remove(rem);
            cbx_tarjetas.DataSource = null;
            cbx_tarjetas.DataSource = tarjetas;
        }
    }
}