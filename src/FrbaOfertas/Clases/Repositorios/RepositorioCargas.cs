using FrbaOfertas.Clases.Constantes;
using FrbaOfertas.Clases.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Repositorios
{
    class RepositorioCargas
    {
        public void Guardar(int monto, string medioPago, int idTarjeta)
        {
            int idCliente = new RepositorioClientes().ObtenerIdClienteDeUsuario(Session.Session.Instance.IdUsuario);

            DateTime fecha = DateTime.Parse(System.Configuration.ConfigurationManager.AppSettings["FechaSistema"]);

            StoredProcedureParameters parametros = new StoredProcedureParameters()
                .AddParameter("@id_cliente", idCliente)
                .AddParameter("@fecha", fecha)
                .AddParameter("@medio_pago", medioPago)
                .AddParameter("@monto", monto);

            if (idTarjeta != -1)
                parametros.AddParameter("@id_tarjeta", idTarjeta);
            else
                parametros.AddParameter("@id_tarjeta", DBNull.Value);

            new Conexion().ExecStoredProcedure(StoredProcedures.CargarCredito, parametros);
        }
    }
}
