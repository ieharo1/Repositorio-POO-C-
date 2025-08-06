using System;
using System.Collections.Generic;
// La mayoria de la mamiferos cuidan crias
// Pero que pasa con las lagatijas ella no cuidan a sus crias
// Por ende no deberia heredar el metodo 
// Pero si respira
// La solucion es crear una clase abtracta que abarque le metod de no cuidar
// Clase abtracta
// Meto abtracto solo tiene la declaracion es decir no esta desarrollado
// MEtodos abtractos  e intrfaces igual estan obligados a desarrollarlo

namespace Clases_Abstractas
{
    interface IPoner_Huevos
    {
        int Numero_Huevos();
    }
    abstract class Animales
    {
        string NOmbre;
        public Animales(string pepe)
        { NOmbre = pepe; }
        public void Respirar()
        { Console.WriteLine("Estoy repirando"); }
        public abstract void comer(); // tres puntos
    }
    class Mamiferos:Animales
    {
        string Nombre;
        public Mamiferos(string nombre = null):base(nombre)
        { this.Nombre = nombre; }
        public  void Cuidar_Crias()
        { Console.WriteLine("Cuido crias"); }

        
        public override void comer()
        {
            Console.WriteLine("Estoy comiendo");
        }
    }
    class Humano : Mamiferos
    {    
        public Humano(string nombre) : base(nombre) { }
    }
    class Ballena : Mamiferos
    {
        public Ballena(string nombre) : base(nombre) { }
    }
    class Lagartija : Animales, IPoner_Huevos
    {
        public Lagartija(string nombre) : base(nombre) { }
        public int Numero_Huevos()
        { return 10; }

        public void No_CuidarCrias()
        { Console.WriteLine("No cuido mis crias"); }
        public override void comer()
        {
            Console.WriteLine("Estoy comiendo ANIMAL");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int ? pero= null;//Variables null-ificables
            // double? pero = null;
            List<int?>  lista = new List<int?>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);
            lista = null;
            lista[3] = null;
            
            
            var Huma = new Humano("Juan");
            var Ball = new Ballena("Ottis");
            Huma.Respirar();
            var lag = new Lagartija("PANCHO");
            lag.No_CuidarCrias();
            lag.Respirar();
            Huma.comer();
            Console.WriteLine(lag.Numero_Huevos());
            Huma.Cuidar_Crias();
            Ball.Cuidar_Crias();
            Console.ReadKey();
        }
    }
}
