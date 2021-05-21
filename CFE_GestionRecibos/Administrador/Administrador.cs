using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFE_GestionRecibos.Administrador
{
    public partial class Administrador : Form
    {
        public Guid id;
        public string username = "Default Admin";

        public Administrador()
        {
            InitializeComponent();
        }

        public void UpdateDgv()
        {
            EnlaceCassandra link = new EnlaceCassandra();
            dgv_empleados.DataSource = null;
            dgv_empleados.Columns.Clear();
            dgv_empleados.Rows.Clear();
            dgv_empleados.DataSource = link.LlenarEmpleados();
            dgv_empleados.AutoResizeColumns();
        }

        private void btn_agremp_Click(object sender, EventArgs e)
        {
            Agregar dialogA = new Agregar();
            if (dialogA.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
            }
        }

        private void btn_edtemp_Click(object sender, EventArgs e)
        {
            Agregar dialogB = new Agregar();
            dialogB.id_emp = (Guid)dgv_empleados.SelectedRows[0].Cells[3].Value;
            dialogB.Text = "Editar empleado";
            if (dialogB.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
            }
        }

        private void btn_regact_Click(object sender, EventArgs e)
        {
            Registro dialogC = new Registro();
            dialogC.id = (Guid)dgv_empleados.SelectedRows[0].Cells[3].Value;
            dialogC.ShowDialog();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            st_identity.Text = "ID: " + id.ToString();
            st_username.Text = "Usuario: " + username;
            UpdateDgv();
        }

        private void btn_elimemp_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que desea dar de baja este empleado de forma definitiva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EnlaceCassandra link = new EnlaceCassandra();
                Guid id_emp = (Guid)dgv_empleados.SelectedRows[0].Cells[3].Value;
                if (link.EliminarEmpleado(id_emp))
                {
                    MessageBox.Show("Eliminado con éxito", "Información");
                    UpdateDgv();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar empleado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Empleado.Información dialogInfo = new Empleado.Información();
            dialogInfo.id = (Guid)dgv_empleados.SelectedRows[0].Cells[3].Value;
            dialogInfo.ShowDialog();
        }

    }
}
