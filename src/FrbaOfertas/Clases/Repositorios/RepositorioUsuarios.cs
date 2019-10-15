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
        public Boolean ExisteUsernameYPassword(string username, string password)
        {
            StoredProcedureParameters parameters = new StoredProcedureParameters()
                .AddParameter("@username", username)
                .AddParameter("@password", password);

            return new Conexion().ExecSingleOutputStoredProcedure<Boolean>(StoredProcedures.ValidarLogin, parameters, StoredProcedures.ValidarLoginOutput);
        }

        public int ObtenerIdUsuarioDeUsername(string username)
        {
            return new Conexion()
                .ExecSingleOutputSqlQuery<int>("SELECT id_usuario FROM LOS_BORBOTONES.Usuarios WHERE username = " + username);
        }
    }
}
