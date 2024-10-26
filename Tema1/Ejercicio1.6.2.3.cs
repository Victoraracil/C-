using System; 

class Ejercicio1{ //(1.6.2.3) Calcula el resultado de 15 + -5*6 / 10
	public static void Main(){
		
		System.Console.WriteLine("Ejemplo de precedencia de operadores");
		int x = 0;
		x = -5*6;
		x = x / 10;
		System.Console.WriteLine("15 + -5*6 / 10=");
		System.Console.WriteLine(x );
	}
}
