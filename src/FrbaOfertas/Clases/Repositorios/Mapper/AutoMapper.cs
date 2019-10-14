using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Repositorios.Mapper
{
    class AutoMapper<T> : IStoredProcedureResultMapper<T>
    {
        public IList<T> Map(DataTable dataTable)
        {
            IList<T> mappedRows = new List<T>();
            FieldInfo[] fields = typeof(T).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            if (fields.Length != dataTable.Columns.Count)
            {
                throw new AutoMappingException("Error al intentar mapear el resultado de un DataTable contra una clase. La cantidad de columnas retornadas no coinciden con la cantidad de atributos.");
            }

            foreach (DataRow row in dataTable.Rows)
            {
                T mapped = Activator.CreateInstance<T>();

                for (int i = 0; i < fields.Length; i++)
                {
                    fields[i].SetValue(mapped, row[i]);
                }

                mappedRows.Add(mapped);
            }

            return mappedRows;
        }
    }
}
