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

        public const string GuardarOferta = Schema + "SP_Guardar_Oferta";

        #region ABM Cliente

        public const string AltaCliente = Schema + "SP_Cargar_Cliente";

        public const string ActualizarCliente = Schema + "SP_Actualizar_Cliente";

        #endregion

        #region ABM Usuario

        public const string EliminarUsuario = Schema + "SP_Baja_Usuario";

        public const string AltaUsuario = Schema + "SP_Alta_Usuario";

        #endregion

        #region ABM Proveedor

        public const string AltaProveedor = Schema + "SP_Cargar_Proveedor";

        public const string ModificarProveedor = Schema + "SP_Modificar_Proveedor";

        #endregion

        #region ABM Rol

        public const string AltaRol = Schema + "SP_Alta_Rol";
        public const string AltaRolOutput = "@id_rol";

        public const string AgregarFuncionalidadRol = Schema + "SP_Agregar_Funcionalidad_Rol";

        public const string QuitarFuncionalidadRol = Schema + "SP_Quitar_Funcionalidad_Rol";
        
        public const string ModificarRol = Schema + "SP_Modificar_Rol";

        public const string BajaRol = Schema + "SP_Baja_Rol";

        #endregion

    }
}
