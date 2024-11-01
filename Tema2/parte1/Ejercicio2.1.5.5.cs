using System;

class Tema2{ //(2.1.5.5) Crea un programa que pida al usuario dos números enteros y diga si ambos son pares.
	public static void Main(){
		
		int num1, num2;
		
		Console.WriteLine("Introduce un numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
			
		Console.WriteLine("Introduce otro numero");
		num2 = Convert.ToInt32(
			Console.ReadLine());
					
		if (num1 % 2 == 0 && num2 % 2 == 0){
			Console.WriteLine("Ambos numeros son pares");
		}else{
			Console.WriteLine("Uno de los numeros no es par");
			
		}
	}
}
