using System;
	/*Crea una clase llamada Persona, en el fichero "persona.cs". Esta clase
	deberá tener un atributo "nombre", de tipo string. También deberá tener un
	método "SetNombre", de tipo void y con un parámetro string, que permita
	cambiar el valor del nombre. Finalmente, también tendrá un método "Saludar",
	que escribirá en pantalla "Hola, soy " seguido de su nombre. Crea también una
	clase llamada PruebaPersona. Esta clase deberá contener sólo la función Main,
	que creará dos objetos de tipo Persona, les asignará un nombre a cada uno y les
	pedirá que saluden.*/

	class Persona{
		string nombre;
		public void SetNombre(string nombre){
			this.nombre = nombre;
		}
		public void Saludar(){
			Console.WriteLine("Hola, soy " + nombre);
		
		}
	}
	class PruebaPersona{
		static void Main(){
			Persona p = new Persona();
			p.SetNombre("pepe");
			Persona p2 = new Persona();
			p2.SetNombre("juan");
			p.Saludar();
			p2.Saludar();
		}
	}
