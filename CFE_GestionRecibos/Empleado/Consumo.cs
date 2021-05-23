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
    public partial class Consumo : Form
    {
        ConsumoClass consumo;

        public Guid id_emp;
        public string username;

        List<ConsumoClass> massive;

        public Consumo()
        {
            InitializeComponent();
        }

        private bool validar()
        {
            if (tbx_medidor.TextLength == 0)
            {
                MessageBox.Show("Llene el campo medidor.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_medidor.Text))
            {
                MessageBox.Show("El medidor no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
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
            if (tbx_consumo.TextLength == 0)
            {
                MessageBox.Show("Capture el consumo del servicio.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!RegexUtilities.IsOnlyNumerics(tbx_consumo.Text))
            {
                MessageBox.Show("El consumo no debe contener letras.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            consumo = new ConsumoClass(
                Convert.ToInt32(tbx_año.Text),    
                Convert.ToSByte(cbx_mes.Text),
                Convert.ToInt64(tbx_medidor.Text),
                Convert.ToInt32(tbx_consumo.Text)
            );

            return true;
        }

        private void ReadCSV(string path)
        {
            string[] lines = null;
            try
            {
                lines = System.IO.File.ReadAllLines(path, Encoding.GetEncoding("iso-8859-1"));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al intentar leer el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            massive = new List<ConsumoClass>();
            bool first = true;
            int medI = 0, consI = 0, añoI = 0, mesI = 0;
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                if (first)
                {
                    medI = Array.FindIndex(columns, x => x.Contains("Medidor"));
                    consI = Array.FindIndex(columns, x => x.Contains("Consumo"));
                    añoI = Array.FindIndex(columns, x => x.Contains("Año"));
                    mesI = Array.FindIndex(columns, x => x.Contains("Mes"));
                    if (medI < 0 | consI < 0 | añoI < 0 | mesI < 0)
                    {
                        MessageBox.Show("Los datos del archivo no corresponden con los esperados. Asegurese de indicar cada dato en la primera fila del archivo.", "Archivo no compatible.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                    first = false;
                }
                else
                {
                    massive.Add(new ConsumoClass(
                        Convert.ToInt32(columns[añoI]),
                        Convert.ToSByte(columns[mesI]),
                        Convert.ToInt64(columns[medI]),
                        Convert.ToInt32(columns[consI])
                    ));
                }
            }
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
                if (link.AgregarConsumo(consumo, id_emp, username))
                {
                    MessageBox.Show("Consumo capturado.", "Información");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el consumo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                tbx_medidor.Text = "";
                tbx_año.Text = "";
                cbx_mes.SelectedIndex = -1;
                tbx_consumo.Text = "";
            }
        }

        private void btn_archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog csvFile = new OpenFileDialog();
            csvFile.InitialDirectory = "C:\\Users\\alexi\\Documents";
            csvFile.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            csvFile.FilterIndex = 0;
            csvFile.RestoreDirectory = true;
            if (csvFile.ShowDialog() == DialogResult.OK)
            {
                ReadCSV(csvFile.FileName);
                EnlaceCassandra link = new EnlaceCassandra();
                if (!link.ConsumoMasiva(massive, id_emp, username))
                {
                    MessageBox.Show("Ocurrió un error al cargar los consumos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Consumos registrados con éxito.", "Aviso");
                }
            }
        }
    }
}
