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
        public Guid id_cli;

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
            cbx_mes.SelectedIndex = 0;
            cbx_tiposerv.SelectedIndex = 0;
            st_identity.Text = "ID: " + id_cli.ToString();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (tbx_año.TextLength == 0)
            {
                MessageBox.Show("Capture el año.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_año.Text))
            {
                MessageBox.Show("El año no debe contener letras.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            EnlaceCassandra link = new EnlaceCassandra();
            dgv_reporte.DataSource = link.ReporteGeneral(
                id_cli,
                Convert.ToInt32(tbx_año.Text),
                Convert.ToSByte(cbx_mes.Text),
                Convert.ToSByte(cbx_tiposerv.SelectedIndex)
            );
        }
    }
}
