using System;

class Tema2{ //(2.1.3.1) Crea un programa que multiplique dos números enteros de la siguiente forma: pedirá al usuario un primer número entero. Si el número que se que teclee es 0, escribirá en pantalla "El producto de 0 por cualquier número es 0". Si se ha tecleado un número distinto de cero, se pedirá al usuario un segundo número y se mostrará el producto de ambos.
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
