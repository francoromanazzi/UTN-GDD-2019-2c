using FrbaOfertas.Clases.Constantes;
using FrbaOfertas.Clases.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Repositorios
{
    class RepositorioOfertas
    {
        public void Guardar(
            DateTime fechaPublicacion,
            DateTime fechaVencimiento,
            double precioOferta,
            double precioLista,
            int stockDisponible,
            int maxUnidadesPorCliente,
            string codigo,
            string descripcion,
            int idProveedor
            )
        {
            StoredProcedureParameters parameters = new StoredProcedureParameters()
                .AddParameter("@fecha_publicacion", fechaPublicacion)
                .AddParameter("@fecha_vencimiento", fechaVencimiento)
                .AddParameter("@precio_en_oferta", precioOferta)
                .AddParameter("@precio_de_lista", precioLista)
                .AddParameter("@cant_disponible", stockDisponible)
                .AddParameter("@max_unidades_por_cliente", maxUnidadesPorCliente)
                .AddParameter("@codigo_oferta", codigo)
                .AddParameter("@descripcion", descripcion)
                .AddParameter("@id_proveedor", idProveedor);
            ;

            new Conexion().ExecStoredProcedure(StoredProcedures.GuardarOferta, parameters);

        }
    }
}
