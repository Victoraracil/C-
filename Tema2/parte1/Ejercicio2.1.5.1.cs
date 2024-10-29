using System;

class Tema2{ //(2.1.5.1) Crea un programa que pida al usuario un número entero y responda si es múltiplo de 2 o de 3.
	public static void Main(){
		
		float num1;
		
		Console.WriteLine("Introduce un numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
					
		if (num1 % 2 == 0 || num1 % 3 == 0){
			Console.WriteLine(num1 + " es multiplo de 2 o de 3");
		}else{
			Console.WriteLine(num1 + " es multiplo ni de 2 ni de 3");
			
		}
	}
}
