using System; //Realizado por Victor Aracil Gozalvez el 12/10/2024

class Ejercicio1{ //(1.11.2) Crea una nueva versión del programa que calcula la división de dos números introducidos por el usuario, así como el resto de esa división (1.10.2), empleando "using System". Deberás incluir un comentario con tu nombre y la fecha en que has realizado el programa.
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
