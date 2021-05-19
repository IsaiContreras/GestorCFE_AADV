using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Guid id_servicio;
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

    public class RecibosClass
    {
        public Guid id_ser;
        public Guid id_rec;
        public string nombre_cl;
        public int year;
        public byte month;
        public string domicilio_cl;
        public bool tipo_ser;
        public long medidor;
        public DateTime fec_venc;
        public string domicilio;
        public bool pagado;
        public double pago_total;
        public double cargo_iva;
        public double precio_bas;
        public double precio_inter;
        public double precio_exced;
        public double importe_pago;
        public double pendiente_pago;
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
