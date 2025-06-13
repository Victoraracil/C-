using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Escribe una función que reciba dos palabras (String) y retorne
 * verdadero o falso (Bool) según sean o no anagramas.
 * - Un Anagrama consiste en formar una palabra reordenando TODAS
 *   las letras de otra palabra inicial.
 * - NO hace falta comprobar que ambas palabras existan.
 * - Dos palabras exactamente iguales no son anagrama.
 */
public class Anagrama
{
    public Anagrama() { }
    public bool ComprobarAnagrama(string palabra1, string palabra2)
    {
        if (palabra1.Length != palabra2.Length) {  return false; }
        if (palabra1 == palabra2) { return false; }
        int contador = 0;
        for (int i = 0; i < palabra1.Length; i++)
        {
            for (int j = 0; j < palabra2.Length; j++)
            {
                if (palabra1[i] == palabra2[j])
                {
                    contador++;
                    break;
                }
            }
        }
        if (contador == palabra1.Length) { return true; }
        return false;
    }

}
