using FrbaOfertas.Clases.Constantes;
using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Repositorios
{
    class RepositorioRoles
    {
        public IList<Rol> ObtenerRolesDeUsuario(int idUsuario)
        {
                return new Conexion()
                    .ExecMappedSqlQuery<Rol>("SELECT r.* " +
                                           "FROM LOS_BORBOTONES.Roles r " +
                                           "JOIN LOS_BORBOTONES.RolesXUsuarios rxu ON r.id_rol = rxu.id_rol " +
                                           "JOIN  LOS_BORBOTONES.Usuarios u ON u.id_usuario = rxu.id_usuario " +
                                           "WHERE u.id_usuario = " + idUsuario + " " +
                                           "AND r.habilitado = 1" +
                                            ";"
                                , new Mapper.AutoMapper<Rol>());
        }
    }
}
