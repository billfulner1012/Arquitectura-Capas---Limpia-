using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace capadatos
{
    public class DCliente
    {

        private int _idcliente;
        private string _nombre;
        private string _apellidos;
        private string _sexo;
        private DateTime _fechanacimiento;
        private string _tipodocumento;
        private string _documento;
        private string _direccion;
        private string _textobuscar;

        public int Idcliente { get => _idcliente; set => _idcliente = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public DateTime Fechanacimiento { get => _fechanacimiento; set => _fechanacimiento = value; }
        public string Tipodocumento { get => _tipodocumento; set => _tipodocumento = value; }
        public string Documento { get => _documento; set => _documento = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        public DCliente()
        {
        }

        public DCliente(int idcliente, string nombre, string apellidos, string sexo, DateTime fechanacimiento, string tipodocumento, string documento,string direccion, string textobuscar)
        {
            Idcliente = idcliente;
            Nombre = nombre;
            Apellidos = apellidos;
            Sexo = sexo;
            Fechanacimiento = fechanacimiento;
            Tipodocumento = tipodocumento;
            Documento = documento;
            Direccion = direccion;
            Textobuscar = textobuscar;
        }


        public string insertarcliente(DCliente cliente)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";
                ParIdcliente.SqlDbType =SqlDbType.Int ;
                ParIdcliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcliente);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = cliente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellido";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 80;
                ParApellidos.Value = cliente.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = cliente.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParFechanac = new SqlParameter();
                ParFechanac.ParameterName = "@fecha_nacimiento";
                ParFechanac.SqlDbType = SqlDbType.DateTime;
                ParFechanac.Value = cliente.Fechanacimiento;
                SqlCmd.Parameters.Add(ParFechanac);

                SqlParameter Partipodocumento = new SqlParameter();
                Partipodocumento.ParameterName = "@tipodocumento";
                Partipodocumento.SqlDbType = SqlDbType.VarChar;
                Partipodocumento.Size = 12;
                Partipodocumento.Value = cliente.Tipodocumento;
                SqlCmd.Parameters.Add(Partipodocumento);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 11;
                ParDocumento.Value = cliente.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 250;
                ParDireccion.Value = cliente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se pudo insertar";


                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return rpta;

        }


        public string editarcliente(DCliente cliente)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = cliente.Idcliente;
                SqlCmd.Parameters.Add(ParIdcliente);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = cliente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellido";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 80;
                ParApellidos.Value = cliente.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = cliente.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParFechanac = new SqlParameter();
                ParFechanac.ParameterName = "@fecha_nacimiento";
                ParFechanac.SqlDbType = SqlDbType.DateTime;
                ParFechanac.Value = cliente.Fechanacimiento;
                SqlCmd.Parameters.Add(ParFechanac);

                SqlParameter Partipodocumento = new SqlParameter();
                Partipodocumento.ParameterName = "@tipodocumento";
                Partipodocumento.SqlDbType = SqlDbType.VarChar;
                Partipodocumento.Size = 12;
                Partipodocumento.Value = cliente.Tipodocumento;
                SqlCmd.Parameters.Add(Partipodocumento);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 11;
                ParDocumento.Value = cliente.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 250;
                ParDireccion.Value = cliente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se actualizo el registro";


                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return rpta;
        }


        public string eliminarcliente(DCliente cliente)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = cliente.Idcliente;
                SqlCmd.Parameters.Add(ParIdcliente);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se elimino el registro";


                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return rpta;
        }


        public DataTable mostrarclientes()
        {
            DataTable dtresultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return dtresultado;

        }

        public DataTable buscarclientesnombre(DCliente cliente)
        {
            DataTable dtresultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cliente_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter Partextobuscar = new SqlParameter();
                Partextobuscar.ParameterName = "@textobuscar";
                Partextobuscar.SqlDbType = SqlDbType.VarChar;
                Partextobuscar.Size = 100;
                Partextobuscar.Value = cliente.Textobuscar;
                SqlCmd.Parameters.Add(Partextobuscar);

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return dtresultado;

        }

        public DataTable buscarclientesapellidos(DCliente cliente)
        {
            DataTable dtresultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cliente_apellidos";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter Partextobuscar = new SqlParameter();
                Partextobuscar.ParameterName = "@textobuscar";
                Partextobuscar.SqlDbType = SqlDbType.VarChar;
                Partextobuscar.Size = 100;
                Partextobuscar.Value = cliente.Textobuscar;
                SqlCmd.Parameters.Add(Partextobuscar);

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return dtresultado;

        }

    }
}
