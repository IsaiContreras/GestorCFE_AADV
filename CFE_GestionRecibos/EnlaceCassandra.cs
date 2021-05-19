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

        public long ExisteUsuario(string correo, char tipo)
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
                    conectar();
                    var empinsert = _session.Prepare(insertqry);
                    var login = _session.Prepare(logininsert);
                    LocalDate fecNac = new LocalDate(emp.fecha_nac.Year, emp.fecha_nac.Month, emp.fecha_nac.Day);
                    var batch = new BatchStatement()
                                .Add(empinsert.Bind(generated_id, emp.nombres, emp.apellidos, fecNac, emp.rfc, emp.curp, emp.correo_electronico, emp.contrasena, true))
                                .Add(login.Bind(emp.correo_electronico, emp.contrasena, generated_id, emp.nombres + " " + emp.apellidos, false));
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
                conectar();
                var empinsert = _session.Prepare(updateqry);
                var updlogin = _session.Prepare(updatelog);
                LocalDate fecNac = new LocalDate(newemp.fecha_nac.Year, newemp.fecha_nac.Month, newemp.fecha_nac.Day);
                var batch = new BatchStatement()
                            .Add(empinsert.Bind(newemp.nombres, newemp.apellidos, fecNac, newemp.rfc, newemp.curp, newemp.correo_electronico, newemp.contrasena, oldemp.num_empleado))
                            .Add(updlogin.Bind(newemp.nombres + " " + newemp.apellidos, oldemp.correo_electronico));
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

        public long ExisteServicio(long medidor, bool tipo)
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
                    string regactquery = "insert into Registro_actividad(NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion) ";
                    regactquery += "values(?, ?, toTimestamp(now()), 'Registro de Cliente', ?);";
                    string descripcion = "Empleado con ID {0}, {1}, registró a cliente con ID {2}, {3}.";
                    descripcion = string.Format(descripcion, cli.id_emp, cli.empUsername, generated_id, cli.nombres + ' ' + cli.apellidos);
                    conectar();
                    var empinsert = _session.Prepare(insertqry);
                    var login = _session.Prepare(logininsert);
                    var regactinsert = _session.Prepare(regactquery);
                    LocalDate fecNac = new LocalDate(cli.fecha_nac.Year, cli.fecha_nac.Month, cli.fecha_nac.Day);
                    var batch = new BatchStatement()
                                .Add(empinsert.Bind(generated_id, cli.nombres, cli.apellidos, fecNac, cli.domic.getAssembled(), cli.curp, cli.correo_electronico, cli.contrasena, true))
                                .Add(login.Bind(cli.correo_electronico, cli.contrasena, generated_id, cli.nombres + " " + cli.apellidos, false))
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
                    }
                    else return false;
                }
                Guid regact_clave = Guid.NewGuid();
                string updateqry = "update Cliente set Nombres = ?, Apellidos = ?, Fecha_nac = ?, Domicilio = ?, CURP = ?, Correo_electronico = ?, Contrasena = ? ";
                updateqry += "where ID_Cliente = ?;";
                string updatelog = "update Log_Cliente set Nombre_usuario = ? where Correo_electronico = ?;";
                string regactquery = "insert into Registro_actividad(NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion) ";
                regactquery += "values(?, ?, toTimestamp(now()), 'Modificación de Cliente', ?);";
                string descripcion = "Empleado con ID {0}, {1}, modificó a cliente con ID {2}, {3}.";
                descripcion = string.Format(descripcion, newcli.id_emp, newcli.empUsername, oldcli.id_cliente, newcli.nombres + ' ' + newcli.apellidos);
                var updcli = _session.Prepare(updateqry);
                var updlogin = _session.Prepare(updatelog);
                var regactinsert = _session.Prepare(regactquery);
                LocalDate fecNac = new LocalDate(newcli.fecha_nac.Year, newcli.fecha_nac.Month, newcli.fecha_nac.Day);
                var batch2 = new BatchStatement()
                            .Add(updcli.Bind(newcli.nombres, newcli.apellidos, fecNac, newcli.domic.getAssembled(), newcli.curp, newcli.correo_electronico, newcli.contrasena, oldcli.id_cliente))
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
        public bool EliminarCliente(Guid id_cli)
        {
            try
            {
                ClienteClass delemp = DatosCliente(id_cli);
                string delqry = "update Cliente set Activo = false where ID_Cliente = ?;";
                string dellogin = "delete from Log_Cliente where Correo_electronico = ?;";
                string delrem = "delete from Recordar_contra where Tipo_user = ? and Correo_electronico = ?;";
                string delserv = "update Servicio set Activo = false where ID_Cliente = ?;";
                conectar();
                var delete_cliente = _session.Prepare(delqry);
                var delete_login = _session.Prepare(dellogin);
                var delete_rem = _session.Prepare(delrem);
                var delete_serv = _session.Prepare(delserv);
                var batch = new BatchStatement()
                            .Add(delete_cliente.Bind(id_cli))
                            .Add(delete_login.Bind(delemp.correo_electronico))
                            .Add(delete_rem.Bind((sbyte)0, delemp.correo_electronico))
                            .Add(delete_serv.Bind(id_cli));
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
                    string descripcion = "Empleado con ID {0}, {1}, registró a servicio con Medidor {2} para cliente con ID {3}, {4}.";
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
                                    .Add(serv_upd.Bind(newserv.medidor, newserv.tipo_serv, oldserv.id_cliente, oldserv.id_servicio));
                        _session.Execute(batch);
                    }
                }
                Guid regact_clave = Guid.NewGuid();
                string updservdom = "update Servicio set Domicilio = ? where ID_Cliente = ? and ID_Serv = ?;";
                string regactquery = "insert into Registro_actividad(NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion) ";
                regactquery += "values(?, ?, toTimestamp(now()), 'Modificación de Servicio', ?);";
                string descripcion = "Empleado con ID {0}, {1}, registró a servicio con Medidor {2} para cliente con ID {3}, {4}.";
                descripcion = string.Format(descripcion, newserv.id_emp, newserv.empUsername, newserv.medidor, newserv.id_cliente, newserv.cliUsername);
                var serv_dom = _session.Prepare(updservdom);
                var regact = _session.Prepare(regactquery);
                var batch2 = new BatchStatement()
                                 .Add(serv_dom.Bind(newserv.domic.getAssembled(), oldserv.id_cliente, oldserv.id_servicio))
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
                regactquery += "values(?, ?, toTimestamp(now()), 'Registro de Servicio', ?);";
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

        //public bool InsertEmpleado(EmpleadoClass emp)
        //{
        //    return true;
        //}

        //public bool InsertUsers(users param)
        //{
        //    var Err = false; // SI no hay error
        //    try
        //    {
        //        conectar();
        //        var fecha = param.f_nac.ToString("yyyy-MM-dd");
        //        var id = new Guid();
        //        id = Guid.NewGuid();

        //        var query = "BEGIN BATCH ";
        //        var query1 = "insert into users(id, name, email, f_nac) values({0}, '{1}', '{2}', '{3}'); ";
        //        query1 = string.Format(query1, id, param.name, param.email, fecha);
        //        var query2 = "insert into users2(id, name, email) values({0}, '{1}', '{2}'); ";
        //        query2 = string.Format(query2, id, param.name, param.email);
        //        query = query + query1 + query2 + " APPLY BATCH;";

        //        _session.Execute(query);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        Err = true;
        //        throw e;
        //    }
        //    finally
        //    {
        //        // desconectar o cerrar la conexión
        //        desconectar();

        //    }
        //    return Err;
        //}

        //public bool InsertClientes(clientes param)
        //{
        //    var Err = false; // SI no hay error
        //    try
        //    {
        //        conectar();

        //        var query1 = "insert into clientes(user_id, first_name, last_name) values('{0}', '{1}', '{2}'); ";
        //        query1 = string.Format(query1, param.user_id, param.first_name, param.last_name);

        //        _session.Execute(query1);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        Err = true;
        //        throw e;
        //    }
        //    finally
        //    {
        //        // desconectar o cerrar la conexión
        //        desconectar();

        //    }
        //    return Err;
        //}

        //public bool UpdateClientes(clientes param, int accion)
        //{
        //    var Err = false; // SI no hay error
        //    var oper = "+";
        //    if(accion == 0) { oper = "-"; }
        //    try
        //    {
        //        conectar();

        //        var query1 = "update clientes ";
        //        query1 += "set ";
        //        query1 += "    first_name = '{1}', ";
        //        query1 += "    last_name = '{2}', ";
        //        query1 += "    emails = emails " + oper +" ['{3}'] ";
        //        query1 += " where user_id =  '{0}' ";
        //        query1 += " IF EXISTS; ";
        //        query1 = string.Format(query1, param.user_id, param.first_name, param.last_name, param.emails);

        //        _session.Execute(query1);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        Err = true;
        //        throw e;
        //    }
        //    finally
        //    {
        //        // desconectar o cerrar la conexión
        //        desconectar();

        //    }
        //    return Err;
        //}

        //public List<clientes1> Get_Clientes(string user_id)
        //{
        //    string query = "select user_id, first_name, last_name, emails ";
        //    query += "from clientes ";
        //    query += "where user_id = '{0}'; ";
        //    query = string.Format(query, user_id);
        //    conectar();

        //    IMapper mapper = new Mapper(_session);
        //    IEnumerable<clientes1> ctes = mapper.Fetch<clientes1>(query);

        //    desconectar();
        //    return ctes.ToList();

        //}

        //public void InsertaDatos(int id, string dato)
        //{
        //    try
        //    {
        //        conectar();

        //        string qry = "insert into ejemplo(campo1, campo2) values(";
        //        qry = qry + id.ToString();
        //        qry = qry + ",'";
        //        qry = qry + dato;
        //        qry = qry + "');";


        //        string query = "insert into ejemplo(campo1, campo2) values({0}, '{1}');";
        //        qry = string.Format(query, id, dato);

        //        _session.Execute(qry);
        //    }
        //    catch(Exception e)
        //    {
        //        throw e;   
        //    }
        //    finally
        //    {
        //        // desconectar o cerrar la conexión
        //        desconectar();
        //    }
        //}

        //public IEnumerable<Ejemplo> Get_One(int dato)
        //{
        //    string query = "SELECT campo1, campo2 FROM ejemplo WHERE campo1 = ?;";
        //    conectar();
        //    IMapper mapper = new Mapper(_session);
        //    IEnumerable<Ejemplo> users = mapper.Fetch<Ejemplo>(query, dato);

        //    desconectar();
        //    return users.ToList();
        //}

        //public List<Ejemplo> Get_All()
        //{
        //    string query = "SELECT campo1, campo2 FROM ejemplo;";
        //    conectar();

        //    IMapper mapper = new Mapper(_session);
        //    IEnumerable<Ejemplo> users = mapper.Fetch<Ejemplo>(query);

        //    desconectar();
        //    return users.ToList();

        //}

        // Ejemplo de leer row x row
        //public void GetOne()
        //{
        //    conectar();

        //    string query ="SELECT campo1, campo2 FROM ejemplo;";

        //    // Execute a query on a connection synchronously 
        //    var rs = _session.Execute(query);

        //    // Iterate through the RowSet 
        //    foreach (var row in rs)
        //    {
        //        var value = row.GetValue<int>("campo1");
        //        // Do something with the value 
        //        var texto = row.GetValue<string>("campo2");
        //        // Do something with the value 

        //        MessageBox.Show(texto, value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //        /*
        //        RowSet rsUsers = session.Execute(qry);

        //        ////////////////////////////////////////////////
        //        var users = new List<UserModel>();
        //        foreach (var userRow in rsUsers)
        //        {
        //            //users.Add(ReflectionTools.GetSingleEntryDynamicFromReader<UserModel>(userRow));
        //        }

        //        foreach (UserModel user in users)
        //        {
        //            Console.WriteLine("{0} {1} {2} {3} {4}", user.Id, user.FirstName, user.LastName, user.Country, user.IsActive);
        //        }
        //        */

        //    }
        //}

    }
}
