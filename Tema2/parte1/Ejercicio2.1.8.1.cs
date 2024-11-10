using System;

class Tema2{ //(2.1.8.1) Crea un programa que use el operador condicional para mostrar el valor absoluto de un número de la siguiente forma: si el número es positivo, se mostrará tal cual; si es negativo, se mostrará cambiado de signo
	public static void Main(){
		
		int num1, rest;
		
		Console.WriteLine("Introduce un numero y te dire su valor absoluto");
		num1 = Convert.ToInt32(
			Console.ReadLine());

		rest = num1>0 ? num1*1 : num1*-1;
		
		Console.WriteLine("El valor absoluto de " + num1 + " es " + rest);
		
	}	
}
