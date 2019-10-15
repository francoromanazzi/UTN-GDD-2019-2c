using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Modelo
{
    public class Tarjeta
    {
        public int IdTarjeta { get; set; }
        public int IdCliente { get; set; }
        public string Tipo { get; set; }
        public string Codigo { get; set; }
    }
}
