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

        public const string AltaCliente = Schema + "SP_Cargar_Cliente";

        public const string GuardarOferta = Schema + "SP_Guardar_Oferta";

        public const string ActualizarCliente = Schema + "SP_Actualizar_Cliente";

        public const string EliminarCliente = Schema + "SP_Baja_Cliente";

        public const string AltaUsuario = Schema + "SP_Alta_Usuario";

        public const string AltaProveedor = Schema + "SP_Cargar_Proveedor";

    }
}
