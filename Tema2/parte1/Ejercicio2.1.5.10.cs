using System;

class Tema2{ //(2.1.5.10) Crea un programa que pida al usuario dos números enteros y diga si son iguales o, en caso contrario, cuál es el mayor de ellos.
	public static void Main(){
		
		int num1, num2, max;
		
		Console.WriteLine("Introduce el primer numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
			
		Console.WriteLine("Introduce el segundo numero");
		num2 = Convert.ToInt32(
			Console.ReadLine());
					
		if (num1 == num2){
			Console.WriteLine("Ambos numeros son iguales");
		}else{
			Console.WriteLine("Los numeros no son iguales");			
					
			max = num1;
			if (num2 > max){
				max = num2;
			}
			Console.WriteLine(max + " es el numero mas grande")	;
		}
	}
}
