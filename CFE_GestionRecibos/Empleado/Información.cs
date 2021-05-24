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
        public Guid id;

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
            EnlaceCassandra link = new EnlaceCassandra();
            DateTime tm;
            EmpleadoClass empleado = link.DatosEmpleado(id);
            st_identity.Text = "ID: " + empleado.num_empleado.ToString();
            st_username.Text = "Usuario: " + empleado.nombres + " " + empleado.apellidos;
            tm = new DateTime(empleado.fecha_nac.Year, empleado.fecha_nac.Month, empleado.fecha_nac.Day);
            st_fecnac.Text = "Fecha de nacimiento: " + string.Format(tm.ToShortDateString(), "dd/mm/aaaa");
            int age = Convert.ToInt32((DateTime.Today - tm).TotalDays / 365.25);
            st_edad.Text = "Edad: " + age.ToString();
            st_curp.Text = "CURP: " + empleado.curp;
            st_rfc.Text = "RFC: " + empleado.rfc;
            st_email.Text = "Correo electrónico: " + empleado.correo_electronico;
            lbx_telefonos.DataSource = empleado.telefonos;
        }
    }
}