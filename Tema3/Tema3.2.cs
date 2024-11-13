using System;
class Program {
	public static void Main() {  //menú principal que llama al punto 3.2
		Console.WriteLine("Ejercicios 3.2");
		
		string op;
		do {
			Console.Clear();
			Console.WriteLine("0 - Salir");
			Console.WriteLine("1 - 3.2.1. Coma fija y coma flotante");
			Console.WriteLine("2 - 3.2.2. Simple y doble precisión");
			Console.WriteLine("3 - 3.2.3. Pedir números reales al usuario");
			Console.WriteLine("4 - 3.2.4. Conversión de tipos (typecast)");			
			Console.WriteLine("5 - 3.2.5. Formatear números");
			Console.WriteLine("6 - 3.2.6. Cambios de base");
			Console.WriteLine("7 - 3.2.7. Funciones matemáticas");

			
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
				default: Console.WriteLine("Opción incorrecta"); break;
			}

		}while (op != "0");
	}
	
	public static void punto1(){
		
	}
	public static void punto2(){
		
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
}
