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
        public int id = 001;
        public string username = "Default Admin";

        public Administrador()
        {
            InitializeComponent();
        }

        private void btn_agremp_Click(object sender, EventArgs e)
        {
            Agregar dialogA = new Agregar();
            dialogA.ShowDialog();
        }

        private void btn_edtemp_Click(object sender, EventArgs e)
        {
            Agregar dialogB = new Agregar();
            dialogB.Text = "Editar";
            dialogB.ShowDialog();
        }

        private void btn_regact_Click(object sender, EventArgs e)
        {
            Registro dialogC = new Registro();
            dialogC.ShowDialog();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            st_identity.Text = "ID: " + id.ToString();
            st_username.Text = "Usuario: " + username;
        }

        private void btn_elimemp_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que desea dar de baja este empleado de forma definitiva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Eliminado con éxito", "Información");
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Empleado.Información dialogInfo = new Empleado.Información();
            dialogInfo.ShowDialog();
        }

    }
}
