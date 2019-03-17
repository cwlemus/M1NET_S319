using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S319_POLIMORFISMO
{
    class M1NET_S319_EJ2
    {
        static void Main(string[] args)
        {
            Pet p = new Pet();
            Dog d = new Dog();
            Gato g = new Gato();

            p.msgGeneral(d);
            p.msgGeneral(g);
            Console.ReadLine();
        }
    }
    abstract class Animal
    {
        public abstract void hacerRuido();
    }
    class Dog : Animal
    {
        public override void hacerRuido()
        {
            Console.WriteLine("Ladrando ...");
        }
    }
    class Gato : Animal
    {
        public override void hacerRuido()
        {
            Console.WriteLine("Miagando ...");
        }
    }
    class Pet
    {
        public void msgGeneral(Animal a)
        {
            a.hacerRuido();
        }
    }
}
