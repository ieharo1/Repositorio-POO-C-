using System;
using Herencia_Constructores; // Alan ya funciono.
//POO Contructores --> Superclases y subclases
//Intruccion base() --> Llamar al contructor de la super clase o clase padre en las subclases.
// Retomando el ejemplo de mamiferos 
//      Mamiferos --> superclase o clase padre   todas las clases tienen un contructor por defecto
// caballo  Humanos  Gorila --> subclases
// El contructor de la subclase siempre llama al contructor de la clase base
// :base()
namespace Herencia_Constructores
{
    class Mamiferos // Super clase
    {
        //Constructor
        private string Nombre; // --> Si no ponemos privete se pone por default
        public Mamiferos(string nombre) // Remplazamos contructor por dafault public Mamiferos(){}
        {
            Nombre = nombre;
        }
        public Mamiferos() { }
        //quitar el comentario de la linea de arriba y el programa vuelve a funcionar o completar los contructores de las subclases
        public void Respirar()
        { Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("Pudeo respirar"); }
        public void Comer()
        { Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Puedo comer"); }
        public void GetNombre()
        { Console.WriteLine("El nombre de su mamifero es {0}", Nombre); }
    }
    class Humano : Mamiferos // subclase 
        //Importante las sunclases no van a funcionar si no llamamos al contructor de la clase padre
    {
        public Humano(string NombreHumano) : base(NombreHumano) {} // Si deseamos podemos modificar el constructor
        public void Pensar()
        { Console.BackgroundColor = ConsoleColor.DarkGray; Console.WriteLine("Estoy Pensando"); }
    }
    class Caballo : Mamiferos //Subclase
    {
        public void Galopar()
        { Console.BackgroundColor = ConsoleColor.Yellow; Console.WriteLine("Estoy galopando"); }
    }
    class Gorila : Mamiferos //Subclase
    {
        public void Trepar()
        { var Metros = new Gorila(); Console.BackgroundColor = ConsoleColor.DarkCyan; Console.WriteLine("Estoy Trepando"); Metros.Respirar(); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var humano = new Humano("JUAN");
            var gorila = new Gorila();// estas intancias funcionan por el contructor de default
            var caballo = new Caballo();

            humano.Comer();
            humano.Pensar();
            humano.GetNombre();

            gorila.Trepar();
            Console.ReadKey();
        }
    }
}
