using System; 

class Tema2{ //(2.1.1.1) Crea un programa que pida al usuario un número entero y diga si es par (pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero: if (x % 2 == 0) …).
	public static void Main(){
		
		int num1;
		
		Console.WriteLine("Introduce un numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());

		if (num1 % 2 == 0){
			Console.WriteLine("Tu numero es par");
		}else{
			Console.WriteLine("Tu numero es inpar");
		}
	}
}
