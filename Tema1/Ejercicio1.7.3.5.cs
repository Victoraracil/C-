using System; 

class Ejercicio1{ //(1.7.3.5) Amplía el ejercicio 1.7.2.2, para que se muestre la suma de los tres números.
	public static void Main(){
		
		System.Console.WriteLine("Ejemplo de precedencia de operadores");
		int n1 = 4, n2 = 3, n3 = 5;
		
		int x = n1 + n3;
		x = x + n2;
		System.Console.WriteLine("3+4+5=" );
		System.Console.WriteLine(x);
	
	}
}
