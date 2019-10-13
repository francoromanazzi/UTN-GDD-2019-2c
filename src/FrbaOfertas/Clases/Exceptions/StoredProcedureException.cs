using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Exceptions
{
    class StoredProcedureException : Exception
    {
        public StoredProcedureException(string message) : base(message) { }

        public StoredProcedureException(string message, Exception innerException) : base(message, innerException) { }

    }
}
