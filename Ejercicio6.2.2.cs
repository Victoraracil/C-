using System;
	/*Tras leer la descripción de Space Invaders que vimos en el apartado
	anterior, crea una clase Juego, que sólo contenga un método Lanzar, void, sin
	parámetros, que escriba en pantalla "Bienvenido a Console Invaders. Pulse Intro
	para salir" y se detendrá hasta que el usuario pulse Intro. Prepara también un
	Main (en la misma clase), que cree un objeto de la clase Juego y lo lance.*/

	class Juego{
		public void Lanzar(){
			Console.WriteLine("Bienvenido a Console Invaders. Pulse ENTER para salir");
			Console.ReadLine();
		}
		public void Main(){
			Juego j = new Juego();
			j.Lanzar();
		}
	
	}