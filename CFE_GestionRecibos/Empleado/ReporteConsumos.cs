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
    public partial class ReporteConsumos : Form
    {
        public ReporteConsumos()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (tbx_año.TextLength > 0)
            {
                EnlaceCassandra link = new EnlaceCassandra();
                dgv_reporte.DataSource = link.ReporteConsumos(Convert.ToInt32(tbx_año.Text));
                dgv_reporte.AutoResizeColumns();
            }
        }
    }
}