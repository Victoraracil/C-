using System;
using System.IO;
/*Crea un programa que vaya leyendo las frases que el usuario teclea y las
guarde en un fichero de texto llamado "registroDeUsuario.txt". Terminará cuando
la frase introducida sea "fin" (esa frase no deberá guardarse en el fichero)*/
class Program
{
    static void Main()
    {
        string frase;
        StreamWriter fichero = File.CreateText("registroDeUsuario.txt");
        do
        {
            Console.Write("Introduce una frase (fin para finalizar): ");
            frase = Console.ReadLine();
            if (frase != "fin")
                fichero.WriteLine(frase);
        } while (frase != "fin");
        fichero.Close();
        Console.WriteLine("Registro guardado en registroDeUsuario.txt");
    }
}