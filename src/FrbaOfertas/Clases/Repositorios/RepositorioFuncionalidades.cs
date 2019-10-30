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
    class RepositorioFuncionalidades
    {
        public IList<Funcionalidad> FuncionalidadesDeUnRol(int idRol)
        {
            return new Conexion()
                    .ExecMappedSqlQuery<Funcionalidad>("SELECT f.* " +
                                                       "FROM LOS_BORBOTONES.Funcionalidades f " + 
                                                       "JOIN LOS_BORBOTONES.FuncionalidadesXRoles fxr ON f.id_funcionalidad = fxr.id_funcionalidad " + 
                                                       "WHERE fxr.id_rol = " + idRol +
                                                        ";"
                                            , new Mapper.AutoMapper<Funcionalidad>());
        }
    }
}
