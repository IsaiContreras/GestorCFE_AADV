using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cassandra;

namespace CFE_GestionRecibos.Administrador
{
    public partial class RegistroDetalles : Form
    {
        public Guid id;
        public Guid id_emp;

        public RegistroDetalles()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegistroDetalles_Load(object sender, EventArgs e)
        {
            EnlaceCassandra link = new EnlaceCassandra();
            DateTime dt;
            RegistroActClass registro = link.DatosRegistroAct(id_emp, id);
            st_registroid.Text = "ID Registro: " + registro.clave.ToString();
            st_numempl.Text = "Núm. de empleado: " + registro.num_empleado;
            dt = new DateTime(registro.fecha_reg.Year, registro.fecha_reg.Month, registro.fecha_reg.Day, registro.fecha_reg.Hour, registro.fecha_reg.Minute, registro.fecha_reg.Second);
            st_fechahora.Text = "Fecha y hora: " + string.Format(dt.ToString(), "dd/mm/aaaa HH:mm:ss");
            st_actividad.Text = "Actividad: " + registro.accion;
            st_descripcion.Text = registro.descripcion;
        }
    }
}
