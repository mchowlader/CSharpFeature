using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultInterfaceMethod
{
    internal class AnyClass : IDefaultMethodInterface
    {
        public void MustInplementMethod()
        {
            Console.WriteLine("Implement by default");
        }
    }
}
