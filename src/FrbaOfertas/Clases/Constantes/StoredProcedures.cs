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

        public const string CargarCredito = Schema + "SP_Cargar_Credito";

        public const string GuardarOferta = Schema + "SP_Guardar_Oferta";

        public const string ComprarOferta = Schema + "SP_Comprar_Oferta";

        public const string MostrarOfertasValidasParaUnaFecha = Schema + "SP_Mostrar_Ofertas_Validas_Para_Fecha";

        public const string MostrarComprasCanjeablesDelProveedor = Schema + "SP_Mostrar_Compras_Canjeables_Del_Proveedor";

        public const string CanjearCompra = Schema + "SP_Canjear_Compra";
        
        #region ABM Cliente

        public const string AltaCliente = Schema + "SP_Cargar_Cliente";

        public const string ActualizarCliente = Schema + "SP_Actualizar_Cliente";

        public const string AltaClienteDesdeRegistroUsuario = Schema + "SP_Registro_Usuario_Cliente";

        #endregion

        #region ABM Usuario

        public const string EliminarUsuario = Schema + "SP_Baja_Usuario";

        public const string AltaUsuario = Schema + "SP_Alta_Usuario";

        public const string VerificarUsername = Schema + "SP_Validar_Usuario_Existente";
        public const string AgregarRolAlUsuario = Schema + "SP_Agregar_Rol_Al_Usuario";

        public const string CambiarPasswordUsuario = Schema + "SP_Cambiar_Password_Usuario";

        #endregion

        #region ABM Proveedor

        public const string AltaProveedor = Schema + "SP_Cargar_Proveedor";

        public const string ModificarProveedor = Schema + "SP_Modificar_Proveedor";

        public const string AltaProveedorDesdeRegistroUsuario = Schema + "SP_Registro_Usuario_Proveedor";

        #endregion

        #region ABM Rol

        public const string AltaRol = Schema + "SP_Alta_Rol";
        public const string AltaRolOutput = "@id_rol";

        public const string AgregarFuncionalidadRol = Schema + "SP_Agregar_Funcionalidad_Rol";

        public const string QuitarFuncionalidadRol = Schema + "SP_Quitar_Funcionalidad_Rol";
        
        public const string ModificarRol = Schema + "SP_Modificar_Rol";

        public const string BajaRol = Schema + "SP_Baja_Rol";

        #endregion

        #region Listado estatico

        public const string ListProveMayDesc = Schema + "SP_ProveedoresMayorDescuento";
        public const string ListProveMayFact = Schema + "SP_ProveedoresMayorFacturacion";
        #endregion

        #region Facturacion al proveedor

        public const string CargarFactura = Schema + "SP_Cargar_Factura";
        public const string MostrarListado = Schema + "SP_Mostrar_Listado";

        #endregion

    }
}
