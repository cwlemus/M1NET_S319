using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1_NETS319
{
    class M1NET_S319_EJEMPLO_ALUMNOS
    {
        static void Main(string[] args)
        {
            Alumno[] alumnos = new Alumno[3];
            Alumno alumnoSelected;
            float promedio = 0.0f, sumaNota = 0.0f;
           
            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnoSelected = new Alumno();
                Console.WriteLine("Ingrese nombre de alumno {0} :",(i+1));
                alumnoSelected.Nombre = Console.ReadLine();
                
                Console.WriteLine("Ingrese nota de alumno {0} :",(i+1));
                alumnoSelected.Nota = float.Parse(Console.ReadLine());

                alumnos[i] = alumnoSelected;
                sumaNota += alumnos[i].Nota;
            }
            promedio = sumaNota / alumnos.Length;

            foreach (var item in alumnos)
            {
                Console.WriteLine("Nombre : "+item.Nombre);
                Console.WriteLine("Nota : "+item.Nota);
            }
            Console.WriteLine("El promedio de todos los alumnos es: "+promedio);
            Console.ReadLine();
        }
    }

    class Alumno
    {
        public string Nombre { get; set; }
        public float Nota { get; set; }
    }
}
