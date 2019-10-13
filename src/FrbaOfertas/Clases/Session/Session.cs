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
        public string loggedUsername { get; private set; }

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

        public void OpenSession(string username)
        {
            loggedUsername = username;
        }

        public void CloseSession()
        {
            instance = null;
        }
    }
}
