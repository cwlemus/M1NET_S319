using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S319_ABSTRACT
{
    class M1NET_S319_BANCO
    {
        static void Main(string[] args)
        {
            bool seguir = true;
            while (seguir)
            {
                Console.WriteLine("Desea tomar un ticket (s/n)");
                string respuesta = Console.ReadLine();
                if (respuesta.ToUpper().Equals("S"))
                {
                    Console.WriteLine("Ticket generado {000:000}",(Banco.GenerarTicket()+1));
                }
                else
                {
                    seguir = false;
                }
            }
            Console.WriteLine("Numero de clientes atendidos: {0}",Banco.NumeroCliente);
            Console.ReadLine();
        }
    }
    class Banco
    {
        public static int NumeroCliente = 0;
        public static int GenerarTicket()
        {
            return NumeroCliente++;
        }
    }
}
