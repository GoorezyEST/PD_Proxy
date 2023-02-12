using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_PD
{
    // The RealSubject class represents the actual object that the client wants to interact with
    public class RealSubject : Subject
    {
        public string Request()
        {
            return "RealSubject";
        }
    }

}
