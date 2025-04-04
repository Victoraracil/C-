using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
/*A partir del ejemplo anterior vamos un programa capaz de serializar/deserializar una lista de
Animales controlando los posibles errores con try-catch
    • Clase Animal:
        ◦ Propiedades: nombre string, especie string, peso int.
        ◦ Constructor por defecto (sin propiedades) y un constructor completo (con todas las propiedades)
        ◦ Método ToString() que devuelve un string como por ejemplo:
        “Animal – Tintín – perro - 10”
        ◦ Tenemos que hacer que el objeto se pueda comparar con otros por el nombre y por la especie, para
        ello debe implementar la interfaz IComparable o utilizar una función lambda en lista.sort(), repasar
        el tema 7 donde hay ejemplos
    • Opciones del menú:
        ◦ Poblar: permite introducir animales a la lista hasta que el usuario introduzca datos vacíos
        ◦ Guardar: guarda la lista que previamente habremos ordenado a un fichero de nombre
        “animales.json” en una carpeta llamada datos a partir la la carpeta actual, es decir:
        “./datos/animales.json” si la carpeta no existe la creamos desde el programa. Debemos controlar los
        posibles errores como que el fichero este abierto o que no tengamos permisos de escritura.
        ◦ Cargar: lee la lista de animales desde el fichero (“./datos/animales.json”) y lo guarda en la lista. Solo
        se cargarán los animales que no estén duplicados, es decir que su nombre y su especie sea diferente.
        ◦ Listar: Imprime los animales de la lista por la consola.
        ◦ Borrar: Borra el fichero
Cuando arranca el programa si existe el fichero “animales.json” debe cargar los animales a la lista (sin
duplicados)
Se debe controlar los errores tanto al leer o escribir ficheros como al leer números.*/
public class Program
{
    static List<Animal> animales = new List<Animal>();
    static string fichero = "../../../animales.json";
    static void Main(string[] args)
    {
        //crea un fichero si no existe y lo pobla, en caso contrario, si el fichero exixte, carga los animales
        if (!File.Exists(fichero))
        {
            File.Create(fichero).Close();
            Poblar();
        }
        else
        {
            animales = Cargar(fichero);
        }

        string op;

        do
        {
            Console.Clear();
            Console.WriteLine("0.- Salir");
            Console.WriteLine("1.- Añadir animales");
            Console.WriteLine("2.- Listar animales");
            Console.WriteLine("3.- Guardar animales");
            Console.WriteLine("4.- Eliminar fichero");

            op = Console.ReadLine();

            switch (op)
            {
                case "0":
                    //auto guardado si existe el fichero (no se ha eliminado)
                    if (File.Exists(fichero))
                    {
                        Guardar(fichero, animales);
                    }
                    else
                    {
                    }
                    break;
                case "1":
                    int peso;
                    Console.WriteLine("Introduce el nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Introduce la especie");
                    string especie = Console.ReadLine();
                    Console.WriteLine("Introduce el peso");
                    while (!int.TryParse(Console.ReadLine(), out peso))
                    {
                        Console.WriteLine("Dato incorrecto");
                    }
                    animales.Add(new Animal(nombre, especie, peso));
                    Console.WriteLine("Animal añadido correctamente");
                    Console.ReadLine();
                    break;
                case "2":
                    animales.ForEach(a => Console.WriteLine(a));
                    Console.ReadLine();
                    break;
                case "3":
                    Guardar(fichero, animales);
                    Console.WriteLine("Animales guardados correctamente");
                    Console.ReadLine();
                    break;
                case "4":
                    if (File.Exists(fichero))
                    {
                        File.SetAttributes(fichero, FileAttributes.Normal);
                        File.Delete(fichero);
                        Console.WriteLine("Fichero eliminado correctamente");
                    }
                    else
                    {
                        Console.WriteLine("El fichero no existe");
                    }
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
        animales.Add(new Animal("Tintín", "perro", 10));
        animales.Add(new Animal("Garfield", "gato", 8));
    }

    public static void Guardar(string fichero, List<Animal> objetos)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(objetos);
            File.WriteAllText(fichero, jsonString);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al guardar el fichero: {ex.Message}");
        }
    }

    public static List<Animal> Cargar(string fichero)
    {
        try
        {
            string jsonString = File.ReadAllText(fichero);
            List<Animal> animales = JsonSerializer.Deserialize<List<Animal>>(jsonString);
            return animales;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al cargar el fichero: {ex.Message}");
            return new List<Animal>();
        }
    }
}