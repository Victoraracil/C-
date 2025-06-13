using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*
 * Crea un programa se encargue de transformar un número
 * decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.
 */
public class Conversor
{
    public Conversor() { }

    public string DecimalABinario(int numero)
    {
        string binario = "";
        while (numero != 0)
        {

            int reminder = numero % 2;
            numero /= 2;

            binario = reminder + binario;
        }
        if (binario == "")
        {
            return binario + "0";
        }
        else
        {
            return binario;
        }
    }
    public void BinarioADecimal()
    {

    }
}
