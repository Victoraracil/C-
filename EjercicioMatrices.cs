using System;
class ExamenVictorAracil{
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
					MostrarMatriz(matrices); break;
				case "4":
					SumarMatrices(matrices); break;
				case "5":
					RestarMatrices(matrices); break;
				case "6":
					MultiplicarMatrices(matrices); break;
				default: Console.WriteLine("Opción incorrecta"); break;
			}
		}while (op != "0");


    }
	public static void DimensionarMatrices(ref structMatrices m, int dim){
	
		m.m1 = new int [dim,dim];
		m.m2 = new int [dim,dim];
		m.mr = new int [dim,dim];
	}
	public static void RellenarMatrices(ref structMatrices m){
		Random R = new Random();
		for (int i = 0; i < m.m1.GetLength(0); i++){
			for (int j = 0; j < m.m1.GetLength(1); j++){
				m.m1[i,j] = R.Next(0, 9);
				m.m2[i,j] = R.Next(0, 9);
			}
		}
	}	
	public static void MostrarMatriz(structMatrices m){
		for (int i = 0; i < m.m1.GetLength(0); i++){
			Console.Write("|");
			for (int j = 0; j < m.m1.GetLength(1); j++){	
				Console.Write(m.m1[i,j] + " ");	
			}
			Console.WriteLine("|");
		}
	Console.ReadKey();
	Console.WriteLine("Presiona ENTER para continuar...");
    Console.ReadLine();
	}
	public static void SumarMatrices(structMatrices m){
		for (int i = 0; i < m.mr.GetLength(0); i++){
			for (int j = 0; j < m.mr.GetLength(1); j++){
				m.mr[i,j] = m.m1[i,j] + m.m2[i,j];
			}
		}
		
		for (int i = 0; i < m.m1.GetLength(0); i++){
			Console.Write("|  ");
			for (int j = 0; j < m.m1.GetLength(1); j++){	
				Console.Write(m.m1[i,j] + "   ");	
			}
			Console.WriteLine("|");
		}
		
		Console.WriteLine("+");
		
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
	public static void RestarMatrices(structMatrices m){
		for (int i = 0; i < m.mr.GetLength(0); i++){
			for (int j = 0; j < m.mr.GetLength(1); j++){
				m.mr[i,j] = m.m1[i,j] - m.m2[i,j];
			}
		}
		
		for (int i = 0; i < m.m1.GetLength(0); i++){
			Console.Write("|  ");
			for (int j = 0; j < m.m1.GetLength(1); j++){	
				Console.Write(m.m1[i,j] + "   ");	
			}
			Console.WriteLine("|");
		}
		
		Console.WriteLine("+");
		
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
	public static void MultiplicarMatrices(structMatrices m){
		for (int i = 0; i < m.mr.GetLength(0); i++){
			for (int j = 0; j < m.mr.GetLength(1); j++){
				for (int z = 1; z < m.mr.GetLength(1); z++){
					m.mr[i,j] = (m.m1[i,j] * m.m2[i,z]) + (m.m1[i,z] * m.m2[z,j]);
				}	
			}
		}
		
		for (int i = 0; i < m.m1.GetLength(0); i++){
			Console.Write("|  ");
			for (int j = 0; j < m.m1.GetLength(1); j++){	
				Console.Write(m.m1[i,j] + "   ");	
			}
			Console.WriteLine("|");
		}
		
		Console.WriteLine("+");
		
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
}
