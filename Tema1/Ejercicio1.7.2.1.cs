using System; 

class Ejercicio1{ //(1.7.2.1) Amplía el ejercicio 1.7.1.1, para que las tres variables n1, n2, n3 estén declaradas en la misma línea y tengan valores iniciales.
	public static void Main(){
		
		System.Console.WriteLine("Ejemplo de precedencia de operadores");
		int n1 = 4, n2 = 3, n3 = 5;
		
		int x = n1 * n3;
		System.Console.WriteLine("3+4*5=");
		System.Console.WriteLine(x + n2);
	}
}

