using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

[JsonDerivedType(typeof(Alumno), typeDiscriminator: nameof(Alumno))]
[JsonDerivedType(typeof(Profesor), typeDiscriminator: nameof(Profesor))]
/*A partir del ejemplo anterior vamos un programa capaz de serializar/deserializar una lista de
Animales controlando los posibles errores con try-catch
    • Clase Animal:
        ◦ Propiedades: nombre string, peso int.
        ◦ Constructor por defecto y un constructor completo.
        ◦ Método ToString() que devuelve un string como por ejemplo:
        “Tintín;10”
    • Clase Perro, hereda de Animal y añade como atributos propios:
        ◦ Propiedades: raza, string.
        ◦ Constructor por defecto y un constructor completo.
        ◦ Método ToString() que devuelve un string como por ejemplo:
        “Tintín;10;Fox Terrier”
    • Clase Gato, , hereda de Animal y añade como atributos propios:
        ◦ propiedades: color, string.
        ◦ Constructor por defecto y un constructor completo.
        ◦ Método ToString() que devuelve un string como por ejemplo:
        “Gatunch;10;amarillo”
    • Opciones del menú:
        ◦ Añadir: permite introducir animales a la lista
        ◦ Guardar: guarda la lista que previamente habremos ordenado a un fichero de nombre
        “animales.json” en una carpeta llamada datos a partir la la carpeta donde están los fuentes en c#, si
        la carpeta no existe la creamos desde el programa. Debemos controlar los posibles errores como que
        el fichero este abierto o que no tengamos permisos de escritura.
        ◦ Listar: Imprime los animales de la lista por la consola.
        ◦ Buscar: por nombre, edad, color o raza.
        ◦ Borrar: Borra el fichero
Cuando arranca el programa si existe el fichero “animales.json” debe cargar los animales a la lista*/
class Program
{
    static void Main(string[] args)
    {
        ListaDeAnimales lista = new ListaDeAnimales();
        List<Animal> animales = new List<Animal>();
        string op;
        do
        {
            Console.Clear();
            Console.WriteLine("0.- Salir");
            Console.WriteLine("1.- Añadir");
            Console.WriteLine("2.- Guardar");
            Console.WriteLine("3.- Listar");
            Console.WriteLine("4.- Buscar");
            Console.WriteLine("5.- Borrar");
            op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    string tipo;
                    Console.WriteLine("Que tipo de animal quieres introducir?");
                    Console.WriteLine("1.- Perro");
                    Console.WriteLine("2.- Gato");
                    tipo = Console.ReadLine();
                    Console.WriteLine("Introduce el nombre de tu animal: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Introduce el peso de tu animal: ");
                    int peso = Convert.ToInt32(Console.ReadLine());
                    switch (tipo)
                    {
                        case "1":
                            Console.WriteLine("Raza: ");
                            string raza = Console.ReadLine();
                            animales.Add(new Perro(nombre, peso, raza));
                            break;
                        case "2":
                            Console.WriteLine("Color: ");
                            string color = Console.ReadLine();
                            animales.Add(new Gato(nombre, peso, color));
                            break;
                    }
                    break;
                case "2":
                    lista.Guardar("animales.json", animales);
                    break;
                case "3":
                    animales.ForEach(x => Console.WriteLine(x));
                    Console.ReadLine();
                    break;
                case "4":
                Console.WriteLine("Introduce el nombre, edad, color o raza del animal que quieres buscar: ");
                string buscar = Console.ReadLine();
                List<Animal> encontrados = animales.FindAll(x => x.Nombre.Contains(buscar) || x.Peso.ToString().Contains(buscar));
                encontrados.ForEach(x => Console.WriteLine(x));
                Console.ReadLine();
                    break;
            }
        } while (op != "0");

        lista.Guardar("animales.json", animales);
        animales = lista.Cargar("animales.json");
        if (animales != null) animales.ForEach(x => Console.WriteLine(x));
    }
    
}