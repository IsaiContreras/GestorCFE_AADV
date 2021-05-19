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
    public partial class RegistroDetalles : Form
    {
        public long id = 00;

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
            //EnlaceDB link = new EnlaceDB();
            //DateTime tm;
            //DataRow registro = link.ObtenerRegistroAct(id);
            //st_registroid.Text = "ID Registro: " + Convert.ToString(registro.ItemArray[0]);
            //st_numempl.Text = "Núm. de empleado: " + Convert.ToString(registro.ItemArray[1]);
            //tm = (DateTime)registro.ItemArray[2];
            //st_fechahora.Text = "Fecha y hora: " + string.Format(tm.ToString(), "dd/mm/aaaa HH:mm:ss");
            //st_actividad.Text = "Actividad: " + Convert.ToString(registro.ItemArray[3]);
            //st_descripcion.Text = Convert.ToString(registro.ItemArray[4]);
        }
    }
}
