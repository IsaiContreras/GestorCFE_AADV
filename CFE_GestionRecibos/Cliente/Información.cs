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
    public partial class Información : Form
    {
        public Guid id_cli;

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
            ClienteClass client = link.DatosCliente(id_cli);
            client.split_domic();
            st_identity.Text = "ID: " + client.id_cliente.ToString();
            st_username.Text = "Nombre de usuario: " + client.nombres + " " + client.apellidos;
            st_email.Text = "Correo electrónico: " + client.correo_electronico;
            st_domicilio.Text = "Domicilio: " + client.domic.getFormat();
            tm = new DateTime(client.fecha_nac.Year, client.fecha_nac.Month, client.fecha_nac.Day);
            st_fecnac.Text = "Fecha de nacimiento: " + string.Format(tm.ToShortDateString(), "dd/mm/aaaa");
            int age = Convert.ToInt32((DateTime.Today - tm).TotalDays / 365.25);
            st_edad.Text = "Edad: " + age.ToString();
            lbx_telefonos.DataSource = client.telefonos;
        }
    }
}