using System;

class Tema2{ //(2.1.1.3) Crea un programa que pida al usuario dos números enteros y diga si el primero es múltiplo del segundo (pista: igual que en el ejercicio 2.1.1.1, habrá que ver si el resto de la división es cero: a % b == 0).
	public static void Main(){
		
		int num1, num2;
		
		Console.WriteLine("Introduce el primer numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
			
		Console.WriteLine("Introduce el segundo numero");
		num2 = Convert.ToInt32(
			Console.ReadLine());

		if (num1 % num2 == 0 || num2 % num1 == 0){
			Console.WriteLine(num1 + " es multiplo de " + num2);
		}else{
			Console.WriteLine(num1 + " no es multiplo de " + num2);
		}
	}
}
