using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S319_OVERRIDE
{
    class M1NET_S319_EJ1
    {
        static void Main(string[] args)
        {
            var Carro = new Vehiculo()
            {
                modelo = "Yaris",
                marca = "Toyota",
                anyo = 2018
            };
            Console.WriteLine(Carro);
            Console.ReadLine();
        }
    }
    class Vehiculo
    {
        internal string marca;
        internal string modelo;
        internal int anyo;

        public override string ToString()
        {
            return String.Format("Vehiculo con las siguientes caracteristicas:" +
                " \n\t\t\t\t\t\t Marca: {0}\n\t\t\t\t\t\t " +
                "Modelo: {1}\n\t\t\t\t\t\t Año: {2}",this.marca,this.modelo,this.anyo);
        }
    }
}
