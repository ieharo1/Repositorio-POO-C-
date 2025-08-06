using System;

namespace Modificadores_de_acceso_Protected
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class ClaseDePrueba
    {
        public int PropiedadPublica { get; set; }
        protected string News { get; set; }
        public void Dirty()
        {
            News = "a";
        }

    }
}
