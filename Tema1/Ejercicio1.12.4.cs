using System; 

class Ejercicio1{ //(1.12.4) Crea un programa que convierta de grados Celsius (centígrados) a Kelvin y a Fahrenheit: pedirá al usuario la cantidad de grados centígrados y usará las siguiente tablas de conversión: kelvin = celsius + 273 ; fahrenheit = celsius x 18 / 10 + 32. Emplea "Write" en vez de "{0}" cuando debas mostrar varios datos en la misma línea.
	public static void Main(){
		
		int num1;
		
		
		System.Console.WriteLine("Introduce los grados celsius a convertir");
		num1 = System.Convert.ToInt32(
			System.Console.ReadLine());

		int num2 = num1 + 273;
		int num3 = ((num1 *18) / 10) + 32;
		
		System.Console.WriteLine(num1 + " grados Celsius son " + num2 + " grados Kelvin"); //Texto final
		System.Console.WriteLine(num1 + " grados Celsius son " + num3 + " grados Fahrenheit"); //Texto final

	}
}
