using System; 

class Ejercicio1{ //(1.7.1.1): Amplía el "Ejemplo 01.06.02a" para declarar tres variables, llamadas n1, n2, n3.
	public static void Main(){
		
		System.Console.WriteLine("Ejemplo de precedencia de operadores");
		int n1 = 4;
		int n2 = 3;
		int n3 = 5;
		int x = n1 * n3;
		System.Console.WriteLine("3+4*5=");
		System.Console.WriteLine(x + n2);
	}
}
