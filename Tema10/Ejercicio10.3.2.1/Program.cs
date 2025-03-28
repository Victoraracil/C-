using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
/*A partir del ejemplo anterior añade un atributo dni a la clase Persona y haz las
modificaciones necesarias para que funcione, debes controlar también las posibles errores añadiendo
try-catch donde sea necesario, crea un menú para añadir, listar, eliminar y guardar (serializar)
personas

En el ejercicio 8.3.4 habías ampliado la "base de datos de ficheros", de modo que los datos
se leyeran desde fichero. Crea una versión alternativa que emplee serialización.*/
class Program
{
    private static List<Persona> personas = new List<Persona>();
    private static string fichero = "../../../personas.xml";
    static void Main(string[] args)
    {
        if (!File.Exists(fichero))
        {
            File.Create(fichero).Close();
            Poblar();
        }
        else
        {
            personas = Cargar(fichero);

        }

        string op;

        do
        {
            Console.Clear();
            Console.WriteLine("0.- Salir");
            Console.WriteLine("1.- Añadir persona");
            Console.WriteLine("2.- Listar personas");
            Console.WriteLine("3.- Eliminar persona");
            Console.WriteLine("4.- Guardar personas");
            op = Console.ReadLine();

            switch (op)
            {
                case "0":
                    //auto guardado
                    Guardar(fichero, personas);
                    break;
                case "1":
                    Console.WriteLine("Introduce el nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Introduce los apellidos");
                    string apellidos = Console.ReadLine();
                    Console.WriteLine("Introduce el DNI");
                    string dni = Console.ReadLine();
                    personas.Add(new Persona(nombre, apellidos, dni));
                    Console.WriteLine("Persona añadida correctamente");
                    Console.ReadLine();
                    break;
                case "2":
                    personas.ForEach(p => Console.WriteLine(p));
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Introduce el DNI de la persona a eliminar");
                    dni = Console.ReadLine();
                    personas.Remove(personas.Find(p => p.DNI == dni));
                    Console.WriteLine("Persona eliminada correctamente");
                    Console.ReadLine();
                    break;
                case "4":
                    Guardar(fichero, personas);
                    Console.WriteLine("Personas guardadas correctamente");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
                

        } while (op != "0");
    }
    private static void Poblar()
    {
        personas.Add(new Persona("Juan", "Pérez", "0000000A"));
        personas.Add(new Persona("Pedro", "Domeq", "1111111B"));
    }
    public static void Guardar(string fichero, List<Persona> objetos)
    {
        StreamWriter stream = new StreamWriter(fichero);
        XmlSerializer Serializer = new XmlSerializer(typeof(List<Persona>));
        Serializer.Serialize(stream, objetos);
        stream.Close();
    }
    public static List<Persona> Cargar(string fichero)
    {
        Stream stream = new FileStream(fichero, FileMode.Open);
        XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));
        List<Persona> personas = (List<Persona>)serializer.Deserialize(stream);
        stream.Close();
        return (personas);
    }
    public static void Ordenar()
    {
        personas.Sort((p1, p2) => p1.Nombre.CompareTo(p2.Nombre));
    }
}