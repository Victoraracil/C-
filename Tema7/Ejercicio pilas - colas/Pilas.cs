using System;
using System.Collections.Generic;

class Pilas : Lista
{
    Stack<string> pila = new Stack<string>();
    public void MostrarMenu(Program program)
    {
        string op;
        do
        {
            Console.Clear();
            Console.WriteLine("0 - Salir");
            Console.WriteLine("1 - Apilar");
            Console.WriteLine("2 - Desapilar");
            Console.WriteLine("3 - Mostrar elemento cima");
            Console.WriteLine("4 - Pila contiene elemento");
            Console.WriteLine("5 - Mostrar pila");
            Console.WriteLine("6 - Volver al menu");

            op = Console.ReadLine();
            switch (op)
            {
                case "0": break;
                case "1":
                    Console.WriteLine("Introduce el texto a apilar");
                    Apilar(Console.ReadLine());
                    break;
                case "2": Desapilar(); break;
                case "3": MostrarElementoCima(); break;
                case "4": PilaContieneElemento(); break;
                case "5": Listar(); break;
                case "6": program.MostrarMenuPrincipal(); break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
        } while (op != "0");
    }
    public void Apilar(string texto)
    {
        pila.Push(texto);
        siLista(texto);

    }
    public string Desapilar()
    {
      
    }
    public string MostrarElementoCima()
    {
       
    }
    public string PilaContieneElemento()
    {
        

    }
    public string Listar()
    {
        
    }
}
    