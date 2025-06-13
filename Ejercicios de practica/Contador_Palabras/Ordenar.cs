using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Crea un programa que cuente cuantas veces se repite cada palabra
 * y que muestre el recuento final de todas ellas.
 * - Los signos de puntuación no forman parte de la palabra.
 * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
 * - No se pueden utilizar funciones propias del lenguaje que
 *   lo resuelvan automáticamente.
 */
public class Ordenar
{
    public Ordenar() { }
    public static string[] RepitoPalabra(string[] palabras)
     {
        string[] norepito = new string[palabras.Length];
       
        for (int i = 0; i < palabras.Length; i++) 
        {
            int contador = 0;
            for (int j = 0; j < palabras[i].Length-1; j++)
            {
                if (palabras[i].ToLower() == palabras[j].ToLower())
                {
                    contador++;
                }
            }
            norepito[i] = (palabras[i].ToLower() + contador);

        }
        return norepito.Distinct().ToArray();
        
    }
}