using System;

class Ejercicios_Recursividad{
	public static void Main() {
		Console.WriteLine("Ejercicios Recursividad Tema 5");
		Mostrarmenu();
	}	
	public static void Mostrarmenu() {
		string op;
		do {
			Console.Clear();
			Console.WriteLine("0 - Salir");
			Console.WriteLine("1 - Ejercicio 1");
			Console.WriteLine("2 - Ejercicio 2");
			Console.WriteLine("3 - Ejercicio 3");
			Console.WriteLine("4 - Ejercicio 4");			
			Console.WriteLine("5 - Ejercicio 5");
			Console.WriteLine("6 - Ejercicio 6");
			Console.WriteLine("7 - Ejercicio 7");
			Console.WriteLine("8 - Ejercicio 8");
			Console.WriteLine("9 - Ejercicio 9");
			Console.WriteLine("10 - Ejercicio 10");
			Console.WriteLine("11 - Ejercicio 11");


			
			op = Console.ReadLine();
			
			switch (op) {
				case "0": break;
				case "1": Ejercicio1(); break;
				case "2": Ejercicio2(); break;
				case "3": Ejercicio3(); break;
				case "4": Ejercicio4(); break;
				case "5": Ejercicio5(); break;
				case "6": Ejercicio6(); break;
				case "7": Ejercicio7(); break;
				case "8": Ejercicio8(); break;
				case "9": Ejercicio9(); break;
				case "10": Ejercicio10(); break;
				case "11": Ejercicio11(); break;
				default: Console.WriteLine("Opción incorrecta"); break;
			}
		}while (op != "0");
	}
	public static void Ejercicio1(){
		/*(5.9.1) Crea una función que calcule el valor de elevar un número entero a otro
		número entero (por ejemplo, 5 elevado a 3 = 53 = 5 ·5 ·5 = 125). Esta función se
		debe crear de forma recursiva. Piensa cuál será el caso base (qué potencia se
		puede calcular de forma trivial) y cómo pasar del caso "n-1" al caso "n" (por
		ejemplo, si sabes el valor de 54, cómo hallarías el de 55 a partir de él).*/
		
		Console.WriteLine("introduce el numero base");
		int num = Convert.ToInt32(
			Console.ReadLine());
		Console.WriteLine("introduce al que lo quieres elevar");
		int num1 = Convert.ToInt32(
			Console.ReadLine());
		
		Console.WriteLine(num + " elevado a " + num1 + " = " + ElevoNum(num, num1)); 
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();	
		
	}
	public static void Ejercicio2(){
		/*(5.9.2) Como alternativa, crea una función que calcule el valor de elevar un
		número entero a otro número entero de forma NO recursiva (lo que llamaremos
		"de forma iterativa"), usando la orden "for".*/
		
		Console.WriteLine("introduce el numero base");
		int num = Convert.ToInt32(
			Console.ReadLine());
		Console.WriteLine("introduce al que lo quieres elevar");
		int num1 = Convert.ToInt32(
			Console.ReadLine());
		
		Console.WriteLine(num + " elevado a " + num1 + " = " + ElevoNum2(num, num1)); 
		
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();	
	}
	public static void Ejercicio3(){
		/*(5.9.3) Crea un programa que emplee recursividad para calcular un número de la
		serie Fibonacci (en la que los dos primeros elementos valen 1, y para los restantes,
		cada elemento es la suma de los dos anteriores).*/
		
		/*Console.WriteLine("Introduce el número de la serie Fibonacci que deseas calcular:");
        int n = Convert.ToInt32(
			Console.ReadLine());

        int resultado = Fibonacci(n);
        Console.WriteLine("El número" +  n + " en la serie Fibonacci es: " + resultado);*/
		
		
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();	
	}
	public static void Ejercicio4(){
		/*(5.9.4) Crea un programa que emplee recursividad para calcular la suma de los
		elementos de un vector de números enteros, desde su posición inicial a la final,
		usando una función recursiva que tendrá la apariencia: SumaVector(v, desde,
		hasta). Nuevamente, piensa cuál será el caso base (cuántos elementos podrías
		sumar para que dicha suma sea trivial) y cómo pasar del caso "n-1" al caso "n" (por
		ejemplo, si conoces la suma de los 6 primeros elementos y el valor del séptimo
		elemento, cómo podrías emplear esta información para conocer la suma de los 7
		primeros).*/
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();	
	}
	public static void Ejercicio5(){
		/*(5.9.5) Crea un programa que emplee recursividad para calcular el mayor de los
		elementos de un vector. El planteamiento será muy similar al del ejercicio anterior.*/
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();	
	}
	public static void Ejercicio6(){
		/*(5.9.6) Crea un programa que emplee recursividad para dar la vuelta a una cadena
		de caracteres (por ejemplo, a partir de "Hola" devolvería "aloH"). La función
		recursiva se llamará "Invertir(cadena)". Como siempre, analiza cuál será el caso
		base (qué longitud debería tener una cadena para que sea trivial darle la vuelta) y
		cómo pasar del caso "n-1" al caso "n" (por ejemplo, si ya has invertido las 5
		primeras letras, que ocurriría con la letra de la sexta posición).*/
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();	
	}
	public static void Ejercicio7(){
		/*(5.9.7) Crea, tanto de forma recursiva como de forma iterativa, una función diga si
		una cadena de caracteres es simétrica (un palíndromo). Por ejemplo, "OSO",
		"RADAR" y "DABALEARROZALAZORRAELABAD" son palíndromos.*/
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();	
	}
	public static void Ejercicio8(){
		/*Crea un programa que encuentre el máximo común divisor de dos
		números usando el algoritmo de Euclides: Dados dos números enteros positivos m
		y n, tal que m > n, para encontrar su máximo común divisor, es decir, el mayor
		entero positivo que divide a ambos, se puede: 1) Dividir m por n para obtener el
		resto r (0 ≤ r < n) ; 2) Si r = 0, el MCD es n; 3) Si el resto no es cero, el máximo
		común divisor es MCD(n,r).*/
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();	
	}
	public static void Ejercicio9(){
		/*(5.9.9) Crea dos funciones que sirvan para saber si un cierto texto es subcadena de
		una cadena. No puedes usar "Contains" ni "IndexOf", sino que debes analizar letra
		a letra. Una función debe ser iterativa y la otra debe ser recursiva.*/
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();	
	}
	public static void Ejercicio10(){
		/*(5.9.10) Crea una función que reciba una cadena de texto, y una subcadena, y
		devuelva cuántas veces aparece la subcadena en la cadena, como subsecuencia
		formada a partir de sus letras en orden. Por ejemplo, si recibes la palabra "Hhoola"
		y la subcadena "hola", la respuesta sería 4, porque se podría tomar la primera H
		con la primera O (y con la L y con la A), la primera H con la segunda O, la segunda
		H con la primera O, o bien la segunda H con la segunda O. Si recibes "hobla", la
		respuesta sería 1. Si recibes "ohla", la respuesta sería 0, porque tras la H no hay
		ninguna O que permita completar la secuencia en orden.*/
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();	
	}
	public static void Ejercicio11(){
		/*(5.9.11) El algoritmo de ordenación conocido como "Quicksort", parte de la
		siguiente idea: para ordenar un array entre dos posiciones "i" y "j", se comienza
		por tomar un elemento del array, llamado "pivote" (por ejemplo, el punto medio);
		luego se recoloca el array de modo que todos los elementos menores que el
		pivote queden a su izquierda y los mayores a su derecha; finalmente, se llama de
		forma recursiva a Quicksort para cada una de las dos mitades. El caso base de la
		función recursiva es cuando se llega a un array de tamaño 0 ó 1. Implementa una
		función que ordene un array usando este método.*/
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();	
	}
	
	/*static void Main2(){
		int num;
			Console.WriteLine("Introduzca un número entero: ");
			num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Su factorial es: {0}", Factorial(num));
	}
	
	static long Factorial(int n){
			if (n==1) // Aseguramos que termine (caso base)
			return 1;
			return n * Factorial(n-1); // Si no es 1, sigue la recursión
		
	}*/
	public static long ElevoNum(int n1, int n2){
			
		if (n2 == 0)	
		return 1;	
		if (n2 == 1)	
		return n1;
		return n1 * ElevoNum(n1, n2-1);
	}
	public static long ElevoNum2(int n1, int n2){
		if (n2 == 0)	
		return 1;	
		if (n2 == 1)	
		return n1;
		int total;
		total = n1;
		for (int contador = n2 ; contador != 1
		 ; total = total * n1, contador--);
		return total;
			
	}
	public static long Fibonacci(int n){
		if (n == 1 || n == 2)
		return 1;
		int n1, n2 = 1, n3 = 2;
		n1 = n2 + n3;
		n2 = n3;
		n3 = n1; //solucion super mal optimizada, acabar
		
	}
}
