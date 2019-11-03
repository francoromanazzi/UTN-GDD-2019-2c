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
        public const string ValidarLoginOutput = "@id_usuario";
        public const string AltaCliente = Schema + "SP_Cargar_Cliente"; // No hecha
    }
}
