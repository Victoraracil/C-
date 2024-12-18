using System;
using System.Collections.Generic;


namespace GestionAlumnos
{
    class Program
    {
        // Estructuras necesarias
        struct FechaNacimiento
        {
            public int Dia;
            public int Mes;
            public int Año;
        }

        struct Notas
        {
            public float Evaluacion1;
            public float Evaluacion2;
            public float Evaluacion3;
            public float NotaFinal;
        }

        struct Alumno
        {
            public string DNI;
            public string Nombre;
            public string Apellidos;
            public string Ciudad;
            public FechaNacimiento FechaNac;
            public Notas NotasAlumno;
        }

        const int MaxAlumnos = 100;
        static Alumno[] alumnos = new Alumno[MaxAlumnos];
        static int contadorAlumnos = 0;

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Gestión de Alumnos");
                Console.WriteLine("1. Añadir Alumno");
                Console.WriteLine("2. Borrar Alumno");
                Console.WriteLine("3. Ordenar Alumnos");
                Console.WriteLine("4. Buscar Alumno");
                Console.WriteLine("5. Mostrar Alumnos");
                Console.WriteLine("6. Salir");
                Console.Write("Elige una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AnyadirAlumno();
                        break;
                    case "2":
                        BorrarAlumno();
                        break;
                    case "3":
                        OrdenarAlumnos();
                        break;
                    case "4":
                        BuscarAlumno();
                        break;
                    case "5":
                        MostrarAlumnos();
                        break;
                    case "6":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void AnyadirAlumno()
        {
            if (contadorAlumnos >= MaxAlumnos)
            {
                Console.WriteLine("No se pueden añadir más alumnos.");
                return;
            }

            Alumno nuevoAlumno;
            Console.Write("Introduce el DNI: ");
            nuevoAlumno.DNI = Console.ReadLine();

            // Validar DNI único
            foreach (var alumno in alumnos)
            {
                if (alumno.DNI == nuevoAlumno.DNI)
                {
                    Console.WriteLine("DNI duplicado. Inténtalo de nuevo.");
                    return;
                }
            }

            Console.Write("Introduce el nombre completo (Nombre Apellidos): ");
            string nombreCompleto = Console.ReadLine();
            string[] partes = nombreCompleto.Split(' ');
            nuevoAlumno.Nombre = partes[0];
            nuevoAlumno.Apellidos = partes.Length > 1 ? partes[1] : "";

            Console.Write("Introduce la ciudad: ");
            nuevoAlumno.Ciudad = Console.ReadLine();

            Console.Write("Introduce la fecha de nacimiento (dd-mm-aaaa): ");
            string fecha = Console.ReadLine();
            string[] fechaPartes = fecha.Split('-');
            nuevoAlumno.FechaNac = new FechaNacimiento
            {
                Dia = int.Parse(fechaPartes[0]),
                Mes = int.Parse(fechaPartes[1]),
                Año = int.Parse(fechaPartes[2])
            };

            Console.WriteLine("Introduce las notas:");
            Console.Write("1ª evaluación: ");
            nuevoAlumno.NotasAlumno.Evaluacion1 = float.Parse(Console.ReadLine());
            Console.Write("2ª evaluación: ");
            nuevoAlumno.NotasAlumno.Evaluacion2 = float.Parse(Console.ReadLine());
            Console.Write("3ª evaluación: ");
            nuevoAlumno.NotasAlumno.Evaluacion3 = float.Parse(Console.ReadLine());
            nuevoAlumno.NotasAlumno.NotaFinal = (nuevoAlumno.NotasAlumno.Evaluacion1 +
                                                  nuevoAlumno.NotasAlumno.Evaluacion2 +
                                                  nuevoAlumno.NotasAlumno.Evaluacion3) / 3;

            alumnos[contadorAlumnos] = nuevoAlumno;
            contadorAlumnos++;
            Console.WriteLine("Alumno añadido con éxito.");
        }

        static void BorrarAlumno()
        {
            if (contadorAlumnos == 0)
            {
                Console.WriteLine("No hay alumnos para borrar.");
                return;
            }

            MostrarAlumnos();
            Console.Write("Introduce el índice del alumno a borrar: ");
            int indice = int.Parse(Console.ReadLine());

            if (indice < 0 || indice >= contadorAlumnos)
            {
                Console.WriteLine("Índice inválido.");
                return;
            }

            for (int i = indice; i < contadorAlumnos - 1; i++)
            {
                alumnos[i] = alumnos[i + 1];
            }
            contadorAlumnos--;
            Console.WriteLine("Alumno borrado con éxito.");
        }

        static void OrdenarAlumnos()
        {
            Console.WriteLine("Elige el criterio de ordenación:");
            Console.WriteLine("1. Por DNI");
            Console.WriteLine("2. Por Apellidos");
            Console.WriteLine("3. Por Ciudad");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Array.Sort(alumnos, 0, contadorAlumnos, Comparer<Alumno>.Create((a, b) => a.DNI.CompareTo(b.DNI)));
                    break;
                case "2":
                    Array.Sort(alumnos, 0, contadorAlumnos, Comparer<Alumno>.Create((a, b) => a.Apellidos.CompareTo(b.Apellidos)));
                    break;
                case "3":
                    Array.Sort(alumnos, 0, contadorAlumnos, Comparer<Alumno>.Create((a, b) => b.Ciudad.CompareTo(a.Ciudad)));
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            Console.WriteLine("Alumnos ordenados.");
        }

        static void BuscarAlumno()
        {
            Console.WriteLine("Elige el criterio de búsqueda:");
            Console.WriteLine("1. Por DNI");
            Console.WriteLine("2. Por Apellidos");
            string opcion = Console.ReadLine();

            Console.Write("Introduce el valor a buscar: ");
            string valorBusqueda = Console.ReadLine();

            // Búsqueda binaria (simplificada para esta versión)
            OrdenarAlumnos();
            int index = Array.FindIndex(alumnos, 0, contadorAlumnos, 
                a => (opcion == "1" ? a.DNI : a.Apellidos).Equals(valorBusqueda, StringComparison.OrdinalIgnoreCase));

            if (index >= 0)
                Console.WriteLine("Alumno encontrado: {alumnos[index].Nombre} {alumnos[index].Apellidos}");
            else
                Console.WriteLine("No se encontró ningún alumno.");
        }

        static void MostrarAlumnos()
        {
            for (int i = 0; i < contadorAlumnos; i++)
            {
                var alumno = alumnos[i];
                Console.WriteLine("{i}. {alumno.DNI} - {alumno.Nombre} {alumno.Apellidos} - {alumno.Ciudad}");
            }
        }
    }
}
