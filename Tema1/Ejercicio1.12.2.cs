using System;

class Ejercicio1{ //(1.12.2) Pide al usuario un número y muestra su tabla de multiplicar, usando {0},{1} y {2}.
	public static void Main(){
		
		int numA;

		System.Console.WriteLine("Introduce un numero");
		numA = System.Convert.ToInt32(
			System.Console.ReadLine());

		System.Console.WriteLine(numA + " X 0 = " + (numA * 0));
		System.Console.WriteLine(numA + " X 1 = " + (numA * 1));
		System.Console.WriteLine(numA + " X 2 = " + (numA * 2));
		System.Console.WriteLine(numA + " X 3 = " + (numA * 3));
		System.Console.WriteLine(numA + " X 4 = " + (numA * 4));
		System.Console.WriteLine(numA + " X 5 = " + (numA * 5));
		System.Console.WriteLine(numA + " X 6 = " + (numA * 6));
		System.Console.WriteLine(numA + " X 7 = " + (numA * 7));
		System.Console.WriteLine(numA + " X 8 = " + (numA * 8));
		System.Console.WriteLine(numA + " X 9 = " + (numA * 9));
		System.Console.WriteLine(numA + " X 10 = " + (numA * 10));
		
	}
}
