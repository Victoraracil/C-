using System;
	/*Crea una clase "Coche", con atributos "marca" (texto), "modelo" (texto),
	"cilindrada" (número entero), potencia (número real). No hace falta que crees un
	Main de prueba.*/

	class Coche{
		string marca;
		string modelo;
		int cilindrada;
		float potencia;//Los metodos no se usan, solo se deja asi para usarlo en los proxios ejercicios.
		public void GetLibro(){
			Console.WriteLine(titulo);
			Console.WriteLine("Autor: " + autor);
			Console.WriteLine("Ubicacion: " + ubicacion);
			
		}
		public void SetLibro(string titulo, string autor, string ubicacion){
			this.titulo = titulo;
			this.autor = autor;
			this.ubicacion = ubicacion;			
		}
		public static void Main(){
			Libro l = new Libro();
			l.SetLibro("Los Juegos del Hambre", "Suzanne Collins", "EEUU");
			l.GetLibro();
		}
	
	}
