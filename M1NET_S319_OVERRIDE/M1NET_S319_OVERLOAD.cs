using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S319_OVERRIDE
{
    class M1NET_S319_OVERLOAD
    {
        static void Main(string[] args)
        {
            Empleado em = new Empleado();
            Console.WriteLine("Ingrese salario");
            em.Salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese horas trabajadas");
            em.NumeroHoras = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor hora");
            em.ValorHora = float.Parse(Console.ReadLine());
            Console.WriteLine("sueldo empleado asalariado es: {0:c}",
                em.CalcularSalario(em.Salario));
            Console.WriteLine("sueldo empleado por servicio es: {0:c}",
                em.CalcularSalario(em.NumeroHoras,em.ValorHora));
            Console.ReadLine();
        }
    }
    class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumeroHoras { get; set; }
        public float ValorHora { get; set; }
        public float Salario { get; set; }

        public float CalcularSalario(float salario)
        {
            return (salario -= salario * 0.1f);
        }

        public float CalcularSalario(int numeroHoras, float valorHora)
        {
            return (numeroHoras * valorHora);
        }

    }
    
}
