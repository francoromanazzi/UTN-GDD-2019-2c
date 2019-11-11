using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Database
{
    class StoredProcedureParameters
    {
        private IDictionary<string, object> parametersMap;

        public StoredProcedureParameters() 
        {
            parametersMap = new Dictionary<string, object>();
        }

        public StoredProcedureParameters AddParameter(string key, object value)
        {
            parametersMap.Add(key, value);
            return this;
        }

        public void AddParametersToCommand(SqlCommand command)
        {
            foreach (KeyValuePair<string, object> item in parametersMap)
            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
        }

        public void RemoveParameters()
        {
            parametersMap.Clear();
            return;
        }
    }
}
