using FrbaOfertas.Clases.Database;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Repositorios
{
    class RepositorioClientes
    {
        public int ObtenerIdClienteDeUsuario(int idUsuario)
        {
            return new Conexion()
                .ExecSingleOutputSqlQuery<int>("SELECT id_cliente FROM LOS_BORBOTONES.Clientes c " +
                                               "JOIN LOS_BORBOTONES.Usuarios u ON u.id_usuario = c.id_usuario " +
                                               "WHERE u.id_usuario = " + idUsuario);
        }

        public DataTable BuscarCliente(string nombre, string apellido, string dni, string email)
        {
            // Query principal
            string query = "SELECT nombre, apellido, dni, mail, telefono, direccion, piso, departamento, localidad, codigo_postal, fecha_nacimiento, id_cliente FROM LOS_BORBOTONES.Clientes WHERE ";
            //Lista de Condiciones
            List<string> condiciones = new List<string>();

            if (nombre != "")
            {
                condiciones.Add("nombre LIKE " + "'%" + nombre + "%'");
            }
            if (apellido != "")
            {
                condiciones.Add("apellido LIKE " + "'%" + apellido + "%'");
            }
            if (dni != "")
            {
                condiciones.Add("dni = " + dni);
            }
            if (email != "")
            {
                condiciones.Add("mail LIKE " + "'%" + email + "%'");
            }

            // Agrego las condiciones a la query principal
            for (int i = 0; i < condiciones.Count; i++)
            {
                query += condiciones.ToArray()[i];

                if (i != condiciones.Count - 1)
                {
                    query += " AND ";
                }
            }

            // Ejecuto la query
            return new Conexion().ExecDataTableSqlQuery(query);
        }
    }
}
