using FrbaOfertas.Clases.Constantes;
using FrbaOfertas.Clases.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Repositorios
{
    class RepositorioUsuarios
    {
        public int ObtenerIdUsuarioAPartirDeCredenciales(string username, string password)
        {
            StoredProcedureParameters parameters = new StoredProcedureParameters()
                .AddParameter("@username", username)
                .AddParameter("@password", password);

            return new Conexion().ExecSingleOutputStoredProcedure<int>(StoredProcedures.ValidarLogin, parameters, StoredProcedures.ValidarLoginOutput);
        }
    }
}
