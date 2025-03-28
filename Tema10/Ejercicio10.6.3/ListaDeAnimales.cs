using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
//Aqui se almacenan todos los metodos usados en el programa


/*• Opciones del menú:
        ◦ Añadir: permite introducir animales a la lista
        ◦ Guardar: guarda la lista que previamente habremos ordenado a un fichero de nombre
        “animales.json” en una carpeta llamada datos a partir la la carpeta donde están los fuentes en c#, si
        la carpeta no existe la creamos desde el programa. Debemos controlar los posibles errores como que
        el fichero este abierto o que no tengamos permisos de escritura.
        ◦ Listar: Imprime los animales de la lista por la consola.
        ◦ Buscar: por nombre, edad, color o raza.
        ◦ Borrar: Borra el fichero
*/
class ListaDeAnimales
{
    public void Añadir(List<Animal> animales)
    {
        string nombre;
        int peso;
        string color;
        string raza;
        
        Console.WriteLine("Nombre: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Peso: ");
        peso = Convert.ToInt32(Console.ReadLine());
        switch (op)
        {
            case "1":
                Console.WriteLine("Raza: ");
                raza = Console.ReadLine();
                animales.Add(new Perro(nombre, peso, raza));
                break;
            case "2":
                Console.WriteLine("Color: ");
                color = Console.ReadLine();
                animales.Add(new Gato(nombre, peso, color));
                break;
        }
    }
    public void Guardar(string fichero, List<Animal> objetos)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize<object>(objetos);
            File.WriteAllText(fichero, jsonString);
        }
        catch (Exception e)
        {
            Console.WriteLine(" Error al Guardar() " + e.Message);
            Console.WriteLine(e.InnerException);
        }
    }
    public List<Animal> Cargar(string fichero)
    {
        try
        {
            string jsonString = File.ReadAllText(fichero);
            List<Animal> animales = JsonSerializer.Deserialize<List<Animal>>(jsonString);
            return (animales);
        }
        catch (Exception e)
        {
            Console.WriteLine(" Error al Cargar() " + e.Message);
            Console.WriteLine(e.InnerException); return (null);
        }
    }
}

