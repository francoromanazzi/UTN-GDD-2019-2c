﻿using FrbaOfertas.Clases.Constantes;
using FrbaOfertas.Clases.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Repositorios
{
    class RepositorioProveedores
    {
        public int ObtenerIdProveedorDeUsuario(int idUsuario)
        {
            return new Conexion()
                .ExecSingleOutputSqlQuery<int>("SELECT id_proveedor FROM LOS_BORBOTONES.Proveedores p " +
                                               "JOIN LOS_BORBOTONES.Usuarios u ON u.id_usuario = p.id_usuario " +
                                               "WHERE u.id_usuario = " + idUsuario);
        }

        public DataTable RealizarBusqueda(string mail, string telefono, string cuit, string direccion)
        {
            string query = "SELECT id_proveedor, mail, telefono, cuit, direccion, ciudad, codigo_postal, razon_social, rubro FROM LOS_BORBOTONES.Proveedores WHERE ";
            List<string> condiciones = new List<string>();

            if (mail != "")
            {
                condiciones.Add(" mail like " + "'%" + mail + "%'");
            }
            if (telefono != "")
            {
                condiciones.Add(" telefono like " + "'%" + telefono + "%'");
            }
            if (cuit != "")
            {
                condiciones.Add(" cuit like " + "'%" + cuit + "%'");
            }
            if (direccion != "")
            {
                condiciones.Add(" direccion like " + "'%" + direccion + "%'");
            }

            for (int i = 0; i < condiciones.Count; i++)
            {
                query += condiciones.ToArray()[i];

                if (i != condiciones.Count - 1) // No es el ultimo
                {
                    query += " AND ";
                }
            }

            return new Conexion().ExecDataTableSqlQuery(query);
        }

        public void Guardar(
                string inputRazonSocial,
                string inputTelefono,
                string inputMail,
                string inputDireccion,
                string inputPiso,
                string inputDepartamento,
                string inputLocalidad,
                string inputCodigoPostal,
                string inputCuit,
                string inputCiudad,
                string inputRubro,
                string inputNombreDeContacto
            )
        {
            // Armo el Store Procedure con los parametros REQUERIDOS
            StoredProcedureParameters parametros = new StoredProcedureParameters()
                .AddParameter("@razon_social", inputRazonSocial)
                .AddParameter("@mail", inputMail)
                .AddParameter("@telefono", decimal.Parse(inputTelefono))
                .AddParameter("@direccion", inputDireccion)
                .AddParameter("@ciudad", inputCiudad)
                .AddParameter("@cuit", inputCuit)
                .AddParameter("@rubro", inputRubro)
                .AddParameter("@nombre_contacto", inputNombreDeContacto);

            // Ahora me fijo si completo los campos no requeridos y lo agrego en caso que si
            // Piso
            if (inputPiso == "")
            {
                parametros.AddParameter("@piso", DBNull.Value); // Muy diferente de NULL 
            }
            else
            {
                parametros.AddParameter("@piso", inputPiso);
            }

            // Dpto
            if (inputDepartamento == "")
            {
                parametros.AddParameter("@departamento", DBNull.Value);
            }
            else
            {
                parametros.AddParameter("@departamento", inputDepartamento);
            }

            // Localidad
            if (inputLocalidad == "")
            {
                parametros.AddParameter("@localidad", DBNull.Value);
            }
            else
            {
                parametros.AddParameter("@localidad", inputLocalidad);
            }

            // Codigo Postal
            if (inputCodigoPostal == "")
            {
                parametros.AddParameter("@codigo_postal", DBNull.Value);
            }
            else
            {
                parametros.AddParameter("@codigo_postal", inputCodigoPostal);
            }

            new Conexion().ExecStoredProcedure(StoredProcedures.AltaProveedor, parametros);
        }
    }
}
