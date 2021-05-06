using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFE_GestionRecibos
{
    public partial class LOG_IN : Form
    {
        public LOG_IN()
        {
            InitializeComponent();
        }

        private void LOG_IN_Load(object sender, EventArgs e)
        {
            cbx_usertype.SelectedIndex = 0;
        }
        
      

        private void btn_login_Click(object sender, EventArgs e)
        {
            switch (cbx_usertype.SelectedIndex)
            {
                case 0:
                    {
                        // Cliente
                        Cliente.Cliente dialogCli = new Cliente.Cliente();
                        Hide();
                        dialogCli.ShowDialog();
                        Close();
                        break;
                    }
                case 1:
                    {
                        // Empleado
                        Empleado.Empleado dialogEmp = new Empleado.Empleado();
                        Hide();
                        dialogEmp.ShowDialog();
                        Close();
                        break;
                    }
                case 2:
                    {
                        // Administrador
                        Administrador.Administrador dialogAdmin = new Administrador.Administrador();
                        Hide();
                        dialogAdmin.ShowDialog();
                        Close();
                        break;
                    }
                    
                default:
                    break;
            }
        }


    }
}
