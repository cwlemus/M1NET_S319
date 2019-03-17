using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1_NETS319
{
    class M1NET_S319_EJ4
    {
        static void Main(string[] args)
        {
            var Toyota = new AutoMovil(4,2018,15000);
            Console.WriteLine("Automovil con impuesto : {0:c}",Toyota.pre);
            Console.ReadLine();
        }
    }

    class AutoMovil : Vehiculo
    {
        internal int capacidad;
        internal int anyo;
        internal decimal pre;
        public AutoMovil() { }
        public AutoMovil(int cap, int anyo, decimal pre)
        {
            this.capacidad = cap;
            this.anyo = anyo;
            this.pre = base.calPrecio(pre);
        }
    }
    
}
