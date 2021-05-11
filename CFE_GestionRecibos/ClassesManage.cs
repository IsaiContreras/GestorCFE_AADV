using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;

namespace CFE_GestionRecibos
{
    public class AdminClass
    {
        public Guid id_adm;
        public string nom;
    }

    public class LogAdmin
    {
        public string correo_e;
        public string contra;
        public Guid id_adm;
        public string username;
    }

    public class EmpleadoClass
    {
        public Guid id_admin;
        public string nom;
        public string ape;
        public DateTime fec_nac;
        public string rfc;
        public string curp;
        public List<string> tel;
        public string correo_e;
        public string contra;
        public bool activo;
    }

    public class LogEmpleado
    {
        public string correo_e;
        public string contra;
        public Guid num_emp;
        public string username;
    }

    public class ClienteClass
    {
        public Guid id_cl;
        public string nombres;
        public string apellidos;
        public DateTime fec_nac;
        public string domicilio;
        public List<string> telefonos;
        public string correo_e;
        public string contra;
        public bool activo;
    }

    public class LogCliente
    {
        public string correo_e;
        public string contra;
        public Guid id_cl;
        public string username;
    }

    public class ServicioClass
    {
        public Guid id_cl;
        public Guid id_ser;
        public long medidor;
        public bool tipo_ser;
        public string domicilio;
        public bool activo;
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
}
