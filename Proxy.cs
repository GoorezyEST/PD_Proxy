using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_PD
{
    // The Proxy class represents an object that acts as a substitute for the RealSubject
    public class Proxy : Subject
    {
        private RealSubject? realSubject;

        public string Request()
        {
            // Lazy initialization: the RealSubject is only created if the client requests it
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }

            return realSubject.Request();
        }
    }
}
