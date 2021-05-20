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
    public partial class AgregarServicio : Form
    {
        public Guid id_client;
        public string username = "Default Costumer";

        public Guid id_serv;
        ServicioClass serv;
        ServicioClass servMod;

        public Guid num_emp;
        public string empUsername;

        public AgregarServicio()
        {
            InitializeComponent();
        }

        private bool validar()
        {
            if (tbx_medidor.TextLength == 0)
            {
                MessageBox.Show("Llene el medidor.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_medidor.Text))
            {
                MessageBox.Show("El medidor no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_calle.TextLength == 0) { 

                MessageBox.Show("Llene la calle de su domicilio.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_numext.TextLength == 0)
            {
                MessageBox.Show("Llene el número externo.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_numext.Text))
            {
                MessageBox.Show("El número externo no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

            serv = new ServicioClass(
                id_client,
                username,
                num_emp,
                empUsername,
                Convert.ToInt64(tbx_medidor.Text),
                new Domicilio(tbx_calle.Text, tbx_numext.Text, tbx_numint.Text, tbx_col.Text, tbx_estado.Text, tbx_munic.Text, tbx_cp.Text),
                Convert.ToBoolean(cbx_servicio.SelectedIndex)
            );

            return true;
        }

        private void llenarInfo()
        {
            EnlaceCassandra link = new EnlaceCassandra();
            servMod = link.DatosServicio(id_client, id_serv);
            servMod.split_domic();

            tbx_medidor.Text = Convert.ToString(servMod.medidor);
            tbx_calle.Text = servMod.domic.calle;
            tbx_numext.Text = servMod.domic.numext;
            tbx_numint.Text = servMod.domic.numint;
            tbx_col.Text = servMod.domic.col;
            tbx_munic.Text = servMod.domic.munic;
            tbx_estado.Text = servMod.domic.estado;
            tbx_cp.Text = servMod.domic.cp;
            cbx_servicio.SelectedIndex = Convert.ToInt32(servMod.tipo_serv);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(Text == "Modificar servicio")
            {
                if (validar())
                {
                    EnlaceCassandra link = new EnlaceCassandra();
                    if (link.ModificarServicio(serv, servMod))
                    {
                        MessageBox.Show("Servicio modificado con éxito.", "Aviso");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el servicio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                }
            }
            else
            {
                if (validar())
                {
                    EnlaceCassandra link = new EnlaceCassandra();
                    if (link.AgregarServicio(serv))
                    {
                        MessageBox.Show("Servicio registrado con éxito.", "Información");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el servicio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                    
                }
            }
        }

        private void AgregarServicio_Load(object sender, EventArgs e)
        {
            if(Text == "Modificar servicio")
            {
                llenarInfo();
                btn_ok.Text = "Aceptar";
            }
            st_identity.Text = "ID: " + id_client.ToString();
            st_username.Text = "Usuario: " + username;
            cbx_servicio.SelectedIndex = 0;
        }
    }
}
