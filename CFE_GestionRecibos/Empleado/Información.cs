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
    public partial class Información : Form
    {
        public int id = 001;

        public Información()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Información_Load(object sender, EventArgs e)
        {
            //EnlaceDB link = new EnlaceDB();
            //DateTime tm;
            //DataRow empleado = link.ObtenerEmpleado(id);
            //st_identity.Text = "ID: " + Convert.ToString(empleado.ItemArray[0]);
            //st_username.Text = "Usuario: " + Convert.ToString(empleado.ItemArray[1]);
            //tm = (DateTime)empleado.ItemArray[2];
            //st_fecnac.Text = "Fecha de nacimiento: " + string.Format(tm.ToShortDateString(), "dd/mm/aaaa");
            //st_edad.Text = "Edad: " + Convert.ToString(empleado.ItemArray[3]);
            //st_curp.Text = "CURP: " + Convert.ToString(empleado.ItemArray[4]);
            //st_rfc.Text = "RFC: " + Convert.ToString(empleado.ItemArray[5]);
            //st_email.Text = "Correo electrónico: " + Convert.ToString(empleado.ItemArray[6]);
            //tm = (DateTime)empleado.ItemArray[7];
            //st_fechaalta.Text = "Fecha de alta: " + string.Format(tm.ToShortDateString(), "dd/mm/aaaa");
        }
    }
}
