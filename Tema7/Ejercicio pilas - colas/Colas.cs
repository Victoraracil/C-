using System;
using System.Collections.Generic;

class Colas : Lista
{
    Queue<string> cola = new Queue<string>();
    public void MostrarMenu(Program program)
    {
        string op;
        do
        {
            Console.Clear();
            Console.WriteLine("0 - Salir");
            Console.WriteLine("1 - Encolar");
            Console.WriteLine("2 - Desencolar");
            Console.WriteLine("3 - mostrar elemento cima");
            Console.WriteLine("4 - Cola contiene elemento");
            Console.WriteLine("5 - Mostrar cola");
            Console.WriteLine("6 - Volver al menu");
            op = Console.ReadLine();
            switch (op)
            {
                case "0": break;
                case "1":
                    Console.WriteLine("Introduce el texto a encolar");
                    Encolar(Console.ReadLine());
                    break;
                case "2": Desencolar(); break;
                case "3": MostrarElementoCima(); break;
                case "4": ColaContieneElemento(); break;
                case "5": Listar(); break;
                case "6": program.MostrarMenuPrincipal(); break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
        } while (op != "0");
    }
    public void Encolar(string texto)
    {

    
    }
    public string Desencolar()
    {
        
    }
    public string MostrarElementoCima()
    {

    }
    public string ColaContieneElemento()
    {
       

    }
    public string Listar()
    {
        
    }
}
