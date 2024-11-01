using System;

class Tema2{ //(2.1.5.9) Crea un programa que pida al usuario tres números y muestre cuál es el mayor de los tres.
	public static void Main(){
		
		int num1, num2, num3, max;
		
		Console.WriteLine("Introduce el primer numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
			
		Console.WriteLine("Introduce el segundo numero");
		num2 = Convert.ToInt32(
			Console.ReadLine());
			
		Console.WriteLine("Introduce el tercer numero");
		num3 = Convert.ToInt32(
			Console.ReadLine());
					
		max = num1;
		if (num2 > max){
			max = num2;
		}
		if (num3 > max){
			max = num3;
		}
		Console.WriteLine(max + " es el numero mas grande")	;
	}
}
