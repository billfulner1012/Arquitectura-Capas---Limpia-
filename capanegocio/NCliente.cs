using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capanegocio;
using System.Data;
using capadatos;

namespace capanegocio
{
    public class NCliente
    {

        public static string insertarcliente(string nombre, string apellidos,string sexo,DateTime fechanacimiento,
            string tipodocumento,string documento,string direccion
            )
        {
            DCliente objeto = new DCliente();
            objeto.Nombre = nombre;
            objeto.Apellidos = apellidos;
            objeto.Sexo = sexo;
            objeto.Fechanacimiento = fechanacimiento;
            objeto.Tipodocumento = tipodocumento;
            objeto.Documento = documento;
            objeto.Direccion = direccion;

            return objeto.insertarcliente(objeto);
        }

        public static string editarcliente(int idcliente,string nombre, string apellidos, string sexo, DateTime fechanacimiento,
    string tipodocumento, string documento, string direccion
    )
        {
            DCliente objeto = new DCliente();
            objeto.Idcliente = idcliente;
            objeto.Nombre = nombre;
            objeto.Apellidos = apellidos;
            objeto.Sexo = sexo;
            objeto.Fechanacimiento = fechanacimiento;
            objeto.Tipodocumento = tipodocumento;
            objeto.Documento = documento;
            objeto.Direccion = direccion;

            return objeto.editarcliente(objeto);
        }

        public static string eliminarcliente(int idcliente
   )
        {
            DCliente objeto = new DCliente();
            objeto.Idcliente = idcliente;
       

            return objeto.eliminarcliente(objeto);
        }

        public static DataTable mostrarcliente(
  )
        {
            DCliente objeto = new DCliente();
            return objeto.mostrarclientes();
        }

        public static DataTable buscarclientenombre(string textobuscar
  )
        {
            DCliente objeto = new DCliente();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarclientesnombre(objeto);
        }

        public static DataTable buscarclienteapellidos(string textobuscar
  )
        {
            DCliente objeto = new DCliente();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarclientesapellidos(objeto);
        }

    }
}
