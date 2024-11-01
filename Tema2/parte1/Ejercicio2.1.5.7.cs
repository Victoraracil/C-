using System;

class Tema2{ //(2.1.5.7) Crea un programa que pida al usuario dos números enteros y diga si uno y sólo uno es par.
	public static void Main(){
		
		int num1, num2;
		
		Console.WriteLine("Introduce un numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
			
		Console.WriteLine("Introduce otro numero");
		num2 = Convert.ToInt32(
			Console.ReadLine());
					
		if (num1 % 2 == 0 || num2 % 2 == 0){
			if (num1 % 2 == 0){
				Console.WriteLine(num1 + " es par");
			}
			if (num2 % 2 == 0){
				Console.WriteLine(num2 + " es par");
			}	
		}else{
			Console.WriteLine("Ningun numero es par");
			
		}
	}
}
