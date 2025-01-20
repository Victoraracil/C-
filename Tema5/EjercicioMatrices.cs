using System;
class EjercicioMatrices{
	public struct structMatrices {
		public int [,]m1;
		public int [,]m2;
		public int [,]mr;
	}

    public static void Main(){
		structMatrices matrices;
		matrices.m1 = new int [0,0];
		matrices.m2 = new int [0,0];
		matrices.mr = new int [0,0];
		
            string op;
		do {
			Console.Clear();
			Console.WriteLine("0 - Salir");
			Console.WriteLine("1 - Dimensionar Matriz");
			Console.WriteLine("2 - Rellenar matriz automáticamente");
			Console.WriteLine("3 - Mostrar matriz");
			Console.WriteLine("4 - Sumar matrices");
			Console.WriteLine("5 - Restar matrices");	
			Console.WriteLine("6 - Multiplicar matrices");
			Console.WriteLine("7 - Hacer la traspuesta");

			
			op = Console.ReadLine();
			
			switch (op) {
				case "0": break;
				case "1": 
					Console.WriteLine("Introduce el tamaño de la matriz");
					int tamanyo = Convert.ToInt32(Console.ReadLine());
					DimensionarMatrices(ref matrices, tamanyo); break;
				case "2":
					RellenarMatrices(ref matrices); break;
				case "3":
					MostrarMatriz(matrices, "+"); break;
				case "4":
					SumarMatrices(matrices);
					MostrarMatriz(matrices, "+"); break;
				case "5":
					RestarMatrices(matrices);
					MostrarMatriz(matrices, "-"); break;
				case "6":
					MultiplicarMatrices(matrices);
					MostrarMatriz(matrices, "X"); break;
				case "7":
					Traspuesta(matrices); break;
				default: Console.WriteLine("Opción incorrecta"); break;
			}
		}while (op != "0");


    }
    
	public static void DimensionarMatrices(ref structMatrices m, int dim){
		//Define las dimensiones de la matriz segun lo indicado por el usuario
		m.m1 = new int [dim,dim];
		m.m2 = new int [dim,dim];
		m.mr = new int [dim,dim];
	}
	
	public static void RellenarMatrices(ref structMatrices m){
		Random R = new Random();//Rellena automaticamente las matrices con numeros del 0 al 9 usando Random
		for (int i = 0; i < m.m1.GetLength(0); i++){
			for (int j = 0; j < m.m1.GetLength(1); j++){
				m.m1[i,j] = R.Next(0, 9);
				m.m2[i,j] = R.Next(0, 9);
			}
		}
	}
		
	public static void MostrarMatriz(structMatrices m, string operador){
		//Muestra de manera grafica las matrices
		for (int i = 0; i < m.m1.GetLength(0); i++){
			Console.Write("|  ");
			for (int j = 0; j < m.m1.GetLength(1); j++){	
				Console.Write(m.m1[i,j] + "   ");	
			}
			Console.WriteLine("|");
		}
		
		Console.WriteLine(operador);
		
		for (int i = 0; i < m.m2.GetLength(0); i++){
			Console.Write("|  ");
			for (int j = 0; j < m.m2.GetLength(1); j++){	
				Console.Write(m.m2[i,j] + "   ");	
			}
			Console.WriteLine("|");
		}
		
		Console.WriteLine("=");
		
		for (int i = 0; i < m.mr.GetLength(0); i++){
			Console.Write("|  ");
			for (int j = 0; j < m.mr.GetLength(1); j++){	
				Console.Write(m.mr[i,j] + "   ");	
			}
			Console.WriteLine("|");
		}
		Console.ReadKey();
		Console.WriteLine("Presiona ENTER para continuar...");
		Console.ReadLine();
	}
	
	public static void SumarMatrices(structMatrices m){
		for (int i = 0; i < m.mr.GetLength(0); i++){//Realiza la suma
			for (int j = 0; j < m.mr.GetLength(1); j++){
				m.mr[i,j] = m.m1[i,j] + m.m2[i,j];
			}
		}
	}
	
	public static void RestarMatrices(structMatrices m){
		for (int i = 0; i < m.mr.GetLength(0); i++){//Realiza la resta
			for (int j = 0; j < m.mr.GetLength(1); j++){
				m.mr[i,j] = m.m1[i,j] - m.m2[i,j];
			}
		}
	}
	
	public static void MultiplicarMatrices(structMatrices m){
		
		for (int i = 0; i < m.mr.GetLength(0); i++){//Reinicia la matriz resultado
			for (int j = 0; j < m.mr.GetLength(1); j++){
				m.mr[i,j] = 0;
			}
		}
		
		for (int i = 0; i < m.mr.GetLength(0); i++){//realiza la multiplicacion
			for (int j = 0; j < m.mr.GetLength(1); j++){
				for (int z = 0; z < m.mr.GetLength(1); z++){
					m.mr[i,j] += m.m1[i,z] * m.m2[z,j]; 
				}	
			}
		}
	}
	
	public static void Traspuesta(structMatrices m){
		
		for (int i = 0; i < m.mr.GetLength(0); i++){//Reinicia la matriz resultado
			for (int j = 0; j < m.mr.GetLength(1); j++){
				m.mr[i,j] = 0;
			}
		}
		
		for (int i = 0; i < m.m1.GetLength(0); ++i) {//Cambia filas por columnas, haciendo la traspuesta
			for (int j = 0; j < m.m1.GetLength(1); ++j) {
				m.mr[i, j] = m.m1[j, i];
			}
		}
		
		for (int i = 0; i < m.m1.GetLength(0); i++){
			Console.Write("|  ");
			for (int j = 0; j < m.m1.GetLength(1); j++){	
				Console.Write(m.m1[i,j] + "   ");	
			}
			Console.WriteLine("|");
		}
		
		Console.WriteLine("=");
		
		for (int i = 0; i < m.mr.GetLength(0); i++){
			Console.Write("|  ");
			for (int j = 0; j < m.mr.GetLength(1); j++){	
				Console.Write(m.mr[i,j] + "   ");	
			}
			Console.WriteLine("|");
		}
		Console.ReadKey();
		Console.WriteLine("Presiona ENTER para continuar...");
		Console.ReadLine();		
	}
}
