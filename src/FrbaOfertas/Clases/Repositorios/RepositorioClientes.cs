using FrbaOfertas.Clases.Database;
using System;
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
    }
}
