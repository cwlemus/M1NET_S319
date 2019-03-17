using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1_NETS319
{
    class M1NET_S319_EJ2
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Method1();
        }
    }
    public class B : A
    {

    }
    public class A
    {
        public void Method1()
        {
            Console.WriteLine("Ejecutando medotodo..");
        }
    }

}
