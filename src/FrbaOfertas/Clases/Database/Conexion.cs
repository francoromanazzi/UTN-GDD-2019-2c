﻿using FrbaOfertas.Clases.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Database
{
    class Conexion
    {
        private SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);
        }

        public TOutput ExecSingleOutputStoredProcedure<TOutput>(string procedureName, StoredProcedureParameters parameters, string outputParameterName)
        {
            using (SqlConnection sqlConnection = GetSqlConnection())
            using (SqlCommand command = new SqlCommand(procedureName, sqlConnection))
            {
                sqlConnection.Open();

                command.CommandType = CommandType.StoredProcedure;

                parameters.AddParametersToCommand(command);

                command.Parameters.Add(outputParameterName, SqlDbTypes.Of(typeof(TOutput))).Direction = ParameterDirection.Output;

                try
                {
                    command.ExecuteNonQuery();
                    return (TOutput) command.Parameters[outputParameterName].Value;
                }
                catch (SqlException e)
                {
                    throw new StoredProcedureException(e.Message, e);
                }
            }
        }

        public IList<TMapped> ExecMappedStoredProcedure<TMapped>(string procedureName, StoredProcedureParameters inputParameters, IStoredProcedureResultMapper<TMapped> mapper)
        {
            DataTable result = this.ExecDataTableStoredProcedure(procedureName, inputParameters);
            return mapper.Map(result);
        }

        public DataTable ExecDataTableStoredProcedure(string procedureName, StoredProcedureParameters parameters)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = GetSqlConnection())
            using (SqlCommand command = new SqlCommand(procedureName, sqlConnection))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                sqlConnection.Open();

                command.CommandType = CommandType.StoredProcedure;

                parameters.AddParametersToCommand(command);

                try
                {
                    dataAdapter.Fill(dataTable);
                }
                catch (SqlException e)
                {
                    throw new StoredProcedureException(e.Message, e);
                }

            }

            return dataTable;
        }
    }
}
