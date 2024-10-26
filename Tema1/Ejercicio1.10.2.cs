using System; 

class Ejercicio1{ //(1.10.2) Crea un programa que calcule la división de dos números introducidos por el usuario, así como el resto de esa división.
	public static void Main(){
		
		int num1;
		int num2;
		int div;
		float rest;

		System.Console.WriteLine("Introduce el primer numero");
		num1 = System.Convert.ToInt32(
			System.Console.ReadLine());
		System.Console.WriteLine("Introduce el segundo numero");
		num2 = System.Convert.ToInt32(
			System.Console.ReadLine());
		div = num1 / num2;
		rest = num1 % num2;
		System.Console.WriteLine("La division de " + num1 + " / " + num2 + " es igual a " +  div + " con resto " + rest); //Texto final
	
	}
}
