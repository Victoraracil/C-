using System;

class Tema2{ //(2.1.7.4) Crea el diagrama de flujo y la versión en C# de un programa que dé al usuario tres oportunidades para adivinar un número del 1 al 10, usando 3 "if" encadenados.
	public static void Main(){
		
		int num1, numsec;
		
		Random random = new Random();
        numsec = random.Next(1, 11);
		
		Console.WriteLine("Intenta adivinar el numero entre 1 y 10");
		num1 = Convert.ToInt32(
			Console.ReadLine());
			
		if (num1 == numsec){
			Console.WriteLine("Correcto! Has adivinado que el numero era " + numsec + " al primer intento");
		}else{
			Console.WriteLine("Incorrecto! Te quedan dos intentos");
			Console.WriteLine("Intenta adivinar el numero entre 1 y 10");
			num1 = Convert.ToInt32(
			Console.ReadLine());
			
			if (num1 == numsec){
				Console.WriteLine("Correcto! Has adivinado que el numero era " + numsec + " al segundo intento");
			}else{
				Console.WriteLine("Incorrecto! Te queda un intentos");
				Console.WriteLine("Intenta adivinar el numero entre 1 y 10");
				num1 = Convert.ToInt32(
				Console.ReadLine());
				
				if (num1 == numsec){
					Console.WriteLine("Correcto! Has adivinado que el numero era " + numsec + " en el ultimo intento");
				}else{
					Console.WriteLine("Incorrecto! Te has quedado sin intentos");
					Console.WriteLine("El numero era " + numsec);

				}	
			}
		}
	}
}
