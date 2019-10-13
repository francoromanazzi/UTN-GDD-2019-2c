using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Database
{
    class SqlDbTypes
    {
        private static IDictionary<Type, System.Data.SqlDbType> sqlDbTypes;

        static SqlDbTypes()
        {
            sqlDbTypes = new Dictionary<Type, SqlDbType>();
            sqlDbTypes.Add(typeof(string), SqlDbType.NVarChar);
            sqlDbTypes.Add(typeof(int), SqlDbType.Int);
            sqlDbTypes.Add(typeof(decimal), SqlDbType.Decimal);
            sqlDbTypes.Add(typeof(Boolean), SqlDbType.Bit);
            sqlDbTypes.Add(typeof(DateTime), SqlDbType.DateTime);
        }

        public static SqlDbType Of(Type type)
        {
            return sqlDbTypes[type];
        }
    }
}
