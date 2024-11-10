using System;

class Tema2{ //(2.1.9.1) Crea un programa que pida un número del 1 al 10 al usuario, y escriba el nombre de ese número, usando "switch" (por ejemplo, si introduce "1", el programa escribirá "uno").
	public static void Main(){
		
		char letra;
		Console.WriteLine("Introduce una letra");
		letra = Convert.ToChar( Console.ReadLine() );
		switch (letra)
		{
		case ' ': Console.WriteLine("Espacio.");
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
		case '0': Console.WriteLine("Diez.");
		break;
		default: Console.WriteLine("Ni espacio ni dígito.");
		break;
		}
	}
}
