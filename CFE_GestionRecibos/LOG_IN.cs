using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CFE_GestionRecibos
{
    public partial class LOG_IN : Form
    {
        private byte tries = 0;
        private string mailused = "";
        private List<LogRem> rem_logins;

        private void FillRememberList(byte type)
        {
            EnlaceCassandra link = new EnlaceCassandra();
            rem_logins = link.GetRemembers(type);
            cbx_email.DisplayMember = "Correo_electronico";
            cbx_email.ValueMember = "Contrasena";
            cbx_email.DataSource = rem_logins;
            cbx_email.SelectedIndex = -1;
            tbx_password.Text = "";
            chb_rememberme.Checked = false;
        }

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
            if (cbx_email.Text.Length == 0)
            {
                MessageBox.Show("Capture el correo electrónico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (tbx_password.TextLength != 8)
            {
                MessageBox.Show("La constraseña debe contener 8 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            switch (cbx_usertype.SelectedIndex)
            {
                case 0: // Cliente
                    {
                        Login log = new Login();
                        log.correo_e = cbx_email.Text;
                        log.contra = tbx_password.Text;
                        EnlaceCassandra link = new EnlaceCassandra();
                        switch (link.LoginCliente(ref log))
                        {
                            case 0:
                                {
                                    if (chb_rememberme.Checked == true & cbx_email.SelectedIndex == -1)
                                    {
                                        link.RememberLogin(ref log, 0);
                                    }
                                    else if (chb_rememberme.Checked == false & cbx_email.SelectedIndex != -1)
                                    {
                                        link.DropLogin(ref log, 0);
                                    }
                                    Cliente.Cliente dialogCli = new Cliente.Cliente();
                                    dialogCli.username = log.username;
                                    dialogCli.id = log.id;
                                    Hide();
                                    dialogCli.ShowDialog();
                                    Close();
                                    break;
                                }
                            case 1:
                                MessageBox.Show("El correo electrónico no existe.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 2:
                                if (mailused == cbx_email.Text) tries++;
                                else tries = 0;
                                if (tries == 2)
                                {
                                    link.LockCliente(cbx_email.Text, true);
                                    MessageBox.Show("Se ha bloqueado el usuario por demasiados intentos fallidos.", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña incorrecta.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    mailused = cbx_email.Text;
                                }
                                break;
                            case 3:
                                MessageBox.Show("Usuario bloqueado.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                case 1: // Empleado
                    {
                        Login log = new Login();
                        log.correo_e = cbx_email.Text;
                        log.contra = tbx_password.Text;
                        EnlaceCassandra link = new EnlaceCassandra();
                        switch(link.Login_Empleado(ref log))
                        {
                            case 0:
                                {
                                    if (chb_rememberme.Checked == true & cbx_email.SelectedIndex == -1)
                                    {
                                        link.RememberLogin(ref log, 1);
                                    }
                                    else if (chb_rememberme.Checked == false & cbx_email.SelectedIndex != -1)
                                    {
                                        link.DropLogin(ref log, 1);
                                    }
                                    Empleado.Empleado dialogEmp = new Empleado.Empleado();
                                    dialogEmp.username = log.username;
                                    dialogEmp.id = log.id;
                                    Hide();
                                    dialogEmp.ShowDialog();
                                    Close();
                                    break;
                                }
                            case 1:
                                MessageBox.Show("El correo electrónico no existe.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 2:
                                if (mailused == cbx_email.Text) tries++;
                                else tries = 0;
                                if (tries == 2)
                                {
                                    MessageBox.Show("Se ha bloqueado el usuario por demasiados intentos fallidos.", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    link.LockEmpleado(cbx_email.Text, true);
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña incorrecta.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    mailused = cbx_email.Text;
                                }
                                break;
                            case 3:
                                MessageBox.Show("Usuario bloqueado.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                case 2: // Administrador
                    {
                        Login log = new Login();
                        log.correo_e = cbx_email.Text;
                        log.contra = tbx_password.Text;
                        EnlaceCassandra link = new EnlaceCassandra();
                        switch(link.Login_Admin(ref log))
                        {
                            case 0:
                                {
                                    if (chb_rememberme.Checked == true & cbx_email.SelectedIndex == -1)
                                    {
                                        link.RememberLogin(ref log, 2);
                                    }
                                    else if (chb_rememberme.Checked == false & cbx_email.SelectedIndex != -1)
                                    {
                                        link.DropLogin(ref log, 2);
                                    }
                                    Administrador.Administrador dialogAdmin = new Administrador.Administrador();
                                    dialogAdmin.username = log.username;
                                    dialogAdmin.id = log.id;
                                    Hide();
                                    dialogAdmin.ShowDialog();
                                    Close();
                                    break;
                                }
                            case 1:
                                MessageBox.Show("El correo electrónico no existe.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 2:
                                MessageBox.Show("Contraseña incorrecta.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            FillRememberList((byte)cbx_usertype.SelectedIndex);
        }

        private void cbx_email_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_email.SelectedIndex != -1)
            {
                chb_rememberme.Checked = true;
                tbx_password.Text = cbx_email.SelectedValue.ToString();
            }
        }

        private void cbx_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                chb_rememberme.Checked = false;
                cbx_email.SelectedIndex = -1;
                tbx_password.Text = "";
            }
        }
    }
}