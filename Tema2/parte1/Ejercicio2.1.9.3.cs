using System;

class Tema2{ //(2.1.9.3) Crea un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal, una cifra numérica o una consonante, usando "switch".
	public static void Main(){
		
		char letra;
		Console.WriteLine("Introduce una letra");
		letra = Convert.ToChar( Console.ReadLine() );
		switch (letra)
		{
		case 'a':
		case 'e':
		case 'i':
		case 'o':
		case 'u': Console.WriteLine("Es una vocal."); 
		break;
		case '1':
		case '2':
		case '3':
		case '4':
		case '5':
		case '6':
		case '7':
		case '8':
		case '9':
		case '0': Console.WriteLine("Es una cifra numerica.");
		break;
		default: Console.WriteLine("Es una consonante.");
		break;
		}
	}
}
