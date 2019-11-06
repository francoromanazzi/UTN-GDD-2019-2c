using FrbaOfertas.Clases.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Repositorios
{
    class RepositorioProveedores
    {
        public int ObtenerIdProveedorDeUsuario(int idUsuario)
        {
            return new Conexion()
                .ExecSingleOutputSqlQuery<int>("SELECT id_proveedor FROM LOS_BORBOTONES.Proveedores p " +
                                               "JOIN LOS_BORBOTONES.Usuarios u ON u.id_usuario = p.id_usuario " +
                                               "WHERE u.id_usuario = " + idUsuario);
        }
    }
}
