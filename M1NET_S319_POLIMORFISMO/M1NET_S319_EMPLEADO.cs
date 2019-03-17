using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S319_POLIMORFISMO
{
    class M1NET_S319_EMPLEADO
    {
        static void Main(string[] args)
        {
            int op;
            string nombre;
            Empleado emp = null;
            Console.WriteLine("Ingrese nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese tipo de empleado");
            Console.WriteLine("1-salariado");
            Console.WriteLine("2-eventual");
            Console.WriteLine("3-por servicio");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    emp = new Fijo();
                    emp.nombre = nombre;
                    Console.WriteLine("Ingrese salario");
                    emp.salario = float.Parse(Console.ReadLine());
                    emp.calcularSalario();
                    break;
                case 2:
                    emp = new Eventual();
                    emp.nombre = nombre;
                    Console.WriteLine("Ingrese salario");
                    emp.salario = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese tiempo");
                    emp.meses = int.Parse(Console.ReadLine());
                    emp.calcularSalario();
                    break;
                case 3:
                    emp = new Servicio();
                    emp.nombre = nombre;                   
                    Console.WriteLine("Ingrese horas");
                    emp.numeroHoras = int.Parse(Console.ReadLine());
                    Console.WriteLine("Valor horas");
                    emp.valorHora = float.Parse(Console.ReadLine());
                    emp.calcularSalario();
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
    abstract class Empleado
    {
        public string nombre;
        public float salario;
        public int meses;
        public int numeroHoras;
        public float valorHora;
        public abstract void calcularSalario();
    }

    class Fijo : Empleado
    {
        public override void calcularSalario()
        {
            Console.WriteLine("El nombre el empleado es: {0}",nombre);
            Console.WriteLine("Salario empleado {0:C}",salario);
        }
    }

    class Eventual : Empleado
    {
        public override void calcularSalario()
        {
            Console.WriteLine("El nombre el empleado es: {0}", nombre);
            Console.WriteLine("Tiempo trabajado es: {0}",meses);
            Console.WriteLine("Salario empleado {0:C}", salario);
        }
    }

    class Servicio : Empleado
    {
        public override void calcularSalario()
        {
            Console.WriteLine("El nombre el empleado es: {0}", nombre);
            Console.WriteLine("Salario empleado {0:C}", (numeroHoras*valorHora));
        }
    }

}
