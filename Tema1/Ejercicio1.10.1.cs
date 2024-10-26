using System; 

class Ejercicio1{ //(1.10.1) Crea un programa que calcule el producto de dos introducidos por el usiario.
	public static void Main(){
		
		int num1;
		int num2;
		int suma;

		System.Console.WriteLine("Introduce el primer numero");
		num1 = System.Convert.ToInt32(
			System.Console.ReadLine());
		System.Console.WriteLine("Introduce el segundo numero");
		num2 = System.Convert.ToInt32(
			System.Console.ReadLine());
		suma = num1 + num2;
		System.Console.WriteLine("La suma de " + num1 + " + " + num2 + " es igual a " +  suma); //Texto final
	
	}
}
