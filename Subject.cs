using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_PD
{
    // The Subject interface defines the interface that the client uses to interact with the RealSubject
    public interface Subject
    {
        string Request();
    }
}
