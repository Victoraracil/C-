/*
Victor Aracil Gozalvez
Practica Evaluable Tema 4

Ejercicio 1

Apartado 1.1: si
Apartado 1.2: si
Apartado 1.3: si
Apartado 1.4: si
Apartado 1.5: si
Apartado 1.6: si
Apartado 1.7: si
Apartado 1.8: si
Apartado 1.9: si
*/

using System;

class Alumnos
{
    struct Fecha
    {
        public int dia, mes, año;
    }

    struct Notas
    {
        public float[] practicas; // 6 prácticas
        public float[] examenes; // 3 evaluaciones
        public float notaFinal;  // Calculada automáticamente
    }

    struct Alumno
    {
        public string nombre, apellidos, ciudad;
        public Fecha fechaNacimiento;
        public Notas notas;
    }

    const int CAPACIDAD = 90;
    static Alumno[] listaAlumnos = new Alumno[CAPACIDAD];
    static int cantidadAlumnos = 0;

    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("Gestión de Alumnos");
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Añadir un alumno");
            Console.WriteLine("2. Borrar un alumno");
            Console.WriteLine("3. Mostrar alumnos por ciudad");
            Console.WriteLine("4. Mostrar alumnos por año de nacimiento");
            Console.WriteLine("5. Ordenar por apellidos");
            Console.WriteLine("6. Ordenar por mayor nota final");
            Console.WriteLine("7. Calcular porcentajes de aprobados y suspensos");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1://*******************************************************************************
                    
                    if (cantidadAlumnos >= CAPACIDAD){
						Console.WriteLine("No hay espacio para más alumnos.");
						return;
					}

				Alumno nuevoAlumno = new Alumno();

				Console.Write("Nombre y apellidos (separados por espacio): ");
				string entrada = Console.ReadLine();
				string[] partes = entrada.Split();
				nuevoAlumno.nombre = partes[0];
				nuevoAlumno.apellidos = partes.Length > 1 ? partes[1] : "";

				Console.Write("Ciudad: ");
				nuevoAlumno.ciudad = Console.ReadLine();

				Console.Write("Fecha de nacimiento (dd-mm-aaaa): ");
				string fecha = Console.ReadLine();
				string[] fechaPartes = fecha.Split('-');
				nuevoAlumno.fechaNacimiento.dia = Convert.ToInt32(fechaPartes[0]);
				nuevoAlumno.fechaNacimiento.mes = Convert.ToInt32(fechaPartes[1]);
				nuevoAlumno.fechaNacimiento.año = Convert.ToInt32(fechaPartes[2]);

				nuevoAlumno.notas.practicas = new float[6];
				nuevoAlumno.notas.examenes = new float[3];

				for (int i = 0; i < 6; i++)
				{
					Console.Write("Nota práctica " + (i + 1) + " : ");
					nuevoAlumno.notas.practicas[i] = Convert.ToSingle(Console.ReadLine());
				}

				for (int i = 0; i < 3; i++)
				{
					Console.Write("Nota examen " + (i + 1) + " : ");
					nuevoAlumno.notas.examenes[i] = Convert.ToSingle(Console.ReadLine());
				}

				nuevoAlumno.notas.notaFinal = CalcularNotaFinal(nuevoAlumno.notas);

				listaAlumnos[cantidadAlumnos] = nuevoAlumno;
				cantidadAlumnos++;

				Console.WriteLine("Alumno añadido correctamente.");
                    
                    break;
                case 2://*******************************************************************************
                    
                    for (int i = 0; i < cantidadAlumnos; i++){
						Console.WriteLine("{0}. {1} {2}", i + 1, listaAlumnos[i].nombre, listaAlumnos[i].apellidos);
					}
					Console.Write("Seleccione la posición del alumno a borrar (1 a {0}): ", cantidadAlumnos);
					int posicion = Convert.ToInt32(Console.ReadLine()) - 1;

					if (posicion < 0 || posicion >= cantidadAlumnos){
						Console.WriteLine("Posición no válida.");
						return;
					}

					for (int i = posicion; i < cantidadAlumnos - 1; i++){
						listaAlumnos[i] = listaAlumnos[i + 1];
					}

					cantidadAlumnos--;
					Console.WriteLine("Alumno borrado correctamente.");
                    
                    break;
                case 3://*******************************************************************************
                    
                    Console.Write("Ingrese la ciudad a buscar: ");
					string ciudad = Console.ReadLine().ToLower();

					for (int i = 0; i < cantidadAlumnos; i++){
						if (listaAlumnos[i].ciudad.ToLower().Contains(ciudad)){
							var alumno = listaAlumnos[i];
							Console.WriteLine("Nombre: {0} {1}", alumno.nombre, alumno.apellidos);
							Console.WriteLine("Ciudad: {0}", alumno.ciudad);
							Console.WriteLine("Fecha de nacimiento: {0}-{1}-{2}", alumno.fechaNacimiento.dia, alumno.fechaNacimiento.mes, alumno.fechaNacimiento.año);
							Console.WriteLine("Nota Final: {0:F2}", alumno.notas.notaFinal);
							Console.WriteLine();
						}
					}
                    
                    break;
                case 4://*******************************************************************************
                    
                    Console.Write("Ingrese el año de nacimiento: ");
					int año = Convert.ToInt32(Console.ReadLine());

					for (int i = 0; i < cantidadAlumnos; i++){
						if (listaAlumnos[i].fechaNacimiento.año == año){
							var alumno = listaAlumnos[i];
							Console.WriteLine("Nombre: {0} {1}", alumno.nombre, alumno.apellidos);
							Console.WriteLine("Ciudad: {0}", alumno.ciudad);
							Console.WriteLine("Fecha de nacimiento: {0}-{1}-{2}", alumno.fechaNacimiento.dia, alumno.fechaNacimiento.mes, alumno.fechaNacimiento.año);
							Console.WriteLine("Nota Final: {0:F2}", alumno.notas.notaFinal);
							Console.WriteLine();
						}
					}
                    
                    break;
                case 5://*******************************************************************************
                    
					Console.WriteLine("Funcion no implementada");
                    
                    break;
                case 6://*******************************************************************************
					
					Console.WriteLine("Funcion no implementada");
					
                    break;
                case 7://******************************************************************************
                
					Console.WriteLine("Funcion no implementada");

                    break;
                case 0://*******************************************************************************
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (opcion != 7){
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 7);
    }
    static float CalcularNotaFinal(Notas notas)
    {
        float[] evaluaciones = new float[3];
        evaluaciones[0] = 0.3f * ((notas.practicas[0] + notas.practicas[1]) / 2) + 0.7f * notas.examenes[0];
        evaluaciones[1] = 0.3f * ((notas.practicas[2] + notas.practicas[3]) / 2) + 0.7f * notas.examenes[1];
        evaluaciones[2] = 0.3f * ((notas.practicas[4] + notas.practicas[5]) / 2) + 0.7f * notas.examenes[2];

        return 0.2f * evaluaciones[0] + 0.3f * evaluaciones[1] + 0.5f * evaluaciones[2];
	}
	static int CompararPorApellidos(Alumno x, Alumno y)
    {
        return string.Compare(x.apellidos, y.apellidos);
    }

    static int CompararPorNotaFinal(Alumno x, Alumno y)
    {
        return y.notas.notaFinal.CompareTo(x.notas.notaFinal);
    }
}
    
