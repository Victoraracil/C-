using System;

class Tema2{ //(2.1.8.2) Usa el operador condicional para calcular el menor de dos números.
	public static void Main(){
		
		int a, b, numeroMenor;
		
		Console.WriteLine("Introduce un numero");
		a = Convert.ToInt32(
			Console.ReadLine());
			
		Console.WriteLine("Introduce otro numero");
		b = Convert.ToInt32(
			Console.ReadLine());

		numeroMenor = a > b ? a : b;
		
		Console.WriteLine( a + " es nenor que " + b);
		
	}	
}
