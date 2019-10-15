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
            StoredProcedureParameters inputParameters = new StoredProcedureParameters()
                .AddParameter("@id_usuario", idUsuario);

                return new Conexion()
                    .ExecMappedStoredProcedure<Rol>(StoredProcedures.RolesDeUsuario, inputParameters, new Mapper.AutoMapper<Rol>());
        }
    }
}
