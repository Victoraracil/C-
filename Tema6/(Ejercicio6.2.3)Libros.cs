using System;
	/*Para guardar información sobre libros, vamos a comenzar por crear una
	clase "Libro", que contendrá atributos "autor", "titulo", "ubicacion" (todos ellos
	strings) y métodos Get y Set adecuados para leer su valor y cambiarlo. Prepara
	también un Main (en la misma clase), que cree un objeto de la clase Libro, dé
	valores a sus tres atributos y luego los muestre.*/

	class Libro{
		string autor;
		string titulo;
		string ubicacion;
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
