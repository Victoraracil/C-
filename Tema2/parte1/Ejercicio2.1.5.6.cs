using System;

class Tema2{ //(2.1.5.6) Crea un programa que pida al usuario dos números enteros y diga si (al menos) uno es par.
	public static void Main(){
		
		int num1, num2;
		
		Console.WriteLine("Introduce un numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
			
		Console.WriteLine("Introduce otro numero");
		num2 = Convert.ToInt32(
			Console.ReadLine());
					
		if (num1 % 2 == 0 || num2 % 2 == 0){
			Console.WriteLine("Uno de los dos numeros es par");
		}else{
			Console.WriteLine("Ningun numero es par");
			
		}
	}
}
