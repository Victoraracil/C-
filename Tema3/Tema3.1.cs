using System;
class Program {
	public static void Main() {  //menú principal que llama al punto 3.1
		Console.WriteLine("Ejercicios 3.1");
		
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
	
	public static void punto1() {
		Console.Clear();
		Console.WriteLine("3.1.1. Tipos de datos para números enteros");
		
		/*(3.1.1.1) Calcula el producto de 1.000.000 por 1.000.000, 
		usando una variable llamada "producto", de tipo "long". 
		Prueba también a calcularlo usando una variable de tipo "int".*/

		Console.WriteLine("Con variable tipo int");
		int producto2 = 1000000;
		producto2 = producto2 * producto2;
		Console.WriteLine("El resultado es " + producto2);

		Console.WriteLine("Con variable tipo long");
		long producto = 1000000;
		producto = producto * producto;
		Console.WriteLine("El resultado es " + producto);
		
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();
	}
	
	public static void punto2(){
		Console.WriteLine("3.1.2. Conversiones de cadena a entero");
		
		/*(3.1.2.1) Pregunta al usuario su edad, que se guardará en un "byte". A
		continuación, le deberás decir que no aparenta tantos años (por ejemplo, "No
		aparentas 20 años").*/
		
		Console.WriteLine("Ejercicio 3.1.2.1");
		Console.WriteLine("Introduce tu edad");
		string num;
		num = Console.ReadLine();
		byte edad = Convert.ToByte(num);
		
		Console.WriteLine("No aparentas " + edad + " anyos"); 
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();
		
		
		
		/*(3.1.2.2) Pide al usuario dos números de dos cifras ("byte"), calcula su
		multiplicación, que se deberá guardar en un "int", y muestra el resultado en
		pantalla.*/
		
		Console.WriteLine("Ejercicio 3.1.2.1");
		
		byte num1=0, num2=0;
		Console.WriteLine("Introduce un numero de dos cifras");
		num1 = Convert.ToByte(Console.ReadLine());
		
		Console.WriteLine("Introduce otro numero de dos cifras");
		num2 = Convert.ToByte(Console.ReadLine());
		
		int rest = num1 * num2;
		
		Console.WriteLine(num1 + " X " + num2 + " = " + rest);
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();
		
		/*(3.1.2.3) Pide al usuario dos números enteros largos ("long") y muestra su suma,
		su resta y su producto.*/
		
		long numa=0, numb=0;
		Console.WriteLine("Introduce un numero entero (puede ser largo)");
		numa = Convert.ToInt64(Console.ReadLine());
		
		Console.WriteLine("Introduce otro número entero (puede ser largo):");
        numb = Convert.ToInt64(Console.ReadLine());
		
		long rest1 = numa + numb;
		long rest2 = numa - numb;
		long rest3 = numa * numb;
		
		Console.WriteLine(num1 + " + " + num2 + " = " + rest1);
		Console.WriteLine(num1 + " - " + num2 + " = " + rest2);
		Console.WriteLine(num1 + " X " + num2 + " = " + rest3);
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();
		
	}

	public static void punto3(){
		Console.WriteLine("3.1.3. Incremento y decremento");
		
		/*(3.1.3.1) Crea un programa que use tres variables enteras x,y,z. Sus valores
		iniciales serán 15, -10, 2.147.483.647. Se deberá incrementar el valor de estas
		variables. ¿Qué valores esperas que se obtengan? Contrástalo con el resultado
		obtenido por el programa.*/
		
		int x = 15, y = -15, z = 2147483647;
		x++;
		y++;
		z++;
		Console.WriteLine("X = "+ x + "  Incrementa a 16");
		Console.WriteLine("Y = "+ y + "  Al ser negativo pasa a -14");
		Console.WriteLine("Z = "+ z + "  No se :(");
		
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();

		/*(3.1.3.2) ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++;
		b=b*5; a=a*2; Calcúlalo a mano y luego crea un programa que lo resuelva, para
		ver si habías hallado la solución correcta.*/
		
		int a, b, c;
		a = 5;
		Console.WriteLine("a = " + a);
		b = ++a;
		Console.WriteLine("b = " + b);
		c = a++;
		Console.WriteLine("c = " + c);
		b = b * 5;
		Console.WriteLine("b = " + b);
		a = a * 2;
		Console.WriteLine("a = " + a);
		
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();
	}
	
	public static void punto4(){
		Console.WriteLine("3.1.4. Operaciones abreviadas");
		
		/*(3.1.4.1) Crea un programa que use tres variables x,y,z. Sus valores iniciales serán
		15, -10, 214. Deberás incrementar el valor de estas variables en 12, usando el
		formato abreviado. ¿Qué valores esperas que se obtengan? Contrástalo con el
		resultado obtenido por el programa.*/
		
		int x = 15, y = -10, z = 214;
		x+=12;
		y+=12;
		z+=12;
		Console.WriteLine("X = "+ x + "  Incrementa a 27");
		Console.WriteLine("Y = "+ y + "  Incrementa a 2");
		Console.WriteLine("Z = "+ z + "  Incrementa a 226");
		
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();
		
		/*(3.1.4.2) ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3;
		c=-3; c*=2; ++c; a*=b; Crea un programa que te lo muestre.*/	
		
		
		int a, b, c;
		a = 5;
		Console.WriteLine("a = " + a);
		b = 2 +a;
		Console.WriteLine("b = " + b);
		b-= 3;
		Console.WriteLine("b = " + b);
		c = -3;
		Console.WriteLine("c = " + c);
		c*= 2;
		Console.WriteLine("c = " + c);
		c++;
		Console.WriteLine("c = " + c);
		a*= b;
		Console.WriteLine("a = " + a);
		
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();	
	}
	
	public static void punto5(){
		Console.WriteLine("3.1.5. Asignaciones múltiples");
		
		Console.WriteLine("Este apartado no tiene ejercicios");
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();		
	}
	
	public static void punto6(){
		Console.WriteLine("3.1.6. Operaciones con bits");
		
		/*(3.1.6.1) Crea un programa que pida al número del 0 al 255 y muestre el resultado
		de hacer un XOR con un cierto dato prefijado (y también en ese rango).
		Comprueba que la operación es reversible (por ejemplo, 131 xor 5 = 134, y 134 xor
		5 = 131).*/	
		
		int num, num1;
		Console.WriteLine("Introduce un numero entre 0 y 255");
		num = Convert.ToInt32(
			Console.ReadLine());
			
		num1 = num^5;
		
		Console.WriteLine("La suma logica de " + num + " + 5 es " + num1);
			
		
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();
	}
}

