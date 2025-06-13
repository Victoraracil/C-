using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Crea un programa que sea capaz de transformar texto natural a código
 * morse y viceversa.
 * - Debe detectar automáticamente de qué tipo se trata y realizar
 *   la conversión.
 * - En morse se soporta raya "—", punto ".", un espacio " " entre letras
 *   o símbolos y dos espacios entre palabras "  ".
 * - El alfabeto morse soportado será el mostrado en
 *   https://es.wikipedia.org/wiki/Código_morse.
 */
public class Morse
{
    public Morse() { }
    public string AbecedarioAMorse(string texto)
    {
        string[] abecedarioMorse = new string[]
{
            ".-",    // A
            "-...",  // B
            "-.-.",  // C
            "-..",   // D
            ".",     // E
            "..-.",  // F
            "--.",   // G
            "....",  // H
            "..",    // I
            ".---",  // J
            "-.-",   // K
            ".-..",  // L
            "--",    // M
            "-.",    // N
            "---",   // O
            ".--.",  // P
            "--.-",  // Q
            ".-.",   // R
            "...",   // S
            "-",     // T
            "..-",   // U
            "...-",  // V
            ".--",   // W
            "-..-",  // X
            "-.--",  // Y
            "--.."   // Z
};
        string[] abecedario = new string[]
        {
            "A", "B", "C", "D", "E", "F", "G",
            "H", "I", "J", "K", "L", "M", "N",
            "O", "P", "Q", "R", "S", "T", "U",
            "V", "W", "X", "Y", "Z"
        };
        string[] cadena = texto.Split("");
        for (int i = 0; i < abecedario.Length; i++)
        {
            for (int j = 0; i < abecedario.Length - 1; j++)
            {
                if (cadena[i].ToUpper() == abecedario[j])
                {
                    cadena[i] = abecedarioMorse[i];
                }
            }            
        }
        return cadena.ToString();
    }
    public string MorseAAbecedario(string texto)
    {
        string[] abecedarioMorse = new string[]
{
            ".-",    // A
            "-...",  // B
            "-.-.",  // C
            "-..",   // D
            ".",     // E
            "..-.",  // F
            "--.",   // G
            "....",  // H
            "..",    // I
            ".---",  // J
            "-.-",   // K
            ".-..",  // L
            "--",    // M
            "-.",    // N
            "---",   // O
            ".--.",  // P
            "--.-",  // Q
            ".-.",   // R
            "...",   // S
            "-",     // T
            "..-",   // U
            "...-",  // V
            ".--",   // W
            "-..-",  // X
            "-.--",  // Y
            "--.."   // Z
};
        string[] abecedario = new string[]
        {
            "A", "B", "C", "D", "E", "F", "G",
            "H", "I", "J", "K", "L", "M", "N",
            "O", "P", "Q", "R", "S", "T", "U",
            "V", "W", "X", "Y", "Z"
        };
        return "2";
    }
}
