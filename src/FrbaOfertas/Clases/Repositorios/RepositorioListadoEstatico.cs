using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Modelo;


namespace FrbaOfertas.Clases.Repositorios
{
    class RepositorioListadoEstatico
    {
        public IList<TablaProvedores> ObtenerListProvMayorFact( int anio,  int semestre)
        {
            return new Conexion()
                .ExecMappedSqlQuery<TablaProvedores>("execute SP_ProveedoresMayorFacturacion"
                    + anio +", "+ semestre +";"
                            , new Mapper.AutoMapper<TablaProvedores>());
        }

        public IList<TablaProvedores> ObtenerListProvMayorDesc(int anio, int semestre)
        {
            return new Conexion()
                .ExecMappedSqlQuery<TablaProvedores>("execute SP_ProveedoresMayorDescuento"
                    + anio + ", " + semestre + ";"
                            , new Mapper.AutoMapper<TablaProvedores>());
        }
    }
}
