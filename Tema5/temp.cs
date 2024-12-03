using System;
class Ejemplo_05_10a{
	static long Factorial(int n){
			if (n==1) // Aseguramos que termine (caso base)
			return 1;
			return n * Factorial(n-1); // Si no es 1, sigue la recursión
		}
		static void Main(){
		int num;
			Console.WriteLine("Introduzca un número entero: ");
			num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Su factorial es: {0}", Factorial(num));
	}
}
