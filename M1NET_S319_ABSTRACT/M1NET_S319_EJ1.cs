using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S319_ABSTRACT
{
    class M1NET_S319_EJ1
    {
        static void Main(string[] args)
        {
            Pet p = new Dog();
            p.Eat();
            p.ActividadRecreativa();
            Console.ReadLine();
        }
    }
    abstract class Animal
    {
        abstract public void Eat();
    }
    class Pet : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Comiendo ...");
        }
        public void ActividadRecreativa()
        {
            Console.WriteLine("Paseando ...");
        }
    }
    class Dog : Pet
    {
        public Dog()
        {
            Console.WriteLine("Ladrando ...");
        }
    }
}
