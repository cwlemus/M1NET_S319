using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S319_ABSTRACT
{
    class M1NET_S319_EJ2
    {
        static void Main(string[] args)
        {
            var perro = new Perro();
            var perroRobot = new RoboPerro();
            perro.caracteristicas();
            perroRobot.caracteristicas();
        }
    }

    interface IRoboMascota
    {
        void jugar();
        void limpiar();
    }

    class RoboPerro : IRoboMascota
    {
        public void jugar()
        {
            Console.WriteLine("Encender luces ...");
        }

        public void limpiar()
        {
            Console.WriteLine("Realizar engrasado de piezas...");
        }

        public void cargar()
        {
            Console.WriteLine("Cargando ...");
        }

        public void caracteristicas()
        {
            Console.WriteLine("Mis cuidados");
            this.limpiar();
            this.jugar();
            this.cargar();
        }
    }

    class Perro : Animal,IRoboMascota
    {
        public override void Eat()
        {
            Console.WriteLine("Comiendo Pedigree ...");
        }

        public void jugar()
        {
            Console.WriteLine("Atrapa la pelota ....");
        }

        public void limpiar()
        {
            Console.WriteLine("Tamando baño ...");
        }
        public void caracteristicas()
        {
            Console.WriteLine("Mis cuidados");
            this.limpiar();
            this.jugar();
            this.Eat();
        }
    }
}
