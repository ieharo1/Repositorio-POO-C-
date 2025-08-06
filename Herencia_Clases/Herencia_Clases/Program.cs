using System;

namespace Herencia_Clases
{
    class Mamiferos
    {
        public void Alimentarse()
        {
            Console.WriteLine("Estoy comiendo");
        }
        public void Correr()
        {
            Console.WriteLine("Puedo correr");
        }
    }
    class Humano:Mamiferos
    {
       public void Pensar()
        {
            Console.WriteLine("Estoy pensando");
        }
    }
    class Gato:Mamiferos
    {
        public void Maullar()
        {
            Console.WriteLine("Estoy maullando");
        }
       
    }
    class Perro:Mamiferos
    {
        public void Ladrar()
        {
            Console.WriteLine("Estoy ladrando");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Isaac = new Humano();
            var Jake = new Perro();
            var Simba = new Gato();
            Isaac.Alimentarse();
            Jake.Correr();
            Simba.Maullar();
        }
    }
}
