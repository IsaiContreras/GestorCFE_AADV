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
        byte tries = 0;
        string mailused = "";

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
                        LogCliente log = new LogCliente();
                        log.correo_e = cbx_email.Text;
                        log.contra = tbx_password.Text;
                        EnlaceCassandra link = new EnlaceCassandra();
                        switch (link.LoginCliente(ref log))
                        {
                            case 0:
                                {
                                    Cliente.Cliente dialogCli = new Cliente.Cliente();
                                    dialogCli.username = log.username;
                                    dialogCli.id = log.id_cl;
                                    Hide();
                                    dialogCli.ShowDialog();
                                    Close();
                                    break;
                                }
                            case 1:
                                MessageBox.Show("El correo electrónico no existe.", "Dato globito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 2:
                                if (mailused == cbx_email.Text) tries++;
                                else tries = 0;
                                if (tries == 2)
                                {
                                    link.LockCliente(cbx_email.Text, true);
                                    MessageBox.Show("Se ha bloqueado el usuario por demasiados intentos fallidos.", "Dato globito.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña incorrecta.", "Dato globito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    mailused = cbx_email.Text;
                                }
                                break;
                            case 3:
                                MessageBox.Show("Usuario bloqueado.", "Dato globito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                case 1:
                    {
                        // Empleado
                        LogEmpleado log = new LogEmpleado();
                        log.correo_e = cbx_email.Text;
                        log.contra = tbx_password.Text;
                        EnlaceCassandra link = new EnlaceCassandra();
                        switch(link.Login_Empleado(ref log))
                        {
                            case 0:
                                {
                                    Empleado.Empleado dialogEmp = new Empleado.Empleado();
                                    dialogEmp.username = log.username;
                                    dialogEmp.id = log.num_emp;
                                    Hide();
                                    dialogEmp.ShowDialog();
                                    Close();
                                    break;
                                }
                            case 1:
                                MessageBox.Show("El correo electrónico no existe.", "Dato globito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 2:
                                if (mailused == cbx_email.Text) tries++;
                                else tries = 0;
                                if (tries == 3)
                                {
                                    MessageBox.Show("Se ha bloqueado el usuario por demasiados intentos fallidos.", "Dato globito.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    link.LockEmpleado(cbx_email.Text, true);
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña incorrecta.", "Dato globito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    mailused = cbx_email.Text;
                                }
                                break;
                            case 3:
                                MessageBox.Show("Usuario bloqueado.", "Dato globito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                case 2:
                    {
                        // Administrador
                        LogAdmin log = new LogAdmin();
                        log.correo_e = cbx_email.Text;
                        log.contra = tbx_password.Text;

                        EnlaceCassandra link = new EnlaceCassandra();
                        switch(link.Login_Admin(ref log))
                        {
                            case 0:
                                {
                                    Administrador.Administrador dialogAdmin = new Administrador.Administrador();
                                    dialogAdmin.username = log.username;
                                    dialogAdmin.id = log.id_adm;
                                    Hide();
                                    dialogAdmin.ShowDialog();
                                    Close();
                                    break;
                                }
                            case 1:
                                MessageBox.Show("El correo electrónico no existe.", "Dato globito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 2:
                                MessageBox.Show("Contraseña incorrecta.", "Dato globito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 3:
                                MessageBox.Show("Usuario bloqueado.", "Dato globito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        private void cbx_usertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_email.Text = "";
            tbx_password.Text = "";
        }
    }
}
