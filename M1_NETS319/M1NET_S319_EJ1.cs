using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1_NETS319
{
    class M1NET_S319_EJ1
    {
        static void Main(string[] args)
        {
            Vehiculo[] toyota = new Vehiculo[2];
            toyota[0] = new Vehiculo(3500);
            toyota[1] = new Vehiculo(5900);
            for (int i = 0; i < toyota.Length; i++)
            {
                Console.WriteLine("valor de vehiculo {0}: {1:C}",(i+1),toyota[i].precio);
            }
            Console.ReadLine();
        }
    }
    class Vehiculo
    {
        internal decimal precio;
        public Vehiculo()
        {

        }
        public Vehiculo(decimal precio)
        {
            this.precio = precio;
        }
        /*public override string ToString()
        {
            return this.precio.ToString();
        }*/

        public decimal calPrecio(decimal c)
        {
            return this.precio = (c * 0.10m) + c;
        }
    }
}
