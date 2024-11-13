using System;
class Program {
	public static void Main() {  //menú principal que llama al Tema 4
		Console.WriteLine("Ejercicios Tema 4");
		
		string op;
		do {
			Console.Clear();
			Console.WriteLine("0 - Salir");
			Console.WriteLine("1 - 3.1.1. Tipos de datos para números enteros");
			Console.WriteLine("2 - 3.1.2. Conversiones de cadena a entero");
			Console.WriteLine("3 - 3.1.3. Incremento y decremento");
			Console.WriteLine("4 - 3.1.4. Operaciones abreviadas");			
			Console.WriteLine("5 - 3.1.5. Asignaciones múltiples");
			Console.WriteLine("6 - 3.1.6. Operaciones con bits");

			
			op = Console.ReadLine();
			
			switch (op) {
				case "0": break;
				case "1": punto1(); break;
				case "2": punto2(); break;
				case "3": punto3(); break;
				case "4": punto4(); break;
				case "5": punto5(); break;
				case "6": punto6(); break;
				default: Console.WriteLine("Opción incorrecta"); break;
			}

		}while (op != "0");
	}
