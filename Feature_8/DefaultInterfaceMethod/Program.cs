using System;

namespace DefaultInterfaceMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDefaultMethodInterface newFeature = new AnyClass();

            newFeature.MustInplementMethod();
            newFeature.DefaulttMethod();
        }
    }
}
