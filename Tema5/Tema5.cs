using System;
class Program {
	public static void Main() {  //menú principal que llama al Tema 5. Introducción a las funciones
		Console.WriteLine("Ejercicios Tema 4");
		
		Mostrarmenu();
	}	
		
	public static void Mostrarmenu() {
		string op;
		do {
			Console.Clear();
			Console.WriteLine("0 - Salir");
			Console.WriteLine("1 - 5.1. Diseño modular de programas: Descomposición modular");
			Console.WriteLine("2 - 5.2. Conceptos básicos sobre funciones");
			Console.WriteLine("3 - 5.3. Parámetros de una función");
			Console.WriteLine("4 - 5.4. Valor devuelto por una función. El valor void");			
			Console.WriteLine("5 - 5.5. Variables locales y variables globales");
			Console.WriteLine("6 - 5.6. Los conflictos de nombres en las variables");
			Console.WriteLine("6 - 5.7. Modificando parámetros");
			Console.WriteLine("6 - 5.8. El orden no importa");
			Console.WriteLine("6 - 5.9. Recursividad");
			Console.WriteLine("6 - 5.10. Parámetros y valor de retorno de Main");
			Console.WriteLine("6 - 5.11. Parámetros con valores por defecto y con nombre");


			
			op = Console.ReadLine();
			
			switch (op) {
				case "0": break;
				case "1": punto1(); break;
				case "2": punto2(); break;
				case "3": punto3(); break;
				case "4": punto4(); break;
				case "5": punto5(); break;
				case "6": punto6(); break;
				case "7": punto7(); break;
				case "8": punto8(); break;
				case "9": punto9(); break;
				case "10": punto10(); break;
				case "11": punto11(); break;
				default: Console.WriteLine("Opción incorrecta"); break;
			}

		}while (op != "0");
	}
	
	public static void punto1(){
		
	}
	public static void punto2(){
		
		/*(5.2.1) Crea una función llamada "BorrarPantalla", que borre la pantalla dibujando
		25 líneas en blanco. Crea también un "Main" que permita probarla.*/
		public static void BorrarPantalla(){
		
			Console.WriteLine("Funcion borrar pantalla");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine("Presiona ENTER para continuar...");
			Console.ReadLine();
		}		
		
		/*(5.2.2) Crea una función llamada "DibujarCuadrado3x3", que dibuje un cuadrado
		formato por 3 filas con 3 asteriscos cada una. Incluye un "Main" para probarla.*/
		
		
		/*(5.2.3) Descompón en funciones la base de datos de ficheros (ejemplo 04_06a), de
		modo que el "Main" sea breve y más legible (Pista: las variables que se compartan
		entre varias funciones deberán estar fuera de todas ellas, y deberán estar
		precedidas por la palabra "static").*/
		
		
	}
	public static void punto3(){
	
	}
	public static void punto4(){
	
	}
	public static void punto5(){
	
	}
	public static void punto6(){
	
	}
	public static void punto7(){
	
	}
	public static void punto8(){
	
	}	
	public static void punto9(){
	
	}	
	public static void punto10(){
	
	}	
	public static void punto11(){
	
	}			
}
