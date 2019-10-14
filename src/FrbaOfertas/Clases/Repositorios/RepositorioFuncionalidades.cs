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
            StoredProcedureParameters inputParameters = new StoredProcedureParameters()
                .AddParameter("@idRol", idRol);

            return new Conexion()
                    .ExecMappedStoredProcedure<Funcionalidad>(StoredProcedures.FuncionalidadesDeRol, inputParameters, new Mapper.AutoMapper<Funcionalidad>());

        }
    }
}
