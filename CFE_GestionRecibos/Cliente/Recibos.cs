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
        public Guid id_cli;
        public string username;

        public Guid id_serv;
        public Guid id_rec;

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
                dialogPE.id_cli = id_cli;
                dialogPE.id_serv = id_serv;
                dialogPE.id_rec = id_rec;
                res = dialogPE.ShowDialog();
            }
            else if (rdb_tarjeta.Checked == true)
            {
                PagoTarjeta dialogPT = new PagoTarjeta();
                dialogPT.id_cli = id_cli;
                dialogPT.id_serv = id_serv;
                dialogPT.id_rec = id_rec;
                res = dialogPT.ShowDialog();
            }
            else
            {
                PagoTransf dialogPTr = new PagoTransf();
                dialogPTr.id_cli = id_cli;
                dialogPTr.id_serv = id_serv;
                dialogPTr.id_rec = id_rec;
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
            EnlaceCassandra link = new EnlaceCassandra();
            ReciboClass rec = link.DatosRecibo(id_serv, id_rec);
            rec.get_domic_parts();
            st_username.Text = "Cliente: " + username;
            st_identity.Text = "ID: " + id_cli.ToString();
            st_medidor.Text = "Medidor: " + rec.medidor.ToString();
            if (!rec.tipo_ser) st_tiposerv.Text = "Tipo de servicio: Doméstico";
            else st_tiposerv.Text = "Tipo de servicio: Industrial";
            st_domicilio.Text = "Domicilio: " + rec.domic.getFormat();
            st_periodo.Text = "Periodo: " + rec.year.ToString() + "/" + rec.month.ToString();
            st_consbas.Text = rec.consumo_basico.ToString() + " kW";
            st_consint.Text = rec.consumo_intermedio.ToString() + " kW";
            st_consexced.Text = rec.consumo_excedente.ToString() + " kW";
            st_constot.Text = rec.consumo_total.ToString() + " kW";
            st_prebas.Text = "$" + string.Format("{0:0.00}", rec.tarifa_basica);
            st_preint.Text = "$" + string.Format("{0:0.00}", rec.tarifa_intermedia);
            st_preexc.Text = "$" + string.Format("{0:0.00}", rec.tarifa_excedente);
            st_pabas.Text = "$" + string.Format("{0:0.00}", rec.precio_basico);
            st_paint.Text = "$" + string.Format("{0:0.00}", rec.precio_intermedio);
            st_paexc.Text = "$" + string.Format("{0:0.00}", rec.precio_excedente);
            st_pretot.Text = "$" + string.Format("{0:0.00}", rec.precio_total);
            st_paiva.Text = "$" + string.Format("{0:0.00}", rec.cargo_iva);
            st_papend.Text = "$" + string.Format("{0:0.00}", rec.prev_pendiente);
            st_patot.Text = "$" + string.Format("{0:0.00}", rec.pago_total);
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