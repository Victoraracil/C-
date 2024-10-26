using System; 

class Ejercicio1{ //(1.7.2.2) Amplía el ejercicio 1.7.2.1, declarando también una variable "suma" y guardando en ella el resultado de sumar n1, n2 y n3
	public static void Main(){
		
		System.Console.WriteLine("Ejemplo de precedencia de operadores");
		int n1 = 4, n2 = 3, n3 = 5, suma;		
		int x = n1 * n3;
		suma = n1 + n2 + n3;
		System.Console.WriteLine("3+4*5=");
		System.Console.WriteLine(x + n2);
		System.Console.WriteLine(suma);
	}
}
