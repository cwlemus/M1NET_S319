using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S319_OVERRIDE
{
    class M1NET_S319_EJEMPLO
    {
        static void Main(string[] args)
        {
            Prueba p = new Prueba();
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }

    class Prueba
    {
        public override string ToString()
        {
            return string.Format("Esta es una instancia de prueba....");
        }
    }
}
