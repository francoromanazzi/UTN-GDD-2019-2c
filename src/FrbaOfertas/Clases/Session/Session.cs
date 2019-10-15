using FrbaOfertas.Clases.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Session
{
    class Session
    {
        private static Session instance;
        public int IdUsuario { get; private set; }

        static Session()
        {
        }

        private Session()
        {
        }

        public static Session Instance
        {
            get
            {
                if (instance == null)
                    instance = new Session();
                return instance;
            }
        }

        public void OpenSession(int idUsuario)
        {
            this.IdUsuario = idUsuario;
        }

        public void CloseSession()
        {
            instance = null;
        }
    }
}
