using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace CFE_GestionRecibos
{
    public class EnlaceCassandra
    {
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _session;

        private static void conectar()
        {
            _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();

            _cluster = Cluster.Builder()
                .AddContactPoint(_dbServer)
                .Build();

            _session = _cluster.Connect(_dbKeySpace);
        }

        private static void conectar2()
        {
            _cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1")
                .Build();

            _session = _cluster.Connect("keyspace3");
        }

        private static void desconectar()
        {
            _cluster.Dispose();
        }

        // LOG_IN
        public byte Login_Admin(ref Login param)
        {
            try
            {
                conectar();
                bool found = false;
                string qry = "select count(*) from Log_Administrador where Correo_electronico = '{0}';";
                string format = string.Format(qry, param.correo_e);
                var res = _session.Execute(format);
                foreach (var row in res)
                {
                    long result = row.GetValue<long>("count");
                    if (result == 1)
                    {
                        qry = "select ID_Admin, Nombre_usuario from Log_Administrador where Correo_electronico = '{0}' and Contrasena = '{1}';";
                        format = string.Format(qry, param.correo_e, param.contra);
                        res = _session.Execute(format);
                        foreach (var row2 in res)
                        {
                            found = true;
                            param.id = row2.GetValue<Guid>("id_admin");
                            param.username = row2.GetValue<string>("nombre_usuario");
                        }
                        if (!found) return 2;
                    }
                    else return 1;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                return 10;
            }
            finally
            {
                desconectar();
            }
            return 0;
        }
        public byte Login_Empleado(ref Login param)
        {
            try
            {
                conectar();
                string qry = "select count(*) from Log_Empleado where Correo_electronico = '{0}';";
                string format = string.Format(qry, param.correo_e);
                var res = _session.Execute(format);
                foreach (var row in res)
                {
                    long result = row.GetValue<long>("count");
                    if (result == 1)
                    {
                        qry = "select Bloqueo from Log_Empleado where Correo_electronico = '{0}'";
                        format = string.Format(qry, param.correo_e);
                        res = _session.Execute(format);
                        foreach (var row1 in res)
                        {
                            bool bloqueo = row1.GetValue<bool>("bloqueo");
                            if (!bloqueo)
                            {
                                bool found = false;
                                qry = "select NUM_Empleado, Nombre_usuario from Log_Empleado where Correo_electronico = '{0}' and Contrasena = '{1}';";
                                format = string.Format(qry, param.correo_e, param.contra);
                                res = _session.Execute(format);
                                foreach (var row2 in res)
                                {
                                    found = true;
                                    param.id = row2.GetValue<Guid>("num_empleado");
                                    param.username = row2.GetValue<string>("nombre_usuario");
                                }
                                if (!found) return 2;
                            }
                            else return 3;
                        }
                    }
                    else return 1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 10;
            }
            finally
            {
                desconectar();
            }
            return 0;
        }
        public byte LoginCliente(ref Login param)
        {
            try
            {
                conectar();
                string qry = "select count(*) from Log_Cliente where Correo_electronico = '{0}';";
                string format = string.Format(qry, param.correo_e);
                var res = _session.Execute(format);
                foreach (var row in res)
                {
                    long result = row.GetValue<long>("count");
                    if (result == 1)
                    {
                        qry = "select Bloqueo from Log_Cliente where Correo_electronico = '{0}'";
                        format = string.Format(qry, param.correo_e);
                        res = _session.Execute(format);
                        foreach (var row1 in res)
                        {
                            bool bloqueo = row1.GetValue<bool>("bloqueo");
                            if (!bloqueo)
                            {
                                bool found = false;
                                qry = "select ID_Cliente, Nombre_usuario from Log_Cliente where Correo_electronico = '{0}' and Contrasena = '{1}';";
                                format = string.Format(qry, param.correo_e, param.contra);
                                res = _session.Execute(format);
                                foreach (var row2 in res)
                                {
                                    found = true;
                                    param.id = row2.GetValue<Guid>("id_cliente");
                                    param.username = row2.GetValue<string>("nombre_usuario");
                                }
                                if (!found) return 2;
                            }
                            else return 3;
                        }
                    }
                    else return 1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 10;
            }
            finally
            {
                desconectar();
            }
            return 0;
        }
        public bool LockEmpleado(string correo, bool locker)
        {
            try
            {
                conectar();
                string qry = "update Log_Empleado set Bloqueo = {0} where Correo_electronico = '{1}';";
                string format = string.Format(qry, locker, correo);
                _session.Execute(format);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
            return true;
        }
        public bool LockCliente(string correo, bool locker)
        {
            try
            {
                conectar();
                string qry = "update Log_Cliente set Bloqueo = {0} where Correo_electronico = '{1}';";
                string format = string.Format(qry, locker, correo);
                _session.Execute(format);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
            return true;
        }
        public List<LogRem> GetRemembers(byte mode)
        {
            try
            {
                string qry = "select Correo_electronico, Contrasena from Recordar_contra where Tipo_user = {0} allow filtering;";
                string format = string.Format(qry, mode);
                conectar();
                IMapper mapper = new Mapper(_session);
                IEnumerable <LogRem> rem = mapper.Fetch<LogRem>(format);
                return rem.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public bool RememberLogin(ref Login param, byte type)
        {
            try
            {
                conectar();
                string qry = "select count(*) from Recordar_contra where Tipo_user = {0} and Correo_electronico = '{1}';";
                string format = string.Format(qry, type, param.correo_e);
                var rs = _session.Execute(format);
                foreach (var row in rs)
                {
                    long count = row.GetValue<long>("count");
                    if (count == 0)
                    {
                        qry = "insert into Recordar_contra (Tipo_user, Correo_electronico, Contrasena) values ({0}, '{1}', '{2}')";
                        format = string.Format(qry, type, param.correo_e, param.contra);
                        _session.Execute(format);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
            return true;
        }
        public bool DropLogin (ref Login param, byte type)
        {
            try
            {
                conectar();
                string qry = "delete from Recordar_contra where Tipo_user = {0} and Correo_electronico = '{1}'";
                string format = string.Format(qry, type, param.correo_e);
                _session.Execute(format);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
            return true;
        }

        // ADMINISTRADOR
        public List<EmpleadoList> LlenarEmpleados()
        {
            try
            {
                string qry = "select Nombres, Apellidos, RFC, NUM_Empleado from Empleado where Activo = true allow filtering;";
                conectar();
                IMapper mapper = new Mapper(_session);
                IEnumerable<EmpleadoList> lista = mapper.Fetch<EmpleadoList>(qry);

                return lista.ToList();
            }
            catch(Exception e){
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public EmpleadoClass DatosEmpleado(Guid id)
        {
            try
            {
                string qry = "select NUM_Empleado, Nombres, Apellidos, Fecha_nac, RFC, CURP, Telefonos, Correo_electronico, Contrasena from Empleado where NUM_Empleado = ?; ";
                conectar();
                IMapper mapper = new Mapper(_session);
                EmpleadoClass user = mapper.Single<EmpleadoClass>(qry, id);                return user;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public List<RegistroActList> LlenarRegistroAct(Guid id_emp)
        {
            try
            {
                string qry = "select Fecha_reg, Accion, CLAVE from Registro_actividad where NUM_Empleado = ? allow filtering;";
                conectar();
                IMapper mapper = new Mapper(_session);
                IEnumerable<RegistroActList> lista = mapper.Fetch<RegistroActList>(qry, id_emp);

                return lista.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public RegistroActClass DatosRegistroAct(Guid id_emp, Guid clave)
        {
            try
            {
                string qry = "select NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion from Registro_actividad where NUM_Empleado = ? and CLAVE = ?;";
                conectar();
                IMapper mapper = new Mapper(_session);
                RegistroActClass user = mapper.Single<RegistroActClass>(qry, id_emp, clave);                return user;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }

        private long ExisteUsuario(string correo, char tipo)
        {
            try
            {
                string search;
                switch (tipo)
                {
                    case 'c':
                        search = "select count(*) from Log_Cliente where Correo_electronico = ?;";
                        break;
                    case 'e':
                        search = "select count(*) from Log_Empleado where Correo_electronico = ?;";
                        break;
                    default:
                        return -1;
                }
                conectar();
                IMapper mapper = new Mapper(_session);
                return mapper.Single<long>(search, correo);
            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            {
                desconectar();
            }
        }
        public bool AgregarEmpleado(EmpleadoClass emp)
        {
            try
            {
                if (ExisteUsuario(emp.correo_electronico, 'e') == 0)
                {
                    Guid generated_id = Guid.NewGuid();
                    string insertqry = "insert into Empleado(NUM_Empleado, Nombres, Apellidos, Fecha_nac, RFC, CURP, Correo_electronico, Contrasena, Activo) ";
                    insertqry += "values(?, ?, ?, ?, ?, ?, ?, ?, ?);";
                    string logininsert = "insert into Log_Empleado(Correo_electronico, Contrasena, NUM_Empleado, Nombre_usuario, Bloqueo) ";
                    logininsert += "values(?, ?, ?, ?, ?);";
                    string add_tel = "update Empleado set Telefonos = {";
                    bool first = true;
                    foreach (string telefono in emp.telefonos)
                    {
                        if (first)
                        {
                            add_tel += "'" + telefono + "'";
                            first = false;
                        }
                        else add_tel += ",'" + telefono + "'";
                    }
                    add_tel += "} where NUM_Empleado = ?;";
                    conectar();
                    var empinsert = _session.Prepare(insertqry);
                    var login = _session.Prepare(logininsert);
                    var telefonos = _session.Prepare(add_tel);
                    LocalDate fecNac = new LocalDate(emp.fecha_nac.Year, emp.fecha_nac.Month, emp.fecha_nac.Day);
                    var batch = new BatchStatement()
                                .Add(empinsert.Bind(generated_id, emp.nombres, emp.apellidos, fecNac, emp.rfc, emp.curp, emp.correo_electronico, emp.contrasena, true))
                                .Add(login.Bind(emp.correo_electronico, emp.contrasena, generated_id, emp.nombres + " " + emp.apellidos, false))
                                .Add(telefonos.Bind(generated_id));
                    _session.Execute(batch);
                    return true;
                }
                else return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
        }
        public bool ModificarEmpleado(EmpleadoClass newemp, EmpleadoClass oldemp)
        {
            try
            {
                if ((newemp.correo_electronico != oldemp.correo_electronico) | (newemp.contrasena != oldemp.contrasena))
                {
                    if (ExisteUsuario(newemp.correo_electronico, 'e') == 0)
                    {
                        string logindel = "delete from Log_Empleado where Correo_electronico = ?;";
                        string logininsert = "insert into Log_Empleado(Correo_electronico, Contrasena, NUM_Empleado, Nombre_usuario, Bloqueo) ";
                        logininsert += "values(?, ?, ?, ?, ?);";
                        conectar();
                        var dellogin = _session.Prepare(logindel);
                        var login = _session.Prepare(logininsert);
                        var batch1 = new BatchStatement()
                                    .Add(dellogin.Bind(oldemp.correo_electronico))
                                    .Add(login.Bind(newemp.correo_electronico, newemp.contrasena, oldemp.num_empleado, newemp.nombres + " " + newemp.apellidos, false));
                        _session.Execute(batch1);
                    }
                    else return false;
                }
                Guid login_id = Guid.NewGuid();
                string updateqry = "update Empleado set Nombres = ?, Apellidos = ?, Fecha_nac = ?, RFC = ?, CURP = ?, Correo_electronico = ?, Contrasena = ? ";
                updateqry += "where NUM_Empleado = ?;";
                string updatelog = "update Log_Empleado set Nombre_usuario = ? where Correo_electronico = ?;";
                string add_tel = "update Empleado set Telefonos = {";
                bool first = true;
                foreach (string telefono in newemp.telefonos)
                {
                    if (first)
                    {
                        add_tel += "'" + telefono + "'";
                        first = false;
                    }
                    else add_tel += ",'" + telefono + "'";
                }
                add_tel += "} where NUM_Empleado = ?;";
                conectar();
                var empinsert = _session.Prepare(updateqry);
                var updlogin = _session.Prepare(updatelog);
                var telefonos = _session.Prepare(add_tel);
                LocalDate fecNac = new LocalDate(newemp.fecha_nac.Year, newemp.fecha_nac.Month, newemp.fecha_nac.Day);
                var batch = new BatchStatement()
                            .Add(empinsert.Bind(newemp.nombres, newemp.apellidos, fecNac, newemp.rfc, newemp.curp, newemp.correo_electronico, newemp.contrasena, oldemp.num_empleado))
                            .Add(updlogin.Bind(newemp.nombres + " " + newemp.apellidos, oldemp.correo_electronico))
                            .Add(telefonos.Bind(oldemp.num_empleado));
                _session.Execute(batch);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
        }
        public bool EliminarEmpleado(Guid id_emp)
        {
            try{
                EmpleadoClass delemp = DatosEmpleado(id_emp);
                string delqry = "update Empleado set Activo = false where NUM_Empleado = ?;";
                string dellogin = "delete from Log_Empleado where Correo_electronico = ?;";
                string delrem = "delete from Recordar_contra where Tipo_user = ? and Correo_electronico = ?;";
                conectar();
                var delete_empleado = _session.Prepare(delqry);
                var delete_login = _session.Prepare(dellogin);
                var delete_rem = _session.Prepare(delrem);
                var batch = new BatchStatement()
                            .Add(delete_empleado.Bind(id_emp))
                            .Add(delete_login.Bind(delemp.correo_electronico))
                            .Add(delete_rem.Bind((sbyte)1, delemp.correo_electronico));
                _session.Execute(batch);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
        }

        // EMPLEADO
        public List<ClientList> LlenarClientes()
        {
            try
            {
                string qry = "select Nombres, Apellidos, CURP, Correo_electronico, ID_Cliente from Cliente where Activo = true allow filtering;";
                conectar();
                IMapper mapper = new Mapper(_session);
                IEnumerable<ClientList> lista = mapper.Fetch<ClientList>(qry);

                return lista.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public ClienteClass DatosCliente(Guid id)
        {
            try
            {
                string qry = "select ID_Cliente, Nombres, Apellidos, Fecha_nac, Domicilio, CURP, Telefonos, Correo_electronico, Contrasena from Cliente where ID_Cliente = ?; ";
                conectar();
                IMapper mapper = new Mapper(_session);
                ClienteClass user = mapper.Single<ClienteClass>(qry, id);                return user;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public List<ServicioList> LlenarServicios(Guid id)
        {
            try
            {
                string qry = "select Medidor, Tipo_serv, Domicilio, ID_Serv from Servicio where ID_Cliente = {0} and Activo = true allow filtering;";
                qry = string.Format(qry, id);
                conectar();
                IMapper mapper = new Mapper(_session);
                IEnumerable<ServicioList> lista = mapper.Fetch<ServicioList>(qry);

                return lista.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public ServicioClass DatosServicio(Guid id_cl, Guid id_serv)
        {
            try
            {
                string qry = "select ID_Cliente, ID_Serv, Medidor, Tipo_serv, Domicilio from Servicio where ID_Cliente = {0} and ID_Serv = {1}; ";
                qry = string.Format(qry, id_cl, id_serv);
                conectar();
                IMapper mapper = new Mapper(_session);
                ServicioClass user = mapper.Single<ServicioClass>(qry);                return user;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public ServicioClass DatosServicioPorMed(long med)
        {
            try
            {
                string qry = "select ID_Cliente, ID_Serv, Medidor, Tipo_serv, Domicilio from Servicio where Medidor = {0} allow filtering; ";
                qry = string.Format(qry, med);
                conectar();
                IMapper mapper = new Mapper(_session);
                ServicioClass user = mapper.Single<ServicioClass>(qry);                return user;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public TarifaClass DatosTarifa(int year, sbyte month, bool tipo_serv)
        {
            try
            {
                string qry = "select Year, Month, Tipo_serv, Tar_basica, Tar_intermedia, Tar_excedente from Reporte_Tarifas where Year = {0} and Month = {1} and Tipo_serv = {2};";
                qry = string.Format(qry, year, month, tipo_serv);
                conectar();
                IMapper mapper = new Mapper(_session);
                TarifaClass user = mapper.Single<TarifaClass>(qry);                return user;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public List<ConsumoClass> ListaConsumos(int year, sbyte month, bool tipo_serv)
        {
            try
            {
                string qry = "select Year, Month, Tipo_serv, Medidor, kW_totales, kW_basica, kW_intermedia, kW_excedente from Reporte_Consumos ";
                qry += "where Year = {0} and Month = {1} and Tipo_serv = {2} allow filtering;";
                qry = string.Format(qry, year, month, tipo_serv);
                conectar();
                IMapper mapper = new Mapper(_session);
                IEnumerable<ConsumoClass> lista = mapper.Fetch<ConsumoClass>(qry);

                return lista.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public List<ConsumoHist> Consumo_Historico(Guid id_serv, int year)
        {
            try
            {
                string qry = "select Year, Month, Medidor, Consumo_kW, Pago_total, Importe_Pago, Pendiente_Pago from Consumo_Historico ";
                qry += "where ID_Serv = {0} and Year = {1} allow filtering;";
                qry = string.Format(qry, id_serv, year);
                conectar();
                IMapper mapper = new Mapper(_session);
                IEnumerable<ConsumoHist> lista = mapper.Fetch<ConsumoHist>(qry);

                return lista.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public List<ConsumoClass> ReporteConsumos(int year)
        {
            try
            {
                string qry = "select Year, Month, Medidor, kW_totales, kW_basica, kW_intermedia, kW_excedente from Reporte_Consumos ";
                qry += "where Year = {0} allow filtering;";
                qry = string.Format(qry, year);
                conectar();
                IMapper mapper = new Mapper(_session);
                IEnumerable<ConsumoClass> lista = mapper.Fetch<ConsumoClass>(qry);

                return lista.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public List<TarifaClass> ReporteTarifas(int year)
        {
            try
            {
                string qry = "select Year, Month, Tipo_serv, Tar_basica, Tar_intermedia, Tar_excedente from Reporte_Tarifas ";
                qry += "where Year = {0} allow filtering;";
                qry = string.Format(qry, year);
                conectar();
                IMapper mapper = new Mapper(_session);
                IEnumerable<TarifaClass> lista = mapper.Fetch<TarifaClass>(qry);

                return lista.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }

        private long ExisteTarifa(int year, sbyte month, bool tipo)
        {
            try
            {
                string qry = "select count(*) from Reporte_Tarifas where Year = ? and Month = ? and Tipo_serv = ?;";
                conectar();
                IMapper mapper = new Mapper(_session);
                return mapper.Single<long>(qry, year, month, tipo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                desconectar();
            }
        }
        private long ExisteConsumo(Guid id_serv, int year, sbyte month)
        {
            try
            {
                string qry = "select count(*) from Consumo where ID_Serv = ? and Year = ? and Month = ?;";
                conectar();
                IMapper mapper = new Mapper(_session);
                return mapper.Single<long>(qry, id_serv, year, month);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                desconectar();
            }
        }
        private long ExisteServicio(long medidor, bool tipo)
        {
            try
            {
                string search = "select count(*) from Servicio where Medidor = ? and Tipo_serv = ? allow filtering";
                conectar();
                IMapper mapper = new Mapper(_session);
                return mapper.Single<long>(search, medidor, tipo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                desconectar();
            }
        }
        public bool AgregarCliente(ClienteClass cli)
        {
            try
            {
                if (ExisteUsuario(cli.correo_electronico, 'c') == 0)
                {
                    Guid generated_id = Guid.NewGuid();
                    Guid regact_clave = Guid.NewGuid();
                    string insertqry = "insert into Cliente(ID_Cliente, Nombres, Apellidos, Fecha_nac, Domicilio, CURP, Correo_electronico, Contrasena, Activo) ";
                    insertqry += "values(?, ?, ?, ?, ?, ?, ?, ?, ?);";
                    string logininsert = "insert into Log_Cliente(Correo_electronico, Contrasena, ID_Cliente, Nombre_usuario, Bloqueo) ";
                    logininsert += "values(?, ?, ?, ?, ?);";
                    string add_tel = "update Cliente set Telefonos = {";
                    bool first = true;
                    foreach (string telefono in cli.telefonos)
                    {
                        if (first)
                        {
                            add_tel += "'" + telefono + "'";
                            first = false;
                        }
                        else add_tel += ",'" + telefono + "'";
                    }
                    add_tel += "} where ID_Cliente = ?;";
                    string regactquery = "insert into Registro_actividad(NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion) ";
                    regactquery += "values(?, ?, toTimestamp(now()), 'Registro de Cliente', ?);";
                    string descripcion = "Empleado con ID {0}, {1}, registró a cliente con ID {2}, {3}.";
                    descripcion = string.Format(descripcion, cli.id_emp, cli.empUsername, generated_id, cli.nombres + ' ' + cli.apellidos);
                    conectar();
                    var empinsert = _session.Prepare(insertqry);
                    var login = _session.Prepare(logininsert);
                    var telefonos = _session.Prepare(add_tel);
                    var regactinsert = _session.Prepare(regactquery);
                    LocalDate fecNac = new LocalDate(cli.fecha_nac.Year, cli.fecha_nac.Month, cli.fecha_nac.Day);
                    var batch = new BatchStatement()
                                .Add(empinsert.Bind(generated_id, cli.nombres, cli.apellidos, fecNac, cli.domic.getAssembled(), cli.curp, cli.correo_electronico, cli.contrasena, true))
                                .Add(login.Bind(cli.correo_electronico, cli.contrasena, generated_id, cli.nombres + " " + cli.apellidos, false))
                                .Add(telefonos.Bind(generated_id))
                                .Add(regactinsert.Bind(cli.id_emp, regact_clave, descripcion));
                    _session.Execute(batch);
                    return true;
                }
                else return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
        }
        public bool ModificarCliente(ClienteClass newcli, ClienteClass oldcli)
        {
            try
            {
                if ((newcli.correo_electronico != oldcli.correo_electronico) | (newcli.contrasena != oldcli.contrasena))
                {
                    if (ExisteUsuario(newcli.correo_electronico, 'c') == 0)
                    {
                        string logindel = "delete from Log_Cliente where Correo_electronico = ?;";
                        string logininsert = "insert into Log_Cliente(Correo_electronico, Contrasena, ID_Cliente, Nombre_usuario, Bloqueo) ";
                        logininsert += "values(?, ?, ?, ?, ?);";
                        conectar();
                        var dellogin = _session.Prepare(logindel);
                        var login = _session.Prepare(logininsert);
                        var batch1 = new BatchStatement()
                                    .Add(dellogin.Bind(oldcli.correo_electronico))
                                    .Add(login.Bind(newcli.correo_electronico, newcli.contrasena, oldcli.id_cliente, newcli.nombres + " " + newcli.apellidos, false));
                        _session.Execute(batch1);
                        desconectar();
                    }
                    else return false;
                }
                Guid regact_clave = Guid.NewGuid();
                string updateqry = "update Cliente set Nombres = ?, Apellidos = ?, Fecha_nac = ?, Domicilio = ?, CURP = ?, Correo_electronico = ?, Contrasena = ? ";
                updateqry += "where ID_Cliente = ?;";
                string add_tel = "update Cliente set Telefonos = {";
                bool first = true;
                foreach (string telefono in newcli.telefonos)
                {
                    if (first)
                    {
                        add_tel += "'" + telefono + "'";
                        first = false;
                    }
                    else add_tel += ",'" + telefono + "'";
                }
                add_tel += "} where ID_Cliente = ?;";
                string updatelog = "update Log_Cliente set Nombre_usuario = ? where Correo_electronico = ?;";
                string regactquery = "insert into Registro_actividad(NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion) ";
                regactquery += "values(?, ?, toTimestamp(now()), 'Modificación de Cliente', ?);";
                string descripcion = "Empleado con ID {0}, {1}, modificó a cliente con ID {2}, {3}.";
                descripcion = string.Format(descripcion, newcli.id_emp, newcli.empUsername, oldcli.id_cliente, newcli.nombres + ' ' + newcli.apellidos);
                conectar();
                var updcli = _session.Prepare(updateqry);
                var telefonos = _session.Prepare(add_tel);
                var updlogin = _session.Prepare(updatelog);
                var regactinsert = _session.Prepare(regactquery);
                LocalDate fecNac = new LocalDate(newcli.fecha_nac.Year, newcli.fecha_nac.Month, newcli.fecha_nac.Day);
                var batch2 = new BatchStatement()
                            .Add(updcli.Bind(newcli.nombres, newcli.apellidos, fecNac, newcli.domic.getAssembled(), newcli.curp, newcli.correo_electronico, newcli.contrasena, oldcli.id_cliente))
                            .Add(telefonos.Bind(oldcli.id_cliente))
                            .Add(updlogin.Bind(newcli.nombres + " " + newcli.apellidos, newcli.correo_electronico))
                            .Add(regactinsert.Bind(newcli.id_emp, regact_clave, descripcion));
                _session.Execute(batch2);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
        }
        public bool EliminarCliente(Guid id_cli, Guid id_emp)
        {
            try
            {
                ClienteClass delcli = DatosCliente(id_cli);
                EmpleadoClass emp = DatosEmpleado(id_emp);
                Guid regact_id = Guid.NewGuid();
                string delqry = "update Cliente set Activo = false where ID_Cliente = ?;";
                string dellogin = "delete from Log_Cliente where Correo_electronico = ?;";
                string delrem = "delete from Recordar_contra where Tipo_user = ? and Correo_electronico = ?;";
                string delserv = "update Servicio set Activo = false where ID_Cliente = ? and ID_Serv = ?;";
                string regactquery = "insert into Registro_actividad(NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion) ";
                regactquery += "values(?, ?, toTimestamp(now()), 'Baja de Cliente', ?);";
                string descripcion = "Empleado con ID {0}, {1}, dió de baja a cliente con ID {2}, {3}.";
                descripcion = string.Format(descripcion, id_emp, emp.nombres + " " + emp.apellidos, delcli.id_cliente, delcli.nombres + ' ' + delcli.apellidos);
                List<ServicioList> servicios = LlenarServicios(id_cli);
                conectar();
                foreach (ServicioList s in servicios)
                {
                    var delete_servicio = _session.Prepare(delserv);
                    var batch2 = new BatchStatement()
                                    .Add(delete_servicio.Bind(id_cli, s.id_serv));
                    _session.Execute(batch2);
                }
                var delete_cliente = _session.Prepare(delqry);
                var delete_login = _session.Prepare(dellogin);
                var delete_rem = _session.Prepare(delrem);
                var regact = _session.Prepare(regactquery);
                var batch = new BatchStatement()
                            .Add(delete_cliente.Bind(id_cli))
                            .Add(delete_login.Bind(delcli.correo_electronico))
                            .Add(delete_rem.Bind((sbyte)0, delcli.correo_electronico))
                            .Add(regact.Bind(id_emp, regact_id, descripcion));
                _session.Execute(batch);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
        }
        public bool AgregarServicio(ServicioClass serv)
        {
            try
            {
                if (ExisteServicio(serv.medidor, serv.tipo_serv) == 0)
                {
                    Guid id_servicio = Guid.NewGuid();
                    Guid regact_clave = Guid.NewGuid();
                    string insertqry = "insert into Servicio(ID_Cliente, ID_Serv, Medidor, Tipo_serv, Domicilio, Activo) ";
                    insertqry += "values(?, ?, ?, ?, ?, ?);";
                    string regactquery = "insert into Registro_actividad(NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion) ";
                    regactquery += "values(?, ?, toTimestamp(now()), 'Registro de Servicio', ?);";
                    string descripcion = "Empleado con ID {0}, {1}, registró servicio con Medidor {2} para cliente con ID {3}, {4}.";
                    descripcion = string.Format(descripcion, serv.id_emp, serv.empUsername, serv.medidor, serv.id_cliente, serv.cliUsername);
                    conectar();
                    var empinsert = _session.Prepare(insertqry);
                    var regactinsert = _session.Prepare(regactquery);
                    var batch = new BatchStatement()
                                .Add(empinsert.Bind(serv.id_cliente, id_servicio, serv.medidor, serv.tipo_serv, serv.domic.getAssembled(), true))
                                .Add(regactinsert.Bind(serv.id_emp, regact_clave, descripcion));
                    _session.Execute(batch);
                    return true;
                }
                else return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
        }
        public bool ModificarServicio(ServicioClass newserv, ServicioClass oldserv)
        {
            try
            {
                if ((newserv.medidor != oldserv.medidor) | (newserv.tipo_serv != oldserv.tipo_serv))
                {
                    if (ExisteServicio(newserv.medidor, newserv.tipo_serv) == 0)
                    {
                        string updservmod = "update Servicio set Medidor = ?, Tipo_serv = ? where ID_Cliente = ? and ID_Serv = ?;";
                        conectar();
                        var serv_upd = _session.Prepare(updservmod);
                        var batch = new BatchStatement()
                                    .Add(serv_upd.Bind(newserv.medidor, newserv.tipo_serv, oldserv.id_cliente, oldserv.id_serv));
                        _session.Execute(batch);
                        desconectar();
                    }
                }
                Guid regact_clave = Guid.NewGuid();
                string updservdom = "update Servicio set Domicilio = ? where ID_Cliente = ? and ID_Serv = ?;";
                string regactquery = "insert into Registro_actividad(NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion) ";
                regactquery += "values(?, ?, toTimestamp(now()), 'Modificación de Servicio', ?);";
                string descripcion = "Empleado con ID {0}, {1}, modificó servicio con Medidor {2} para cliente con ID {3}, {4}.";
                descripcion = string.Format(descripcion, newserv.id_emp, newserv.empUsername, newserv.medidor, newserv.id_cliente, newserv.cliUsername);
                conectar();
                var serv_dom = _session.Prepare(updservdom);
                var regact = _session.Prepare(regactquery);
                var batch2 = new BatchStatement()
                                 .Add(serv_dom.Bind(newserv.domic.getAssembled(), oldserv.id_cliente, oldserv.id_serv))
                                 .Add(regact.Bind(newserv.id_emp, regact_clave, descripcion));
                _session.Execute(batch2);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
        }
        public bool EliminarServicio(Guid id_cli, Guid id_serv, Guid id_emp)
        {
            try
            {
                EmpleadoClass empl = DatosEmpleado(id_emp);
                ServicioClass delserv = DatosServicio(id_cli, id_serv);
                ClienteClass client = DatosCliente(id_cli);
                Guid regact_clave = Guid.NewGuid();
                string delqry = "update Servicio set Activo = false where ID_Cliente = ? and ID_Serv = ?;";
                string regactquery = "insert into Registro_actividad(NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion) ";
                regactquery += "values(?, ?, toTimestamp(now()), 'Baja de Servicio', ?);";
                string descripcion = "Empleado con ID {0}, {1}, eliminó a servicio con Medidor {2} para cliente con ID {3}, {4}.";
                descripcion = string.Format(descripcion, id_emp, empl.nombres + " " + empl.apellidos, delserv.medidor, client.id_cliente, client.nombres + " " + client.apellidos);
                conectar();
                var delete_empleado = _session.Prepare(delqry);
                var delete_rem = _session.Prepare(regactquery);
                var batch = new BatchStatement()
                            .Add(delete_empleado.Bind(id_cli, id_serv))
                            .Add(delete_rem.Bind(id_emp, regact_clave, descripcion));
                _session.Execute(batch);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {

            }
        }

        public bool AgregarTarifa(TarifaClass tar, Guid id_emp, string username)
        {
            try
            {
                Guid regact_id = Guid.NewGuid();
                string insert_tar = "update Reporte_Tarifas set Tar_basica = ?, Tar_intermedia = ?, Tar_excedente = ? ";
                insert_tar += "where Year = ? and Month = ? and Tipo_serv = ?;";
                string regactquery = "insert into Registro_actividad(NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion) ";
                regactquery += "values(?, ?, toTimestamp(now()), 'Registro de Tarifa', ?);";
                string descripcion = "Empleado con ID {0}, {1}, registró/modificó tarifa para el periodo {2}/{3} de tipo {4}.";
                string type;
                if (!tar.tipo_serv) type = "Doméstico";
                else type = "Industrial";
                descripcion = string.Format(descripcion, id_emp, username, tar.year, tar.month, type);
                conectar();
                var insert = _session.Prepare(insert_tar);
                var regact = _session.Prepare(regactquery);
                var batch = new BatchStatement()
                            .Add(insert.Bind(tar.tar_basica, tar.tar_intermedia, tar.tar_excedente, tar.year, tar.month, tar.tipo_serv))
                            .Add(regact.Bind(id_emp, regact_id, descripcion));
                _session.Execute(batch);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
        }
        public bool AgregarConsumo(ConsumoClass cons, Guid id_emp, string username)
        {
            try
            {
                Guid regact_id = Guid.NewGuid();
                ServicioClass ser = DatosServicioPorMed(cons.medidor);
                if (ser == null)
                {
                    return false;
                }
                string insert_rep = "update Reporte_Consumos set kW_totales = ?, kW_basica = ?, kW_intermedia = ?, kW_excedente = ? ";
                insert_rep += "where Year = ? and Month = ? and Tipo_serv = ? and Medidor = ?;";
                string cons_hist = "update Consumo_Historico set Medidor = ?, Consumo_kW = ?, Pago_total = 0, Importe_Pago = 0, Pendiente_Pago = 0 ";
                cons_hist += "where ID_Serv = ? and Year = ? and Month = ?;";
                string regactquery = "insert into Registro_actividad(NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion) ";
                regactquery += "values(?, ?, toTimestamp(now()), 'Registro de Consumo', ?);";
                string descripcion = "Empleado con ID {0}, {1}, registró/modificó consumo del periodo {2}/{3} para el medidor {4}.";
                descripcion = string.Format(descripcion, id_emp, username, cons.year, cons.month, cons.medidor);
                conectar();
                var report = _session.Prepare(insert_rep);
                var hist = _session.Prepare(cons_hist);
                var regact = _session.Prepare(regactquery);
                var batch = new BatchStatement()
                            .Add(report.Bind(cons.kw_totales, cons.kw_basica, cons.kw_intermedia, cons.kw_excedente, cons.year, cons.month, ser.tipo_serv, cons.medidor))
                            .Add(hist.Bind(cons.medidor, cons.kw_totales, ser.id_serv, cons.year, cons.month))
                            .Add(regact.Bind(id_emp, regact_id, descripcion));
                _session.Execute(batch);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
        }

        public decimal PrevRecibo(Guid id_serv, int year, sbyte month)
        {
            try
            {
                string search = "select Pendiente_Pago from Recibos where ID_Serv = ? and Year = ? and Month = ? allow filtering;";
                conectar();
                IMapper mapper = new Mapper(_session);
                return mapper.Single<decimal>(search, id_serv, year, month);
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                desconectar();
            }
        }
        public bool GenerarRecibos(Guid id_emp, string emp_name, int year, sbyte month, bool tipo_serv)
        {
            try
            {
                TarifaClass tarifa = DatosTarifa(year, month, tipo_serv);
                if (tarifa == null) return false;
                List<ConsumoClass> consumos = ListaConsumos(year, month, tipo_serv);
                List<ReciboClass> recibos = new List<ReciboClass>();
                DateTime vencimiento = DateTime.Today;
                vencimiento = vencimiento.AddDays(10);
                decimal IVA = Convert.ToDecimal(ConfigurationManager.AppSettings["IVA"].ToString());
                int prevyear = 0;
                sbyte prevmonth = 0;
                if (month == 1)
                {
                    prevyear = year -1;
                    prevmonth = 12;
                }
                else
                {
                    prevyear = year;
                    prevmonth = Convert.ToSByte(month - 1);
                }
                foreach (ConsumoClass cons in consumos)
                {
                    Guid recibo_gen = Guid.NewGuid();
                    ReciboClass r = new ReciboClass();
                    ServicioClass serv = DatosServicioPorMed(cons.medidor);
                    r.id_ser = serv.id_serv;
                    r.id_rec = recibo_gen;
                    r.year = year;
                    r.month = month;
                    r.tipo_ser = tipo_serv;
                    r.medidor = cons.medidor;
                    r.domicilio = serv.domicilio;
                    r.fec_venc = new LocalDate(vencimiento.Year, vencimiento.Month, vencimiento.Day);
                    r.consumo_basico = cons.kw_basica;
                    r.consumo_intermedio = cons.kw_intermedia;
                    r.consumo_excedente = cons.kw_excedente;
                    r.consumo_total = cons.kw_totales;
                    r.tarifa_basica = tarifa.tar_basica;
                    r.tarifa_intermedia = tarifa.tar_intermedia;
                    r.tarifa_excedente = tarifa.tar_excedente;
                    r.precio_basico = tarifa.tar_basica * cons.kw_basica;
                    r.precio_intermedio = tarifa.tar_intermedia * cons.kw_intermedia;
                    r.precio_excedente = tarifa.tar_excedente * cons.kw_excedente;
                    r.precio_total = r.precio_basico + r.precio_intermedio + r.precio_excedente;
                    r.cargo_iva = r.precio_total * IVA;
                    r.prev_pendiente = PrevRecibo(serv.id_serv, prevyear, prevmonth);
                    r.pago_total = r.precio_total + r.cargo_iva + r.prev_pendiente;
                    r.importe_pago = 0;
                    r.pendiente_pago = 0;
                    r.pagado = false;
                    recibos.Add(r);
                }
                PreparedStatement insertqry;
                var batch = new BatchStatement();
                conectar();
                foreach(ReciboClass reg in recibos)
                {
                    string qry = "update Recibos set Year = ?, Month = ?, Tipo_serv = ?, Medidor = ?, Domicilio = ?, Fecha_venci = ?, ";
                    qry += "Consumo_basico = ?, Consumo_intermedio = ?, Consumo_excedente = ?, Consumo_total = ?, ";
                    qry += "Tarifa_basica = ?, Tarifa_intermedia = ?, Tarifa_excedente = ?, ";
                    qry += "Precio_basico = ?, Precio_intermedio = ?, Precio_excedente = ?, Precio_total = ?, ";
                    qry += "Cargo_IVA = ?, Pago_total = ?, Importe_Pago = ?, Pendiente_Pago = ?, Prev_pendiente = ?, Pagado = ? ";
                    qry += "where ID_Serv = ? and ID_Rec = ?;";
                    insertqry = _session.Prepare(qry);
                    batch.Add(insertqry.Bind(
                                reg.year, reg.month, reg.tipo_ser, reg.medidor, reg.domicilio, reg.fec_venc,
                                reg.consumo_basico, reg.consumo_intermedio, reg.consumo_excedente, reg.consumo_total,
                                reg.tarifa_basica, reg.tarifa_intermedia, reg.tarifa_excedente,
                                reg.precio_basico, reg.precio_intermedio, reg.precio_excedente, reg.precio_total,
                                reg.cargo_iva, reg.pago_total, reg.importe_pago, reg.pendiente_pago, reg.prev_pendiente, reg.pagado,
                                reg.id_ser, reg.id_rec
                              ));
                }
                Guid regact_id = Guid.NewGuid();
                string regactquery = "insert into Registro_actividad(NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion) ";
                regactquery += "values(?, ?, toTimestamp(now()), 'Generación de Recibos', ?);";
                string descripcion = "Empleado con ID {0}, {1}, generó recibos del periodo {2}/{3} de tipo {4}.";
                descripcion = string.Format(descripcion, id_emp, emp_name, year, month, tipo_serv);
                var regact = _session.Prepare(regactquery);
                batch.Add(regact.Bind(id_emp, regact_id, descripcion));
                _session.Execute(batch);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally{
                desconectar();
            }
        }

        // CLIENTE
        public List<ReciboList> LlenarRecibos(Guid id_serv)
        {
            try
            {
                string qry = "select Year, Month, Medidor, Tipo_serv, Fecha_venci, ID_Serv, ID_Rec from Recibos ";
                qry += "where ID_Serv = {0} allow filtering;";
                qry = string.Format(qry, id_serv);
                conectar();
                IMapper mapper = new Mapper(_session);
                IEnumerable<ReciboList> lista = mapper.Fetch<ReciboList>(qry);

                return lista.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public ReciboClass DatosRecibo(Guid id_serv, Guid id_rec)
        {
            try
            {
                string qry = "select Year, Month, Tipo_serv, Medidor, Domicilio, Fecha_venci, ";
                qry += "Consumo_basico, Consumo_intermedio, Consumo_excedente, Consumo_total, ";
                qry += "Tarifa_basica, Tarifa_intermedia, Tarifa_excedente, ";
                qry += "Precio_basico, Precio_intermedio, Precio_excedente, Precio_total, ";
                qry += "Cargo_IVA, Pago_total, Importe_Pago, Pendiente_Pago, Prev_pendiente, Pagado ";
                qry += "from Recibos where ";
                qry += "ID_Serv = {0} and ID_Rec = {1};";
                qry = string.Format(qry, id_serv, id_rec);
                conectar();
                IMapper mapper = new Mapper(_session);
                ReciboClass user = mapper.Single<ReciboClass>(qry);                return user;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public List<TarjetaClass> Tarjetas(Guid id_cli)
        {
            try
            {
                string qry = "select Tarjetas from Cliente where ID_Cliente = ?;";
                conectar();
                IMapper mapper = new Mapper(_session);
                IEnumerable<TarjetaClass> lista = mapper.Fetch<TarjetaClass>(qry, id_cli);
                foreach (TarjetaClass tar in lista)
                {
                    tar.split();
                }
                return lista.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public List<CuentasClass> CuentasBancarias(Guid id_cli)
        {
            try
            {
                string qry = "select Cuentas_bancarias from Cliente where ID_Cliente = ?;";
                conectar();
                IMapper mapper = new Mapper(_session);
                IEnumerable<CuentasClass> lista = mapper.Fetch<CuentasClass>(qry, id_cli);
                foreach (CuentasClass cons in lista)
                {
                    cons.split();
                }
                return lista.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                desconectar();
            }
        }

        public bool AgregarTarjeta(Guid id_cli, string info)
        {
            try
            {
                string qry = "update Cliente set Tarjetas = [ {0} ] + Tarjetas WHERE ID_Cliente = {1};";
                qry = string.Format(qry, info, id_cli);
                _session.Execute(qry);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                desconectar();
            }
        }
        public bool AgregarCuenta(Guid id_cli, string info)
        {
            try
            {
                string qry = "update Cliente set Cuentas_bancarias = [ '{0}' ] + Cuentas_bancarias WHERE ID_Cliente = {1};";
                qry = string.Format(qry, info, id_cli);
                _session.Execute(qry);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                desconectar();
            }
        }

        public bool Pago(Guid id_cli, Guid id_serv, Guid id_rec, decimal cant)
        {
            try
            {
                ReciboClass recibo = DatosRecibo(id_serv, id_rec);
                if (recibo.pagado)
                {
                    return false;
                }
                if (cant > recibo.pago_total)
                {
                    return false;
                }
                decimal pendiente = recibo.pago_total - cant;
                string qry = "update Recibos set Importe_Pago = ?, Pendiente_Pago = ?, Pagado = true where ID_Serv = ? and ID_Rec = ?;";
                string reporte = "update Reporte_General set Total_pago = ?, Total_pendiente = ? ";
                reporte += "where ID_Cliente = ? and Year = ? and Month = ? and Tipo_serv = ?;";
                string consumo_h = "update Consumo_Historico set Pago_total = ?, Importe_Pago = ?, Pendiente_Pago = ? ";
                consumo_h += "where ID_Serv = ? and Year = ? and Month = ?;";
                conectar();
                var pago = _session.Prepare(qry);
                var reporte_gen = _session.Prepare(reporte);
                var consumo = _session.Prepare(consumo_h);
                var batch = new BatchStatement()
                            .Add(pago.Bind(cant, pendiente, id_serv, id_rec))
                            .Add(reporte_gen.Bind(cant, pendiente, id_cli, recibo.year, recibo.month, recibo.tipo_ser))
                            .Add(consumo.Bind(recibo.pago_total, cant, pendiente, id_serv, recibo.year, recibo.month));
                _session.Execute(batch);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                desconectar();
            }
        }
    }
}