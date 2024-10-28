using System;

class Tema2{ //(2.1.4.2) Mejora la solución al ejercicio 2.1.3.2, usando "else".
	public static void Main(){
		
		float num1, num2, rest;
		
		Console.WriteLine("Introduce el primer numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
					
		Console.WriteLine("Introduce el segundo numero");
		num2 = Convert.ToInt32(
			Console.ReadLine());

		if (num2 == 0){
			Console.WriteLine("No se puede dividir entre 0 ");
		}else{
			rest = num1 / num2;
			Console.WriteLine(num1 + " dividido entre " + num2 + " = " + rest);
		}
	}
}
