using System; 

class Ejercicio1{ //(1.7.3.4) Amplía el ejercicio 1.7.2.1, para que se muestre el resultado de la operación n1+n2*n3.
	public static void Main(){
		
		System.Console.WriteLine("Ejemplo de precedencia de operadores");
		int n1 = 4, n2 = 3, n3 = 5;
		
		int x = n1 * n3;
		x = x + n2;
		System.Console.WriteLine("3+4*5=" );
		System.Console.WriteLine(x);
	
	}
}
