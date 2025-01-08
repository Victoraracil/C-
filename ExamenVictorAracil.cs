using System;
class ExamenVictorAracil{
    public static void Main(){//Ejercicio 1
            string op;
		do {
			Console.Clear();
			Console.WriteLine("0 - Salir");
			Console.WriteLine("1 - Ejercicio 1");
			Console.WriteLine("2 - Ejercicio 2");
			Console.WriteLine("3 - Ejercicio 3");
			Console.WriteLine("4 - Ejercicio 4");			
			Console.WriteLine("5 - Ejercicio 5");
			
			op = Console.ReadLine();
			
			switch (op) {
				case "0": break;
				case "1": Ejercicio1(); break;
				case "2": Ejercicio2(); break;
				case "3": Ejercicio3(); break;
				/*case "4": Ejercicio4(); break;
				case "5": Ejercicio5(); break;*/
				default: Console.WriteLine("Opción incorrecta"); break;
			}
		}while (op != "0");

    }
    
    public static void Ejercicio1(){
		Console.WriteLine("Ejercicio suma de numeros introducidos por el usuario");
		int suma = 0;
		Console.WriteLine("Introduce cuantos numeros quieres sumar");
		int tamaño = Convert.ToInt32(
			Console.ReadLine());
		int[] numeros = new int[tamaño];		
		for (int i = 0; i <= tamaño-1; i++){ // Pedimos los datos
			//Control de errores aqui para que solo introduzca enteros
			Console.Write("Introduce el dato numero {0}: ", i+1);
			numeros[i] = Convert.ToInt32(Console.ReadLine());
		}	
		for (int i = 0; i <= 4; i++){
			suma += numeros[i];
		}
		Console.WriteLine(suma);
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();
	}	
	
	public static void Ejercicio2(){
		string frase;
		Console.WriteLine("Ejercicio Mayusculas iniciales");
		Console.WriteLine("Introduce una frase y yo la acomodadre");
		frase = Console.ReadLine();
		MayusculasIniciales(frase);

	}
	
	public static void Ejercicio3(){
		Console.WriteLine("Ejercicio juntar y ordenar arrays");
		Console.WriteLine("Itroduce el tamaño de los arrays");
		int tamaño= Convert.ToInt32(
			Console.ReadLine());
		int tamaño2 = tamaño + tamaño;
		JuntarYOrdenarArrays(tamaño, tamaño2);	
	}
	
	public static void MayusculasIniciales(string frase){
		string FraseMinus;
		//string FraseMayus, FraseMinus, FraseFinal;
		FraseMinus = frase.ToLower();//cambio de todas las letras a minuscula
		
		Console.WriteLine(FraseMinus);
		Console.WriteLine("Presiona ENTER para continuar...");
		Console.ReadLine();	
	}
	
	public static void JuntarYOrdenarArrays(int tamaño, int tamaño2){
		int repetido = 0, x = 0;
		var Random = new Random();
		int[] a1 = new int[tamaño];//creacion de los arrays
		int[] a2 = new int[tamaño];
		int[] ar = new int[tamaño2];
		
		for (int i = 0; i <= tamaño - 1; i++){ // Array 1
			a1[i] = Random.Next(0, 9);
		}	
		for (int i = 0; i <= tamaño - 1; i++){ // Array 2
			a2[i] = Random.Next(0, 9);
		}	

		while (x != tamaño){//calculo cuantos datos repetidos hay
			for (int i = 0; i != tamaño - 1 ;i++){
				if (a1[i] == a2[x]){
					repetido++;//Variable donde se almacenan los datos repetidos
				}
				
			}
			x++;
		}
		for (int i = 0; tamaño - 1 != i; i++){//intento de rellenar el array ar
			ar[i] = a1[i];
		}
		for (int i = 0; tamaño - 1 != i; i++){
			ar[i + 5] = a2[i];
		}
		int z = 0, j, datoTemporal;
		int n = tamaño2;
		for(j =z+1; j < n; j++){//intento de ordenacion
			if (ar[z] > ar[j]){
				datoTemporal = ar[z];
				ar[z] = ar[j];
				ar[j] = datoTemporal;
			}
		}
		
		foreach(int num in a1) {//arrays mostrados
			Console.WriteLine("Valor del array1: {0}", num);
		}
		foreach(int num in a2) {
			Console.WriteLine("Valor del arry2: {0}", num);
		}
		foreach(int num in ar) {
			Console.WriteLine("Valor del array: {0}", num);
		}
		Console.WriteLine("Presiona ENTER para continuar...");
        Console.ReadLine();
	}
	
}
