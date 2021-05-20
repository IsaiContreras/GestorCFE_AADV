using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Cassandra;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CFE_GestionRecibos
{
    public class Login
    {
        public string correo_e;
        public string contra;
        public Guid id;
        public string username;
    }

    public class LogRem
    {
        public byte Tipo_user { get; set; }
        public string Correo_electronico { get; set; }
        public string Contrasena { get; set; }
    }

    public class AdminClass
    {
        public Guid id_adm;
        public string nom;
    }

    public class EmpleadoClass
    {
        public EmpleadoClass()
        {

        }
        public EmpleadoClass(string nombres, string apellidos, LocalDate fechaNac, string rfc, string curp, string email, string password)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            fecha_nac = fechaNac;
            this.rfc = rfc;
            this.curp = curp;
            correo_electronico = email;
            contrasena = password;
        }
        public Guid num_empleado { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public LocalDate fecha_nac { get; set; }
        public string curp { get; set; }
        public string rfc { get; set; }
        public List<string> telefonos { get; set; }
        public string correo_electronico { get; set; }
        public string contrasena { get; set; }
    }

    public class EmpleadoList
    {
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string rfc {get; set;}
        public Guid num_empleado { get; set; }
    }

    public class ClienteClass
    {
        public ClienteClass() {

        }
        public ClienteClass(Guid numemp, string empUser, string nombres, string apellidos, LocalDate fecNac, Domicilio domic, string curp, string email, string password)
        {
            id_emp = numemp;
            this.nombres = nombres;
            this.apellidos = apellidos;
            fecha_nac = fecNac;
            this.domic = domic;
            this.curp = curp;
            correo_electronico = email;
            contrasena = password;
            empUsername = empUser;
        }
        public void split_domic()
        {
            domic = new Domicilio(domicilio);
        }
        public Guid id_cliente;
        public string nombres;
        public string apellidos;
        public LocalDate fecha_nac;
        public string domicilio;
        public string curp;
        public List<string> telefonos;
        public string correo_electronico;
        public string contrasena;
        public Domicilio domic;
        public Guid id_emp;
        public string empUsername;
    }

    public class ClientList
    {
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string curp { get; set; }
        public string correo_electronico { get; set; }
        public Guid id_cliente { get; set; }
    }
    
    public class ServicioClass
    {
        public ServicioClass()
        {

        }
        public ServicioClass(Guid id_cl , string cliUser, Guid numemp, string empUser, long medidor, Domicilio domic, bool tipo)
        {
            id_cliente = id_cl;
            cliUsername = cliUser;
            id_emp = numemp;
            empUsername = empUser;
            this.medidor = medidor;
            this.domic = domic;
            tipo_serv = tipo;
            empUsername = empUser;
        }
        public void split_domic()
        {
            domic = new Domicilio(domicilio);
        }
        public Guid id_cliente;
        public Guid id_serv;
        public long medidor;
        public bool tipo_serv;
        public string domicilio;
        public Guid id_emp;
        public string empUsername;
        public string cliUsername;
        public Domicilio domic;
    }

    public class ServicioList
    {
        public long medidor { get; set; }
        public bool tipo_serv { get; set; }
        public string domicilio { get; set; }
        public Guid id_serv { get; set; }
    }

    public class ReciboClass
    {
        public ReciboClass()
        {

        }
        public void get_domic_parts()
        {
            domic = new Domicilio(domicilio);
        }
        public Guid id_ser;
        public Guid id_rec;
        public int year;
        public sbyte month;
        public bool tipo_ser;
        public long medidor;
        public string domicilio;
        public LocalDate fec_venc;
        public int consumo_basico;
        public int consumo_intermedio;
        public int consumo_excedente;
        public int consumo_total;
        public decimal precio_basico;
        public decimal precio_intermedio;
        public decimal precio_excedente;
        public decimal precio_total;
        public decimal cargo_iva;
        public decimal pago_total;
        public decimal importe_pago;
        public decimal pendiente_pago;
        public decimal prev_pendiente;
        public bool pagado;
        public Domicilio domic;
    }

    public class Telefono_cl
    {
        public Guid id;
        public string telefono;
        public long id_cl;
    }

    public class Telefono_emp
    {
        public Guid id;
        public string telefono;
        public long id_cl;
    }

    public class TarifaClass
    {
        public TarifaClass()
        {

        }
        public TarifaClass(int año, sbyte mes, bool tipo, decimal tar_b, decimal tar_i, decimal tar_e)
        {
            year = año;
            month = mes;
            tipo_serv = tipo;
            tar_basica = tar_b;
            tar_intermedia = tar_i;
            tar_excedente = tar_e;
        }
        public int year { get; set; }
        public sbyte month { get; set; }
        public bool tipo_serv { get; set; }
        public decimal tar_basica { get; set; }
        public decimal tar_intermedia { get; set; }
        public decimal tar_excedente { get; set; }
    }

    public class ConsumoClass
    {
        public ConsumoClass()
        {

        }
        public ConsumoClass(int año, sbyte mes, long med, int kw_tot)
        {
            year = año;
            month = mes;
            medidor = med;
            kw_totales = kw_tot;

            get_cons_parts();
        }
        private void get_cons_parts()
        {
            int kW_b = Convert.ToInt32(ConfigurationManager.AppSettings["kW_Basico"].ToString());
            int kW_i = Convert.ToInt32(ConfigurationManager.AppSettings["kW_Inter"].ToString());
            int kW_t = kw_totales;
            int kW_bas = 0, kW_inter = 0, kW_exced = 0;
            if (kw_totales > kW_b)
            {
                kW_t -= kW_b;
                kW_bas = kW_b;
                if (kw_totales > kW_i + kW_b)
                {
                    kW_t -= kW_i;
                    kW_inter = kW_i;
                    kW_exced = kW_t;
                }
                else
                {
                    kW_inter = kW_t;
                }
            }
            else
            {
                kW_bas = kW_t;
            }
            kw_basica = kW_bas;
            kw_intermedia = kW_inter;
            kw_excedente = kW_exced;
        }
        public int year { get; set; }
        public sbyte month { get; set; }
        public long medidor { get; set; }
        public bool tipo_serv { get; set; }
        public int kw_totales { get; set; }
        public int kw_basica { get; set; }
        public int kw_intermedia { get; set; }
        public int kw_excedente { get; set; }
    }

    public class ConsumoHist
    {
        public ConsumoHist()
        {

        }
        public int year { get; set; }
        public sbyte month { get; set; }
        public long medidor { get; set; }
        public int consumo_kw { get; set; }
        public decimal pago_total { get; set; }
        public decimal importe_pago { get; set; }
        public decimal pendiente_pago { get; set; }
    }

    public class Domicilio
    {
        public Domicilio()
        {

        }
        public Domicilio(string dom)
        {
            string[] parts = dom.Split(',');
            if (parts.Length == 7)
            {
                calle = parts[0];
                numext = parts[1];
                numint = parts[2];
                col = parts[3];
                munic = parts[4];
                estado = parts[5];
                cp = parts[6];
            }
        }
        public Domicilio(string calle, string numext, string numint, string col, string munic, string estado, string cp)
        {
            this.calle = calle;
            this.numext = numext;
            this.numint = numint;
            this.col = col;
            this.munic = munic;
            this.estado = estado;
            this.cp = cp;
        }
        public string calle { get; set; }
        public string numext { get; set; }
        public string numint { get; set; }
        public string col { get; set; }
        public string munic { get; set; }
        public string estado { get; set; }
        public string cp { get; set; }
        public string getAssembled()
        {
            return calle + ',' + numext + ',' + numint + ',' + col + ',' + munic + ',' + estado + ',' + cp;
        }
        public string getFormat()
        {
            string numinterstr = "";
            if (numint.Length > 0)
            {
                numinterstr = ", #" + numint;
            }
            return calle + " #" + numext + numinterstr + ", Col. " + col + ", " + munic + ", " + estado + ". " + cp;
        }
    }

    class RegexUtilities
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        public static bool IsDecimalNumber(string text)
        {
            Regex r = new Regex(@"^\d+\.?\d*$");
            if (r.IsMatch(text))
                return true;
            else
                return false;
        }
        public static bool IsOnlyNumerics(string text)
        {
            Regex r = new Regex("^[0-9]+$");
            if (r.IsMatch(text))
                return true;
            else
                return false;
        }
        public static bool IsOnlyAlphas(string text)
        {
            Regex r = new Regex("^[a-zA-Z]+$");
            if (r.IsMatch(text))
                return true;
            else
                return false;
        }
    }
}
