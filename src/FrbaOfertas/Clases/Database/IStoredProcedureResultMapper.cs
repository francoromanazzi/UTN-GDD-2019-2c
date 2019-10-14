using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Database
{
    interface IStoredProcedureResultMapper<TResult>
    {
        IList<TResult> Map(DataTable dataTable);
    }
}
