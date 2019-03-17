using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S319_ABSTRACT
{
    public class M1NET_S319_STATIC
    {
        static int numero1 = 0;
        static string generarCodigo(int dato)
        {
            return String.Format("{000:000}", dato);
        }
        static void Main(string[] args)
        {
            Prueba p=null;
       
            for (int i = 0; i < 1; i++)
            {
                p = new Prueba();
                Console.WriteLine("Nombre: ");
                p.Nombre = Console.ReadLine();
                p.Numero1++;
                Prueba.Numero2++;
            }
            Console.WriteLine("numero1: "+p.Numero1);
            Console.WriteLine("numero2: "+Prueba.Numero2);
            Console.WriteLine("codigo empleado: {0}",M1NET_S319_STATIC.generarCodigo(10));
            Console.ReadLine();
        }
    }
    class Prueba
    {
        public string Nombre { get; set; }
        public int Numero1 { get; set; }
        public static int Numero2{ get; set; }
    }
}
