using System;

class Tema2{ //(2.1.1.2) Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos.
	public static void Main(){
		
		int num1, num2;
		
		Console.WriteLine("Introduce un numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
			
		Console.WriteLine("Introduce un numero");
		num2 = Convert.ToInt32(
			Console.ReadLine());

		if (num1 < num2){
			Console.WriteLine(num2 + " es mayo que " + num1);
		}else{
			Console.WriteLine(num1 + " es mayo que " + num2);
		}
	}
}
