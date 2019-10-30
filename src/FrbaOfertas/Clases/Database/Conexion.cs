using FrbaOfertas.Clases.Exceptions;
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

        #region Stored procedures

        public TOutput ExecSingleOutputStoredProcedure<TOutput>(string procedureName, StoredProcedureParameters parameters, string outputParameterName)
        {
            using (SqlConnection sqlConnection = GetSqlConnection())
            using (SqlCommand command = new SqlCommand(procedureName, sqlConnection))
            {
                sqlConnection.Open();

                command.CommandType = CommandType.StoredProcedure;

                parameters.AddParametersToCommand(command);

                command.Parameters.Add(outputParameterName, SqlDbTypes.Of(typeof(TOutput))).Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                return (TOutput) command.Parameters[outputParameterName].Value;

            }
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

                dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        public IList<TMapped> ExecMappedStoredProcedure<TMapped>(string procedureName, StoredProcedureParameters inputParameters, IStoredProcedureResultMapper<TMapped> mapper)
        {
            DataTable result = this.ExecDataTableStoredProcedure(procedureName, inputParameters);
            return mapper.Map(result);
        }

        #endregion

        #region Queries

        public void ExecSqlQuery(string query)
        {
            using (SqlConnection sqlConnection = GetSqlConnection())
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                sqlConnection.Open();

                command.CommandType = CommandType.Text;

                command.ExecuteNonQuery();
            }
        }

        public TOutput ExecSingleOutputSqlQuery<TOutput>(string query)
        {
            using (SqlConnection sqlConnection = GetSqlConnection())
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                sqlConnection.Open();

                command.CommandType = CommandType.Text;

                return (TOutput) command.ExecuteScalar();
            }
        }

        public DataTable ExecDataTableSqlQuery(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlConnection = GetSqlConnection())
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            using (SqlDataAdapter da = new SqlDataAdapter(command))
            {
                sqlConnection.Open();

                command.CommandType = CommandType.Text;

                da.Fill(dt);

                return dt;
            }
        }

        public IList<TMapped> ExecMappedSqlQuery<TMapped>(string query, IStoredProcedureResultMapper<TMapped> mapper)
        {
            DataTable result = this.ExecDataTableSqlQuery(query);
            return mapper.Map(result);
        }

        #endregion
    }
}
