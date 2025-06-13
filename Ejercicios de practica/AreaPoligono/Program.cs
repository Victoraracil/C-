using System;
using System.Text.Json.Serialization.Metadata;
/*
 * Crea una única función (importante que sólo sea una) que sea capaz
 * de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 */
public class Program
{
    public static void Main(string[] args)
    {
        string[] poligonos = { "Triangulo", "Cuadrado", "Rectangulo" };
        for (int i = 0; i < poligonos.Length; i++)
        {
            AreaPoligono(poligonos[i]);
        }
    }
    public static void AreaPoligono(string poligono)
    {
        switch (poligono)
        {
            case "Triangulo":
                Console.WriteLine("AreaTriangulo: (base X altura) / 2");
                break;
            case "Cuadrado":
                Console.WriteLine("AreaTriangulo: (lado X lado) / 2");
                break;
            case "Rectangulo":
                Console.WriteLine("AreaTriangulo: (ladoGrande X ladoPequeño) / 2");
                break;
        }
    }
}
