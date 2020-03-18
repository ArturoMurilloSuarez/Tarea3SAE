using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3Juan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Materia> lista = new List<Materia>();
            int n = Materia.Tamaño();
            for (uint i = 0; i < n; i++)
            {
                lista.Add(new Materia());
            }
            lista.Sort();
            Console.Clear();
            Console.WriteLine("\nMATERIA\t\tDÍA\tINICIO\tFIN\tDURACIÓN (min)");
            for (int i = 0; i < n; i++)
            {
                lista[i].MostrarDatos();
            }
            Console.ReadKey();
        }
    }
}
