using System; 

class Ejercicio1{ //(1.6.2.4) Calcula el resultado de 2 + 10 / 5 * 2 - 7 % 1
	public static void Main(){
		
		System.Console.WriteLine("Ejemplo de precedencia de operadores");
		int x = 0;
		x = 5*2;
		x = x / 10;
		System.Console.WriteLine("2 + 10 / 5 * 2 - 7 % 1=");
		System.Console.WriteLine(x + 2);
	}
}
