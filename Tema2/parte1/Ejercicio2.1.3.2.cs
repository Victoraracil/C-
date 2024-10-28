using System;

class Tema2{ //(2.1.3.2) Crea un programa que pida al usuario dos números enteros. Si el segundo no es cero, mostrará el resultado de dividir el primero entre el segundo. Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre cero
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
