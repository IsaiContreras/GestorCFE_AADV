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

namespace CFE_GestionRecibos.Empleado
{
    public partial class AgregarCliente : Form
    {
        public Guid id_client;
        ClienteClass client;
        ClienteClass clientMod;

        public Guid id_emp;
        public string empUsername;

        private List<string> telef = new List<string>();

        public AgregarCliente()
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
                MessageBox.Show("El nombre no debe contener caracteres numéricos.", "Información inválida.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_apellidos.TextLength == 0)
            {
                MessageBox.Show("Llene el campo Apellidos.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyAlphas(tbx_apellidos.Text))
            {
                MessageBox.Show("El apellido no debe contener caracteres numéricos.", "Información inválida.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (cbx_mesnac.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione su mes de nacimiento.", "Información incompleta.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (cbx_dianac.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione su día de nacimiento.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_añonac.TextLength == 0)
            {
                MessageBox.Show("Escriba su año de nacimiento.", "Información incompleta.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            if (tbx_calle.TextLength == 0)
            {
                MessageBox.Show("Capture la calle de su domicilio.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_numext.TextLength == 0)
            {
                MessageBox.Show("Llene el número externo.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_numext.Text))
            {
                MessageBox.Show("El número externo contiene letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_col.TextLength == 0)
            {
                MessageBox.Show("Llene la colonia de su domicilio.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_estado.TextLength == 0)
            {
                MessageBox.Show("Llene el estado de su domicilio.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_munic.TextLength == 0)
            {
                MessageBox.Show("Llene el municipio de su domicilio.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_cp.TextLength == 0)
            {
                MessageBox.Show("Llene el código postal de su domicilio.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_cp.Text))
            {
                MessageBox.Show("El código postal no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_curp.TextLength != 18)
            {
                MessageBox.Show("El CURP debe contener 18 caracteres.", "Información incompleta.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (!RegexUtilities.IsValidEmail(tbx_email.Text))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Información inválida.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_password.TextLength != 8)
            {
                MessageBox.Show("La contraseña debe contener 8 caracteres.", "Información incompleta.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            client = new ClienteClass(
                id_emp,
                empUsername,
                tbx_nombres.Text,
                tbx_apellidos.Text,
                new LocalDate(dt.Year, dt.Month,dt.Day),
                new Domicilio(tbx_calle.Text, tbx_numext.Text, tbx_numint.Text, tbx_col.Text, tbx_munic.Text, tbx_estado.Text, tbx_cp.Text),
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
            clientMod = link.DatosCliente(id_client);
            clientMod.split_domic();

            tbx_nombres.Text = clientMod.nombres;
            tbx_apellidos.Text = clientMod.apellidos;
            cbx_mesnac.SelectedIndex = clientMod.fecha_nac.Month - 1;
            cbx_dianac.SelectedIndex = clientMod.fecha_nac.Day - 1;
            tbx_añonac.Text = Convert.ToString(clientMod.fecha_nac.Year);
            tbx_calle.Text = clientMod.domic.calle;
            tbx_numext.Text = clientMod.domic.numext;
            tbx_numint.Text = clientMod.domic.numint;
            tbx_col.Text = clientMod.domic.col;
            tbx_munic.Text = clientMod.domic.munic;
            tbx_estado.Text = clientMod.domic.estado;
            tbx_cp.Text = clientMod.domic.cp;
            tbx_curp.Text = clientMod.curp;
            lbx_telefonos.DataSource = clientMod.telefonos;
            telef = clientMod.telefonos;
            tbx_email.Text = clientMod.correo_electronico;
            tbx_password.Text = clientMod.contrasena;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(Text == "Modificar cliente")
            {
                // MODIFICACIÓN Cliente
                if (validar())
                {
                    // ALTA
                    EnlaceCassandra link = new EnlaceCassandra();
                    if (link.ModificarCliente(client, clientMod))
                    {
                        MessageBox.Show("Cliente modificado con éxito.", "Aviso");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el cliente. Quizá el correo electrónico ya esté usado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                }
            }
            else
            {
                // ALTA Cliente
                if (validar())
                {
                    // ALTA
                    EnlaceCassandra link = new EnlaceCassandra();
                    if (link.AgregarCliente(client))
                    {
                        MessageBox.Show("Cliente registrado con éxito.", "Información");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el cliente. Quizá el correo electrónico ya esté usado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                }
            }
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            if(Text == "Modificar cliente")
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
