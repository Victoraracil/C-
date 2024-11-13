using System;

class Tema2{ //(2.1.9.2) Crea un programa que lea una letra tecleada por el usuario y diga si se trata de un signo de puntuación (. , ; :), una cifra numérica (del 0 al 9) o algún otro carácter, usando "switch" (pista: necesitarás que usar un dato de tipo "char").
	public static void Main(){
		
		char letra;
		Console.WriteLine("Introduce una letra");
		letra = Convert.ToChar( Console.ReadLine() );
		switch (letra)
		{
		case '.':
		case ',': 
		case ':':
		case ';': Console.WriteLine("Signo de puntuacion."); 
		break;
		case '1': Console.WriteLine("Uno."); break;
		case '2': Console.WriteLine("Dos."); break;
		case '3': Console.WriteLine("Tres."); break;
		case '4': Console.WriteLine("Cuatro."); break;
		case '5': Console.WriteLine("Cinco."); break;
		case '6': Console.WriteLine("Seis."); break;
		case '7': Console.WriteLine("Siete."); break;
		case '8': Console.WriteLine("Ocho."); break;
		case '9': Console.WriteLine("Nueve."); break;
		case '0': Console.WriteLine("Cero.");
		break;
		default: Console.WriteLine("Otro caracter.");
		break;
		}
	}
}
