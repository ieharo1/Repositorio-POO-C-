using System;
/*POO
1. Interfaces --> Declaracion de metodos sin completar marca compotamientos de la interfaz
2. Herencia --> ventaja --> Reutilizar codigo 
Existe jerarquia en la herencia 
Miralo como una piramide
"es-un" principio de herencia --> Un jefe es un empleado?
si la respuesta es "si" Jefe debe heredar de empleado
     empleado 
 Jefe      Director 

class Director// Pero un director si puede ser un empleado y jefe
class Jefe // Tambien puede ser un empleado
class Empleado//Empleado es muchas cosas menos direcctor

Se deben programar en la cuspide

Caracteristicas comunes
Nombre, Edad , Fecha de nacimiento,Salario

 
Comportamientos comunes
Trabajar
Genera informes

Extra --> si tenemos por ejemplo
Caballo  Humano  Gorilla
Como se pude ver no exite una cupide por ejmplo:
"es-un" Un humano es un caballo? no
Consejo crear una parte que contenga a los tres
Mamiferos --> El humano es un mamifero ? si

PRACTICA PARA MEJORAR Y SABER CUANDO ES NECESARIO UTILIZAR.*/
namespace Herencia_Interfaces
{
    class Mamiferos:Object // Implicitamente pasa esto --> Por eso tien un colo opaco --> Por eso en todas las clases sales las opcion conocidas como el Gettype
    {
        
        //1. Caracteristicas comunes --> Depende completamente de lo que se va a programar
        public void Respirar()
        { Console.BackgroundColor = ConsoleColor.Green;Console.WriteLine("Pudeo respirar"); }
        public void Comer()
        { Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Puedo comer"); }
    }
    class Caballo : Mamiferos // Escribir dentro de la clase cabello los metodos de mamiferos
    {
        public void Galopar()
        { Console.BackgroundColor = ConsoleColor.Yellow; Console.WriteLine("Estoy galopando"); }
    }
    class Humano:Mamiferos
    {
        public void Pensar()
        { Console.BackgroundColor = ConsoleColor.DarkGray; Console.WriteLine("Estoy Pensando"); }
    }
    class Gorila:Mamiferos
    {
        public void Trepar()
        { var Metros = new Gorila(); Console.BackgroundColor = ConsoleColor.DarkCyan; Console.WriteLine("Estoy Trepando"); Metros.Respirar(); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var humano = new Humano();
            var gorila = new Gorila();
            var caballo = new Caballo();
           
            humano.Comer();
            humano.Pensar();

            gorila.Trepar();
            //Clase object es muy importante--> Super clase cosmica --> Como el this en los apuntadores
            /*        Object
             *       Mamiferos
             * Caballo  Humano  Gorila*/      
            Console.ReadKey();
        }
    }
}
