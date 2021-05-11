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
    public partial class Empleado : Form
    {
        public Guid id;
        public string username = "Default Employee";

        public Empleado()
        {
            InitializeComponent();
        }

        private void btn_agrclient_Click(object sender, EventArgs e)
        {
            AgregarCliente dialogAC = new AgregarCliente();
            dialogAC.ShowDialog();
        }

        private void btn_modclient_Click(object sender, EventArgs e)
        {
            AgregarCliente dialogMC = new AgregarCliente();
            dialogMC.Text = "Modificar cliente";
            dialogMC.ShowDialog();
        }

        private void btn_infoempl_Click(object sender, EventArgs e)
        {
            Información dialogInfo = new Información();
            dialogInfo.ShowDialog();
        }

        private void st_agrserv_Click(object sender, EventArgs e)
        {
            AgregarServicio dialogAS = new AgregarServicio();
            dialogAS.ShowDialog();
        }

        private void btn_modserv_Click(object sender, EventArgs e)
        {
            AgregarServicio dialogMS = new AgregarServicio();
            dialogMS.Text = "Modificar servicio";
            dialogMS.ShowDialog();
        }

        private void btn_reptaf_Click(object sender, EventArgs e)
        {
            ReporteTarifas dialogRT = new ReporteTarifas();
            dialogRT.ShowDialog();
        }

        private void btn_repcons_Click(object sender, EventArgs e)
        {
            ReporteConsumos dialogRC = new ReporteConsumos();
            dialogRC.ShowDialog();
        }

        private void btn_repgen_Click(object sender, EventArgs e)
        {
            ReporteGeneral dialogRG = new ReporteGeneral();
            dialogRG.ShowDialog();
        }

        private void btn_conshist_Click(object sender, EventArgs e)
        {
            ConsumoHistórico dialogCH = new ConsumoHistórico();
            dialogCH.ShowDialog();
        }

        private void btn_elimclient_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que desea dar de baja este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Cliente eliminado con éxito.", "Información");
            }
        }

        private void st_elimserv_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que desea dar de baja este servicio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Servicio eliminado con éxito.", "Información");
            }
        }

        private void btn_infocliente_Click(object sender, EventArgs e)
        {
            Cliente.Información dialogIC = new Cliente.Información();
            dialogIC.ShowDialog();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            st_identity.Text = "ID: " + id.ToString();
            st_username.Text = "Usuario: " + username;
        }

        private void btn_genrec_Click(object sender, EventArgs e)
        {
            GeneradorRecibo dialogGR = new GeneradorRecibo();
            dialogGR.Show();
        }
    }
}
