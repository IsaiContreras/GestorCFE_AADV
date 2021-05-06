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
    public partial class AgregarServicio : Form
    {
        public int id = 001;
        public string username = "Default Costumer";

        public AgregarServicio()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(Text == "Modificar servicio")
            {
                MessageBox.Show("Servicio editado con éxito.", "Información");
            }
            else
            {
                MessageBox.Show("Servicio registrado con éxito.", "Información");
            }
            Close();
        }

        private void AgregarServicio_Load(object sender, EventArgs e)
        {
            if(Text == "Modificar servicio")
            {
                btn_ok.Text = "Aceptar";
            }
            st_identity.Text = "ID: " + id.ToString();
            st_username.Text = "Usuario: " + username;
        }
    }
}
