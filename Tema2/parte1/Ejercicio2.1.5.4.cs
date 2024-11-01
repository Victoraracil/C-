using System;

class Tema2{ //(2.1.5.4) Crea un programa que pida al usuario un número entero y responda si no es múltiplo de 2 ni de 3.
	public static void Main(){
		
		int num1;
		
		Console.WriteLine("Introduce un numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
					
		if (!(num1 % 2 == 0) && !(num1 % 3 == 0)){
			Console.WriteLine(num1 + " no es multiplo de 2 ni de 3");
		}else{
			Console.WriteLine(num1 + " es multiplo de 2, de 3 o de ambos");
			
		}
	}
}
