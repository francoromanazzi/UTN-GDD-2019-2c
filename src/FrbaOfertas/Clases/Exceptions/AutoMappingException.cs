using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Exceptions
{
    class AutoMappingException : Exception
    {
        public AutoMappingException(string message) : base(message) { }

        public AutoMappingException(string message, Exception innerException) : base(message, innerException) { }
    }
}
