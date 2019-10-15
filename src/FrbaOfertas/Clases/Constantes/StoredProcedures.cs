using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Constantes
{
    class StoredProcedures
    {
        private const string Schema = "LOS_BORBOTONES.";

        public const string ValidarLogin = Schema + "SP_Validar_Login";
        public const string ValidarLoginOutput = "@login_correcto";

        public const string RolesDeUsuario = Schema + "SP_Roles_De_Usuario";

        public const string FuncionalidadesDeRol = Schema + "SP_Funcionalidades_De_Rol";

        public const string TarjetasDelCliente = Schema + "SP_Tarjetas_Del_Cliente";
    }
}
