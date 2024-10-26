using System; //Al emplear "using System" no hace falta poner "System" al inicio de cada orden

class Ejercicio1{ //(1.11.1) Crea una nueva versión del programa que calcula el producto de dos números introducidos por el usuario (1.10.1), empleando "using System". El programa deberá contener un comentario al principio, que recuerde cual es su objetivo.
	public static void Main(){
		
		int num1;
		int num2;
		int suma;

		Console.WriteLine("Introduce el primer numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
		Console.WriteLine("Introduce el segundo numero");
		num2 = Convert.ToInt32(
			Console.ReadLine());
		suma = num1 + num2;
		Console.WriteLine("La suma de " + num1 + " + " + num2 + " es igual a " +  suma); //Texto final
	
	}
}
