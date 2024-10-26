using System;

class Tema2{ //(2.1.2.1) Crea un programa que pida al usuario un número entero. Si es múltiplo de 10, informará al usuario y pedirá un segundo número, para decir a continuación si este segundo número también es múltiplo de 10.
	public static void Main(){
		
		int num1, num2;
		
		Console.WriteLine("Introduce un numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
			

		if (num1 % 10 == 0){
			Console.WriteLine(num1 + " es multiplo de 10");
			Console.WriteLine("Introduce otro numero");
			num2 = Convert.ToInt32(
			Console.ReadLine());
			
			if (num1 % 10 == 0){
			Console.WriteLine(num2 + " es multiplo de 10");
			}else{
			Console.WriteLine(num1 + " no es multiplo de 10");
			}	
		}else{
			Console.WriteLine(num1 + " no es multiplo de 10");
		}
	}
}
