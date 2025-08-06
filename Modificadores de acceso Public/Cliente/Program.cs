using Libreria;
using System;


namespace Cliente
{
   class Program
   {
        static void Main(string[] args)
        {
            var Clasepublica = new ClasePublicaDePrueba();
            Clasepublica.PropiedadPublica = 10;
            Console.WriteLine(Clasepublica.PropiedadPublica);
        }
    }
}

