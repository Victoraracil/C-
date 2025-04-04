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

public class Animal
{
    public string Nombre { get; set; }
    public string Especie { get; set; }
    public int Peso { get; set; }
    public Animal() { }
    public Animal(string nombre, string especie, int peso)
    {
        Nombre = nombre;
        Especie = especie;
        Peso = peso;
    }

    public override string ToString()
    {
        return $"Animal – {Nombre} – {Especie} - {Peso}";
    }
}
