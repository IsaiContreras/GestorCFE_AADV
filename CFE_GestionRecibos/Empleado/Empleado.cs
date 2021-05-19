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

        private void UpdateClientesDgv()//ACTUALIZA DGVS
        {
            EnlaceCassandra link = new EnlaceCassandra();
            dgv_clientes.DataSource = null;
            dgv_servicios.DataSource = null;
            dgv_clientes.Columns.Clear();
            dgv_clientes.Rows.Clear();
            dgv_servicios.Columns.Clear();
            dgv_servicios.Rows.Clear();
            dgv_clientes.DataSource = link.LlenarClientes();
        }

        private void UpdateServiciosDgv()//ACTUALIZA DGV SERVICIOS
        {
            EnlaceCassandra link = new EnlaceCassandra();
            dgv_servicios.DataSource = null;
            dgv_servicios.Rows.Clear();
            dgv_servicios.Columns.Clear();
            Guid idcliente = (Guid)dgv_clientes.SelectedRows[0].Cells[4].Value;
            dgv_servicios.DataSource = link.LlenarServicios(idcliente);
            for (int i = 0; i < dgv_servicios.Rows.Count; i++)
            {
                Domicilio capture;
                string domic = Convert.ToString(dgv_servicios.Rows[i].Cells[2].Value);
                capture = new Domicilio(domic);
                string formated = capture.getFormat();
                dgv_servicios.Rows[i].Cells[2].Value = formated;
            }
            dgv_servicios.AutoResizeColumns();
            if (dgv_servicios.Rows.Count > 0)
            {
                btn_modserv.Enabled = true;
                btn_elimserv.Enabled = true;
                btn_conshist.Enabled = true;
            }
            else
            {
                btn_modserv.Enabled = false;
                btn_elimserv.Enabled = false;
                btn_conshist.Enabled = false;
            }
        }

        private void btn_agrclient_Click(object sender, EventArgs e)
        {
            AgregarCliente dialogAC = new AgregarCliente();
            dialogAC.id_emp = id;
            dialogAC.empUsername = username;
            if (dialogAC.ShowDialog() == DialogResult.OK)
            {
                UpdateClientesDgv();
            }
        }

        private void btn_modclient_Click(object sender, EventArgs e)
        {
            AgregarCliente dialogMC = new AgregarCliente();
            dialogMC.id_emp = id;
            dialogMC.empUsername = username;
            dialogMC.id_client = (Guid)dgv_clientes.SelectedRows[0].Cells[4].Value;
            dialogMC.Text = "Modificar cliente";
            if (dialogMC.ShowDialog() == DialogResult.OK)
            {
                UpdateClientesDgv();
            }
        }

        private void btn_infoempl_Click(object sender, EventArgs e)
        {
            Información dialogInfo = new Información();
            dialogInfo.id = Convert.ToInt32(id);
            dialogInfo.ShowDialog();
        }

        private void st_agrserv_Click(object sender, EventArgs e)
        {
            AgregarServicio dialogAS = new AgregarServicio();
            dialogAS.num_emp = id;
            dialogAS.empUsername = username;
            dialogAS.id_client = (Guid)dgv_clientes.SelectedRows[0].Cells[4].Value;
            dialogAS.username = Convert.ToString(dgv_clientes.SelectedRows[0].Cells[0].Value) + " " + Convert.ToString(dgv_clientes.SelectedRows[0].Cells[1].Value);
            if (dialogAS.ShowDialog() == DialogResult.OK)
            {
                UpdateServiciosDgv();
            }
        }

        private void btn_modserv_Click(object sender, EventArgs e)
        {
            AgregarServicio dialogMS = new AgregarServicio();
            dialogMS.num_emp = id;
            dialogMS.empUsername = username;
            dialogMS.id_client = (Guid)dgv_clientes.SelectedRows[0].Cells[4].Value;
            dialogMS.username = Convert.ToString(dgv_clientes.SelectedRows[0].Cells[0].Value) + " " + Convert.ToString(dgv_clientes.SelectedRows[0].Cells[1].Value);
            dialogMS.id_serv = (Guid)dgv_servicios.SelectedRows[0].Cells[3].Value;
            dialogMS.Text = "Modificar servicio";
            if (dialogMS.ShowDialog() == DialogResult.OK)
            {
                UpdateServiciosDgv();
            }
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
                EnlaceCassandra link = new EnlaceCassandra();
                Guid id_cl = (Guid)dgv_clientes.SelectedRows[0].Cells[4].Value;
                if (link.EliminarCliente(id_cl, id))
                {
                    MessageBox.Show("Cliente eliminado con éxito.", "Información");
                    UpdateClientesDgv();
                }
                else{
                    MessageBox.Show("No se pudo eliminar cliente.", "Información");
                    UpdateClientesDgv();
                }
            }
        }

        private void btn_elimserv_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que desea dar de baja este servicio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                EnlaceCassandra link = new EnlaceCassandra();
                Guid id_cli = (Guid)dgv_clientes.SelectedRows[0].Cells[4].Value;
                Guid id_ser = (Guid)dgv_servicios.SelectedRows[0].Cells[3].Value;
                if (link.EliminarServicio(id_cli, id_ser, id))
                {
                    MessageBox.Show("Servicio eliminado con éxito.", "Información");
                    UpdateServiciosDgv();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar servicio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    UpdateServiciosDgv();
                }
            }
        }

        private void btn_infocliente_Click(object sender, EventArgs e)
        {
            Cliente.Información dialogIC = new Cliente.Información();
            dialogIC.ShowDialog();
        }

        private void Empleado_Load(object sender, EventArgs e)//INICIALIZACIÓN
        {
            st_identity.Text = "ID: " + id.ToString();
            st_username.Text = "Usuario: " + username;
            UpdateClientesDgv();
        }

        private void btn_genrec_Click(object sender, EventArgs e)
        {
            GeneradorRecibo dialogGR = new GeneradorRecibo();
            dialogGR.Show();
        }

        private void btn_regtaf_Click(object sender, EventArgs e)
        {
            Tarifa dialogTar = new Tarifa();
            dialogTar.ShowDialog();
        }

        private void btn_regcons_Click(object sender, EventArgs e)
        {
            Consumo dialogCon = new Consumo();
            dialogCon.ShowDialog();
        }

        private void btn_showserv_Click(object sender, EventArgs e)
        {
            UpdateServiciosDgv();
        }
    }
}
