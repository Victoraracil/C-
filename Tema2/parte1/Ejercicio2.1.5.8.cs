using System;

class Tema2{ //(2.1.5.8) Crea un programa que pida al usuario dos números enteros y diga "Uno de los números es positivo", "Los dos números son positivos" o bien "Ninguno de los números es positivo", según corresponda.
	public static void Main(){
		
		int num1, num2;
		
		Console.WriteLine("Introduce un numero");
		num1 = Convert.ToInt32(
			Console.ReadLine());
			
		Console.WriteLine("Introduce otro numero");
		num2 = Convert.ToInt32(
			Console.ReadLine());
					
		if (num1 > 0 && num2 > 0){
			Console.WriteLine("Los dos numeros son positivos");	
		}
		if (num1 < 0 && num2 < 0){
			Console.WriteLine("Ningun numero es positivo");			
		}else{
			Console.WriteLine("Uno de los numeros es positivo");
		}
	}
}
