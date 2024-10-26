using System; 

class Ejercicio1{ //(1.10.3) Suma tres números tecleados por usuario.
	public static void Main(){
		
		int num1;
		int num2;
		int num3;
		int suma;

		System.Console.WriteLine("Introduce el primer numero");
		num1 = System.Convert.ToInt32(
			System.Console.ReadLine());
		System.Console.WriteLine("Introduce el segundo numero");
		num2 = System.Convert.ToInt32(
			System.Console.ReadLine());
			System.Console.WriteLine("Introduce el tercer numero");
			num3 = System.Convert.ToInt32(
				System.Console.ReadLine());
		suma = num1 + num2 + num3;
		System.Console.WriteLine("La suma de " + num1 + " + " + num2 + " + " + num3 + " es igual a " +  suma); //Texto final
	
	}
}
