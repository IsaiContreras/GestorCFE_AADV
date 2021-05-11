using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
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

        public byte Login_Admin(ref LogAdmin param)
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
                            param.id_adm = row2.GetValue<Guid>("id_admin");
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

        public byte Login_Empleado(ref LogEmpleado param)
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
                                    param.num_emp = row2.GetValue<Guid>("num_empleado");
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

        public byte LoginCliente(ref LogCliente param)
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
                                    param.id_cl = row2.GetValue<Guid>("id_cliente");
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
