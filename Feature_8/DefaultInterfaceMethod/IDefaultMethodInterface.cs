using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultInterfaceMethod
{
    internal interface IDefaultMethodInterface
    {
        void MustInplementMethod();

        public void DefaulttMethod()
        {
            Console.WriteLine("This is from default method");
        }
    }
}
