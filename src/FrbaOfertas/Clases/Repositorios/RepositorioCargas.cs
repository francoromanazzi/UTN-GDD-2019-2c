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

            string fecha = System.Configuration.ConfigurationManager.AppSettings["FechaSistema"];
            string fechaQuery = "CONVERT(DATETIME, '" + fecha + "', 121)";

            string idTarjetaQuery = idTarjeta != -1 ? idTarjeta.ToString() : "NULL";

            new Conexion().ExecSqlQuery("INSERT INTO LOS_BORBOTONES.Cargas " +
                        "(id_cliente, fecha, medio_pago, monto, id_tarjeta) " +
                        "VALUES " +
                        "(" + idCliente + ", " + fechaQuery + ", " + "'" + medioPago + "'" + ", " + monto + ", " + idTarjetaQuery + ")" +
                        ";"
                        );
        }
    }
}
