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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_detalles_Click(object sender, EventArgs e)
        {
            RegistroDetalles dialogRD = new RegistroDetalles();
            dialogRD.ShowDialog();
        }
    }
}
