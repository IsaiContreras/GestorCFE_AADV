using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using System.Windows.Forms;

namespace CFE_GestionRecibos.Administrador
{
    public partial class Agregar : Form
    {
        EmpleadoClass emp;

        EmpleadoClass empMod;
        public Guid id_emp;

        List<string> telef = new List<string>();

        public Agregar()
        {
            InitializeComponent();
        }

        private bool validar()
        {
            if (tbx_nombres.TextLength == 0)
            {
                MessageBox.Show("Llene el campo Nombres.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyAlphas(tbx_nombres.Text))
            {
                MessageBox.Show("El nombre no debe contener caracteres numéricos.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_apellidos.TextLength == 0)
            {
                MessageBox.Show("Llene el campo Apellidos.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyAlphas(tbx_apellidos.Text))
            {
                MessageBox.Show("El apellido no debe contener caracteres numéricos.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (cbx_mesnac.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione su mes de nacimiento.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (cbx_dianac.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione su día de nacimiento." , "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_añonac.TextLength == 0)
            {
                MessageBox.Show("Escriba su año de nacimiento.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            DateTime dt;
            if (!DateTime.TryParse(string.Format("{0}-{1}-{2}", Convert.ToInt32(tbx_añonac.Text), Convert.ToInt32(cbx_mesnac.Text), Convert.ToInt32(cbx_dianac.Text)), out dt))
            {
                MessageBox.Show("La fecha ingresada no es válida.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_añonac.Text))
            {
                MessageBox.Show("El año no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_curp.TextLength != 18)
            {
                MessageBox.Show("El CURP debe contener 18 caracteres.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_rfc.TextLength > 0 & tbx_rfc.TextLength != 13)
            {
                MessageBox.Show("El RFC debe contener 13 caracteres.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (!RegexUtilities.IsValidEmail(tbx_email.Text))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_password.TextLength != 8)
            {
                MessageBox.Show("La contraseña debe contener 8 caracteres.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            
            emp = new EmpleadoClass(
                tbx_nombres.Text,
                tbx_apellidos.Text,
                new LocalDate(dt.Year, dt.Month, dt.Day),
                tbx_rfc.Text,
                tbx_curp.Text,
                telef,
                tbx_email.Text,
                tbx_password.Text
            );

            return true;
        }

        private void llenarInfo()
        {
            EnlaceCassandra link = new EnlaceCassandra();
            empMod = link.DatosEmpleado(id_emp);

            tbx_nombres.Text = empMod.nombres;
            tbx_apellidos.Text = empMod.apellidos;
            cbx_mesnac.SelectedIndex = empMod.fecha_nac.Month - 1;
            cbx_dianac.SelectedIndex = empMod.fecha_nac.Day - 1;
            tbx_añonac.Text = Convert.ToString(empMod.fecha_nac.Year);
            tbx_curp.Text = empMod.curp;
            tbx_rfc.Text = empMod.rfc;
            tbx_email.Text = empMod.correo_electronico;
            tbx_password.Text = empMod.contrasena;
            lbx_telefonos.DataSource = empMod.telefonos;
            telef = empMod.telefonos;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (Text == "Editar empleado")
            {
                // EDITAR Empleado
                if (validar())
                {
                    // ALTA
                    EnlaceCassandra link = new EnlaceCassandra();
                    if (link.ModificarEmpleado(emp, empMod))
                    {
                        MessageBox.Show("Empleado modificado con éxito.", "Aviso");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el empleado. Quizá el correo electrónico ya esté usado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                }
            }
            else
            {
                // ALTA Empleado
                if (validar())
                {
                    // ALTA
                    EnlaceCassandra link = new EnlaceCassandra();
                    if (link.AgregarEmpleado(emp))
                    {
                        MessageBox.Show("Empleado agregado con éxito.", "Aviso");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el empleado. Quizá el correo electrónico ya esté usado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                }
            }
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            if (Text == "Editar empleado")
            {
                llenarInfo();
                btn_ok.Text = "Aceptar";
            }
        }

        private void btn_addtel_Click(object sender, EventArgs e)
        {
            if (tbx_telefono.TextLength == 0)
            {
                MessageBox.Show("Capture el teléfono en el recuadro.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (!RegexUtilities.IsOnlyNumerics(tbx_telefono.Text))
            {
                MessageBox.Show("El teléfono no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            telef.Add(tbx_telefono.Text);
            lbx_telefonos.DataSource = null;
            lbx_telefonos.DataSource = telef;
            tbx_telefono.Text = "";
        }

        private void btn_deltel_Click(object sender, EventArgs e)
        {
            //QUITA TELEFONO
            telef.Remove((string)lbx_telefonos.SelectedItem);
            if (telef.Count > 0)
            {
                lbx_telefonos.DataSource = null;
                lbx_telefonos.DataSource = telef;
            } 
            else lbx_telefonos.DataSource = null;
        }
    }
}
