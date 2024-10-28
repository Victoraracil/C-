using System;

class Tema2{ //(2.1.4.1) Mejora la solución al ejercicio 2.1.3.1, usando "else".
	public static void Main(){
		
		int num1, num2;
		
		Console.WriteLine("Introduce un numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
			
		if (num1 == 0){
		
			
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
