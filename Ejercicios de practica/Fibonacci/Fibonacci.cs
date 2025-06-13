using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*
 * Escribe un programa que imprima los 50 primeros números de la sucesión
 * de Fibonacci empezando en 0.
 * - La serie Fibonacci se compone por una sucesión de números en
 *   la que el siguiente siempre es la suma de los dos anteriores.
 *   0, 1, 1, 2, 3, 5, 8, 13...
 */
public class Fibonacci
{
    public Fibonacci() { }

    public void DictarSerie()
    {
        var n0 = 0;
        var n1 = 1;

        for (var i = 0; i < 50; i++)
        {
            Console.WriteLine(n0);
            var fib = n0 + n1;
            n0 = n1;
            n1 = fib;
        }       
    }

}
