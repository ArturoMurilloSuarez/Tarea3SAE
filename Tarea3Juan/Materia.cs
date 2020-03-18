using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3Juan
{
    class Materia : IComparable
    {
        private string nombre;
        private string horaInicio;
        private string horaFin;
        private string dia;
        private int duracion;
        private int ordenar;

        public Materia()
        {
            Console.Write("\n¿Cuál es el nombre de la materia?: ");
            this.nombre = Console.ReadLine();
            Console.Write("¿A qué hora empieza la materia de {0}? (Ingresar hora en formato militar. Ejemplo: 1200 ó 1730 ): ", this.nombre);
            this.horaInicio = Console.ReadLine();
            Console.Write("¿A qué hora termina la materia de {0}? (Ingresar hora en formato militar. Ejemplo: 1200 ó 1730 ): ", this.nombre);
            this.horaFin = Console.ReadLine();
            Console.Write("¿Qué día de la semana tienes la clase de {0}?: ", this.nombre);
            this.dia = Console.ReadLine();
            Console.Write("¿Cuánto dura la clase de {0}, en minutos?: ", this.nombre);
            duracion = int.Parse(Console.ReadLine());
            this.ordenar = Ordenar();
        }

        public static int Tamaño()
        {
            Console.Write("¿Cuántas materias tienes?: ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        public int Ordenar()
        {
            if (dia == "Lunes")
            {
                return 1;
            }
            if (dia == "Martes")
            {
                return 2;
            }
            if (dia == "Miércoles")
            {
                return 3;
            }
            if (dia == "Jueves")
            {
                return 4;
            }
            if (dia == "Viernes")
            {
                return 5;
            }
            else
                return 0;
        }

        public string Dia
        {
            get { return this.dia; }
            set {
                if (value == "Lunes" || value == "Martes" || value == "Miércoles" || value == "Jueves" || value == "Viernes")
                    dia = value;
                else
                    dia = "S/D";
                }
        }
       

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Materia materia = obj as Materia;
            if (materia != null)
                return this.ordenar.CompareTo(materia.ordenar);
            else
                throw new NotImplementedException();
        }

        public void MostrarDatos()
        {
            Console.WriteLine("{0}\t\t{1}\t{2}\t{3}\t{4}", this.nombre, this.dia, this.horaInicio, this.horaFin, this.duracion);
        }

    }
}
