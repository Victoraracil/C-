using System; 

class Ejercicio1{ //(1.10.4) Pide al usuario una cantidad de "millas náuticas" y muestra la equivalencia en metros, usando: 1 milla náutica = 1852 metros.
	public static void Main(){
		
		int num1, rest;
		int num2 = 1852;
		
		System.Console.WriteLine("Introduce las millas nauticas que quieres pasar a metros");
		num1 = System.Convert.ToInt32(
			System.Console.ReadLine());
		rest = num1 * num2;
		System.Console.WriteLine(num1 + " millas nauticas son " + rest + " metros"); //Texto final
	
	}
}
