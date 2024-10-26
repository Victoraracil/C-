using System;

class Ejercicio1{ //(1.12.1) El usuario tecleará dos números (a y b), y el programa mostrará el resultado de la operación (a+b)*(a-b) y el resultado de la operación a2-b2. Ambos resultados se deben mostrar en la misma línea.
	public static void Main(){
		
		int numA;
		int numB;
		int rest, rest1, rest2, rest3;

		System.Console.WriteLine("Introduce el primer numero");
		numA = System.Convert.ToInt32(
			System.Console.ReadLine());
		System.Console.WriteLine("Introduce el segundo numero");
		numB = System.Convert.ToInt32(
			System.Console.ReadLine());
		
		rest1 = numA + numB;
		rest2 = numA - numB;
		rest = rest1 * rest2;
		rest3 = (numA * numA) - (numB * numB);
		System.Console.WriteLine("(" + numA + " + " + numB + ") * (" + numA + " - " + numB + ") = " + rest + "         " + numA + "*2 - " + numB + "*2 =" + rest3); //En esta ultima operacion, el simbolo "*" lo uso para referirme a que los numero estan elevados al cuadrado
	
	}
}
