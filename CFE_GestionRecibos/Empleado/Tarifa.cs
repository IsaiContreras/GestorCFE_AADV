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
    public partial class Tarifa : Form
    {
        TarifaClass tarifa;

        public Guid id_emp;
        public string username;

        List<TarifaClass> massive;

        public Tarifa()
        {
            InitializeComponent();
        }

        private bool validar()
        {
            if (tbx_año.TextLength == 0)
            {
                MessageBox.Show("Escriba el año del periodo de facturación.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_año.Text))
            {
                MessageBox.Show("El año no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (cbx_mes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el mes del periodo de facturación.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_tarbas.TextLength == 0)
            {
                MessageBox.Show("Capture la tarifa básica.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsDecimalNumber(tbx_tarbas.Text))
            {
                MessageBox.Show("La tarifa básica no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_tarint.TextLength == 0)
            {
                MessageBox.Show("Capture la tarifa intermedia.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsDecimalNumber(tbx_tarint.Text))
            {
                MessageBox.Show("La tarifa intermedia no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (tbx_tarexc.TextLength == 0)
            {
                MessageBox.Show("Capture la tarifa excedente.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsDecimalNumber(tbx_tarexc.Text))
            {
                MessageBox.Show("La tarifa excedente no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            tarifa = new TarifaClass(
                Convert.ToInt32(tbx_año.Text),
                Convert.ToSByte(cbx_mes.Text),
                Convert.ToBoolean(cbx_tiposerv.SelectedIndex),
                Convert.ToDecimal(tbx_tarbas.Text),
                Convert.ToDecimal(tbx_tarint.Text),
                Convert.ToDecimal(tbx_tarexc.Text)
            );

            return true;
        }

        private void ReadCSV(string path) {
            string[] lines = null;
            try {
                 lines = System.IO.File.ReadAllLines(path, Encoding.GetEncoding("iso-8859-1"));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al intentar leer archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            massive = new List<TarifaClass>();
            bool first = true;
            int servI = 0, añoI = 0, mesI = 0, pBI = 0, pII = 0, pEI = 0;
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                if (first)
                {
                    servI = Array.FindIndex(columns, x => x.Contains("Servicio"));
                    añoI = Array.FindIndex(columns, x => x.Contains("Año"));
                    mesI = Array.FindIndex(columns, x => x.Contains("Mes"));
                    pBI = Array.FindIndex(columns, x => x.Contains("Básico"));
                    pII = Array.FindIndex(columns, x => x.Contains("Intermedio"));
                    pEI = Array.FindIndex(columns, x => x.Contains("Excedente"));
                    first = false;
                    if (servI < 0 | añoI < 0 | mesI < 0 | pBI < 0 | pII < 0 | pEI < 0)
                    {
                        MessageBox.Show("Los datos del archivo no corresponden con los esperados. Asegurese de indicar cada dato en la primera fila del archivo.", "Archivo no compatible.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                else
                {
                    bool type = false;
                    if (columns[servI].Contains("Doméstico")) type = false;
                    else type = true;
                    massive.Add(new TarifaClass(
                        Convert.ToInt32(columns[añoI]),
                        Convert.ToSByte(columns[mesI]),
                        type,
                        Convert.ToDecimal(columns[pBI]),
                        Convert.ToDecimal(columns[pII]),
                        Convert.ToDecimal(columns[pEI])
                    ));
                }
            }
        }

        private void Tarifa_Load(object sender, EventArgs e)
        {
            cbx_tiposerv.SelectedIndex = 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                EnlaceCassandra link = new EnlaceCassandra();
                if (link.AgregarTarifa(tarifa, id_emp, username))
                {
                    MessageBox.Show("Tarifa capturada.", "Información");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la tarifa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                tbx_año.Text = "";
                cbx_mes.SelectedIndex = -1;
                tbx_tarbas.Text = "";
                tbx_tarint.Text = "";
                tbx_tarexc.Text = "";
            }
        }

        private void btn_archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog csvFile = new OpenFileDialog();
            csvFile.InitialDirectory = "C:\\Users\\alexi\\Documents";
            csvFile.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            csvFile.FilterIndex = 1;
            csvFile.RestoreDirectory = true;
            if (csvFile.ShowDialog() == DialogResult.OK)
            {
                ReadCSV(csvFile.FileName);
                EnlaceCassandra link = new EnlaceCassandra();
                if (!link.TarifaMasiva(massive, id_emp, username))
                {
                    MessageBox.Show("Ocurrió un error al cargar las tarifas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Tarifas registradas con éxito.", "Aviso");
                }
            }
        }
    }
}
