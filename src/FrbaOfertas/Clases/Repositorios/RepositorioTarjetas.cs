﻿using FrbaOfertas.Clases.Constantes;
using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Modelo;
using FrbaOfertas.Clases.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Repositorios
{
    class RepositorioTarjetas
    {
        public void Guardar(string tipoTarjeta, string codigoTarjeta)
        {
            int idCliente = new RepositorioClientes().ObtenerIdClienteDeUsuario(Session.Session.Instance.IdUsuario);

            new Conexion().ExecSqlQuery("INSERT INTO LOS_BORBOTONES.Tarjetas " +
                        "(id_cliente, tipo, codigo) " +
                        "VALUES " +
                        "(" + idCliente + ", " + "'" + tipoTarjeta + "'" + ", " + "'" + codigoTarjeta + "'" + ")" +
                        ";"
                        );
        }

        public IList<Tarjeta> ObtenerTarjetasDelCliente(int idCliente)
        {
            return new Conexion()
                .ExecMappedSqlQuery<Tarjeta>("SELECT * " +
                                       "FROM LOS_BORBOTONES.Tarjetas " +
                                       "WHERE id_cliente = " + idCliente +
                                        ";"
                            , new Mapper.AutoMapper<Tarjeta>());
        }
    }
}
