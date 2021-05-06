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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(Text == "Editar")
            {
                // EDITAR Empleado
                MessageBox.Show("Empleado modificado con éxito.", "Información");
            }
            else
            {
                // ALTA Empleado
                MessageBox.Show("Empleado registrado con éxito.", "Información");
            }
            Close();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            if (Text == "Editar")
            {
                btn_ok.Text = "Aceptar";
            }
        }

        private void btn_addtel_Click(object sender, EventArgs e)
        {
            Teléfono dialogT = new Teléfono();
            dialogT.ShowDialog();
        }

        private void btn_deltel_Click(object sender, EventArgs e)
        {
            //QUITA TELEFONO
        }
    }
}
