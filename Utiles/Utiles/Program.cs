/*Este programa SOLO es una ayuda para facilitar las aplicaciones de aqui en adelante,
 siendo solo esta clase la que contendra todos los metodos necesarios para el funcionamiento de las aplicaciones.
 Este progrtama NO actua como un programa como tal, sino como una clase de metodos utiles / libreria.
 Asimismo, NO sirve para realizar ejercicios copiando y pegando el codigo, sino que es una ayuda para realizar los 
 ejercicios de manera mas sencilla con utiles como algoritmos de ordenacion, serializacion, etc.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

public class Program
{
    public static void Main(string[] args)
    {
        Program util = new Program();
        Console.WriteLine("Este programa es una libreria de metodos utiles y no se ejecuta directamente.");
        int arraySize = 10;
        int[] numeros = new int[arraySize];
        Random random = new Random();
        // Llenar el array con números aleatorios
        for (int i = 0; i < arraySize; i++)
        {
            numeros[i] = random.Next(1, 100); // Números aleatorios entre 1 y 100
        }
        util.OrdenarBurbuja(numeros);
        Console.WriteLine("Array ordenado:");
        Console.WriteLine(string.Join(", ", numeros));
        EliminarDuplicados(numeros.ToList()).ForEach(Console.WriteLine); // Mostrar números únicos después de ordenar
        

    }

    public void OrdenarBurbuja(int[] array)//Algoritmo de ordenacion por burbuja (cadenas de datos pequeñas)
    {
        int n = array.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {              
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    swapped = true;
                }
            }
            n--; // Reducir el rango de comparación
        } while (swapped);
    }

    public void Error(string mensaje)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: " + mensaje);
        Console.ResetColor();
    }

    public void TryCatch()
    {
        int datoavalidar = 0;
        try
        {
            datoavalidar = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Dato no valido");
        }
    }

    public static List<string> LeerListaDesdeArchivo(string ruta)
    {
        if (!File.Exists(ruta))
            return new List<string>();

        return File.ReadAllLines(ruta).ToList();
    }

    public static void EscribirListaEnArchivo(List<string> lista, string ruta)
    {
        File.WriteAllLines(ruta, lista);
    }

    public static bool EsNumero(string input)
    {
        return double.TryParse(input, out _);
    }

    public static List<int> GenerarNumerosAleatorios(int cantidad, int minimo, int maximo)
    {
        Random rnd = new Random();
        return Enumerable.Range(0, cantidad)
                         .Select(_ => rnd.Next(minimo, maximo + 1))
                         .ToList();
    }

    // 1. Filtrar una lista según una condición (ej: mayores de 18)
    public static List<int> FiltrarMayoresDe(List<int> lista, int edad)
    {
        return lista.Where(x => x > edad).ToList();
    }

    // 2. Obtener elementos únicos de una lista
    public static List<T> EliminarDuplicados<T>(List<T> lista)
    {
        return lista.Distinct().ToList();
    }

    // 3. Ordenar una lista descendente o ascendente
    public static List<int> Ordenar(List<int> lista, bool descendente = false)
    {
        return descendente ? lista.OrderByDescending(x => x).ToList()
                           : lista.OrderBy(x => x).ToList();
    }

    // 4. Convertir una lista de strings a mayúsculas
    public static List<string> AMayusculas(List<string> lista)
    {
        return lista.Select(x => x.ToUpper()).ToList();
    }

    // 5. Buscar si existe un elemento que cumpla una condición
    public static bool ExisteMayorQue(List<int> lista, int valor)
    {
        return lista.Any(x => x > valor);
    }

    // 6. Obtener la suma o promedio de los elementos
    public static int SumarLista(List<int> lista)
    {
        return lista.Sum();
    }
    public static double PromedioLista(List<int> lista)
    {
        return lista.Average();
    }

    // 7. Agrupar palabras por su longitud
    public static Dictionary<int, List<string>> AgruparPorLongitud(List<string> palabras)
    {
        return palabras.GroupBy(p => p.Length)
                       .ToDictionary(g => g.Key, g => g.ToList());
    }

    // 8. Contar cuántos elementos cumplen una condición
    public static int ContarCondicion<T>(List<T> lista, Func<T, bool> condicion)
    {
        return lista.Count(condicion);
    }

    // 9. Mapear una lista de objetos a otra forma (proyección)
    public static List<string> ObtenerNombres(List<listaejemplo> personas)
    {
        return personas.Select(p => p.Nombre).ToList();
    }

    public static List<int> OrdenarYSustituirDuplicados(List<int> lista)
    {
        var ordenada = lista.OrderBy(x => x).ToList();
        var encontrados = new HashSet<int>();

        for (int i = 0; i < ordenada.Count; i++)
        {
            if (encontrados.Contains(ordenada[i]))
            {
                ordenada[i] = 0;
            }
            else
            {
                encontrados.Add(ordenada[i]);
            }
        }

        return ordenada;
    }

    public static void EscribirLinea(string ruta, string texto)
    {
        using (StreamWriter sw = new StreamWriter(ruta, true))
        {
            sw.WriteLine(texto);
        }
    }

    public static List<string> LeerFicheroLineas(string ruta)
    {
        if (!File.Exists(ruta)) return new List<string>();
        return new List<string>(File.ReadAllLines(ruta));
    }

    public static string LeerFicheroCompleto(string ruta)
    {
        return File.Exists(ruta) ? File.ReadAllText(ruta) : "";
    }

    public static void MostrarConPausa(List<string> lineas, int porPagina = 24)
    {
        for (int i = 0; i < lineas.Count; i++)
        {
            Console.WriteLine(lineas[i]);
            if ((i + 1) % porPagina == 0)
            {
                Console.WriteLine("Presiona Enter para continuar...");
                Console.ReadLine();
            }
        }
    }

    public static void BuscarTexto(string ruta, string palabra)
    {
        if (!File.Exists(ruta))
        {
            Console.WriteLine("El fichero no existe.");
            return;
        }

        var lineas = File.ReadAllLines(ruta);
        bool encontrado = false;
        for (int i = 0; i < lineas.Length; i++)
        {
            if (lineas[i].IndexOf(palabra, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine($"{i + 1}: {lineas[i]}");
                encontrado = true;
            }
        }

        if (!encontrado)
            Console.WriteLine("No se encontró el texto buscado.");
    }

    public static void MostrarFechaActual()
    {
        DateTime ahora = DateTime.Now;
        Console.WriteLine(ahora.ToString("F")); // formato completo
    }

    public static string NombreDia(DateTime fecha)
    {
        return fecha.DayOfWeek.ToString();
    }

    public static int DiasHastaCumple(DateTime cumple)
    {
        DateTime hoy = DateTime.Today;
        DateTime siguienteCumple = new DateTime(hoy.Year, cumple.Month, cumple.Day);
        if (siguienteCumple < hoy)
            siguienteCumple = siguienteCumple.AddYears(1);

        return (siguienteCumple - hoy).Days;
    }

    public static void GuardarXML<T>(string ruta, List<T> lista)
    {
        using (var sw = new StreamWriter(ruta))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            serializer.Serialize(sw, lista);
        }
    }

    public static List<T> CargarXML<T>(string ruta)
    {
        if (!File.Exists(ruta)) return new List<T>();
        using (var sr = new StreamReader(ruta))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            return (List<T>)serializer.Deserialize(sr);
        }
    }

    public static void GuardarJSON<T>(string ruta, List<T> lista)
    {
        string json = JsonSerializer.Serialize(lista);
        File.WriteAllText(ruta, json);
    }

    public static List<T> CargarJSON<T>(string ruta)
    {
        if (!File.Exists(ruta)) return new List<T>();
        string json = File.ReadAllText(ruta);
        return JsonSerializer.Deserialize<List<T>>(json);
    }
}