using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S319_POLIMORFISMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Transporte[] transporte = new Transporte[2];
            transporte[0] = new Barco();
            transporte[1] = new Bicicleta();
            foreach (var item in transporte)
            {
                item.TipoDesplazamiento();
            }
            Console.ReadLine();
        }
    }
    abstract class Transporte
    {
        //public decimal costo=0;
        public abstract void TipoDesplazamiento();
    }

    class Barco : Transporte
    {
        public override void TipoDesplazamiento()
        {
            Console.WriteLine("Desplazando a vapor por agua ....");
        }
    }

    class Bicicleta : Transporte
    {
        public override void TipoDesplazamiento()
        {
            Console.WriteLine("Desplazando en carretera a fuerza de pierna ...");
        }
    }
}
