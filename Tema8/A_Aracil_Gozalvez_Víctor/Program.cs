using System;
/*
 * Victor Aracil Gozalvez
 * Examen Victor 2
 * Ejercicio 1
 * Apartado 6.2 - si
 * Apartado 6.3 - si
 * Apartado 6.4 - si
 * Apartado 6.5 - si
 * Apartado 6.6 - si
 * Apartado 6.9 - si
 * Apartado 6.10 - si
 * Apartado 6.12 - si
 * Apartado 6.13 - si
 * Apartado 6.14 - si
 * Apartado 6.16 - si (clases abstractas, no interfaces)
 * Apartado 7.4 - si
 * 
 * 
 */
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Introduce el nombre del centro docente: ");
        string nombreCentro = Console.ReadLine();
        //controlar que si el nombre del centro ya existe, no se pueda crear
        CentroDocente centro = new CentroDocente(nombreCentro);
        Menu(centro);//Se requiere una referencia de objeto para el campo, método o propiedad 'Program.Menu(CentroDocente)' no estáticos
    }

    public void Menu(CentroDocente centro)
    {
        int opcion = 0;
        int opcionPersonal = 0;
        do
        {
            
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Añadir personal");
            Console.WriteLine("2. Eliminar personal");
            Console.WriteLine("3. Listar alumnos");
            Console.WriteLine("4. Listar departamentos");
            Console.WriteLine("5. Listar profesores por departamento");
            Console.WriteLine("6. Contar personal por turno");
            Console.WriteLine("7. Listar todo el personal");
            Console.WriteLine("Introduce una opción: ");
            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
            }catch (Exception e)
            {
                Console.WriteLine("Opción no válida");
            }
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Elije que tipo de personal quieres añadir: ");
                    Console.WriteLine("1. Personal Administrativo");
                    Console.WriteLine("2. Profesor");
                    Console.WriteLine("3. Alumno");
                    try
                    {
                        opcionPersonal = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Opción no válida");
                    }
                    switch (opcionPersonal)
                    {
                        case 1:
                            Console.WriteLine("Introduce el DNI: ");
                            string dni = Console.ReadLine();
                            Console.WriteLine("Introduce el nombre: ");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Introduce la fecha de nacimiento: ");
                            string fechaNacimiento = Console.ReadLine();
                            Console.WriteLine("Introduce la dirección: ");
                            string direccion = Console.ReadLine();
                            Console.WriteLine("Introduce el teléfono: ");
                            int telefono = 0;
                            try
                            {
                                telefono = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Telefono no valido");
                            }
                            Console.WriteLine("Introduce el turno: ");
                            string turn = Console.ReadLine();
                            PersonalAdministrativo admin = new PersonalAdministrativo(dni, nombre, fechaNacimiento, direccion, telefono, turn);
                            centro.NuevoPersonal(admin);
                            break;
                        case 2:
                            Console.WriteLine("Introduce el DNI: ");
                            string dniProfe = Console.ReadLine();
                            Console.WriteLine("Introduce el nombre: ");
                            string nombreProfe = Console.ReadLine();
                            Console.WriteLine("Introduce la fecha de nacimiento: ");
                            string fechaNacimientoProfe = Console.ReadLine();
                            Console.WriteLine("Introduce la dirección: ");
                            string direccionProfe = Console.ReadLine();
                            Console.WriteLine("Introduce el teléfono: ");
                            int telefonoProfe = 0;
                            try
                            {
                                telefonoProfe = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Telefono no valido");
                            }
                            Console.WriteLine("Introduce el departamento: ");
                            string dept = Console.ReadLine();
                            Profesor profe = new Profesor(dniProfe, nombreProfe, fechaNacimientoProfe, direccionProfe, telefonoProfe, dept);
                            centro.NuevoPersonal(profe);
                            break;
                        case 3:
                            Console.WriteLine("Introduce el DNI: ");
                            string dniAlumno = Console.ReadLine();
                            Console.WriteLine("Introduce el nombre: ");
                            string nombreAlumno = Console.ReadLine();
                            Console.WriteLine("Introduce la fecha de nacimiento: ");
                            string fechaNacimientoAlumno = Console.ReadLine();
                            Console.WriteLine("Introduce la dirección: ");
                            string direccionAlumno = Console.ReadLine();
                            Console.WriteLine("Introduce el teléfono: ");
                            int telefonoAlumno = 0;
                            try
                            {
                                telefonoAlumno = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Telefono no valido");
                            }
                            Console.WriteLine("Introduce el NIA: ");
                            int nia = 0;
                            try
                            {
                                nia = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Telefono no valido");
                            }
                            Console.WriteLine("Introduce el curso: ");
                            string curso = Console.ReadLine();
                            Alumno alumno = new Alumno(dniAlumno, nombreAlumno, fechaNacimientoAlumno, direccionAlumno, telefonoAlumno, nia, curso);
                            centro.NuevoPersonal(alumno);
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Introduce la posición del personal que quieres eliminar: ");
                    int posicion = 0;
                    try
                    {
                        posicion = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Telefono no valido");
                    }
                    Console.WriteLine("Introduce el curso: ");
                    centro.EliminarPersonal(posicion);
                    break;
                case 3:
                    Buscador.ListarAlumnos(centro);
                    break;
                case 4:
                    Buscador.ListarDepartamentos(centro);
                    break;
                case 5:
                    Console.WriteLine("Introduce el departamento: ");
                    string departamento = Console.ReadLine();
                    Buscador.ListarProfesoresPorDepartamento(centro, departamento);
                    break;
                case 6:
                    Console.WriteLine("Introduce el turno: ");
                    string turno = Console.ReadLine();
                    Buscador.ContarPersonalTurno(centro, turno);
                    break;
                case 7:
                    foreach (Personal p in centro.listaPersonal)
                    {
                        Console.WriteLine(p.ToString());
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        } while (opcion != 0);
    }

}