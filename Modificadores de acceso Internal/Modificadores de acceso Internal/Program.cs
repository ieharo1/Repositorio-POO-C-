using System;

namespace Libreria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class ClaseDePrueba2
    {
        public void Prueba()
        {
            var clasepublica = new ClaseDePrueba();
            clasepublica.Bulevard = "Dirty Laundry";
            var claseinterna = new ClaseInterna;

        }
    }
    public class ClaseDePrueba
    {
        public int PropiedadPublica { get; set; }
        internal string Bulevard { get; set; }
        public void MetodoPublico()
        {
            Bulevard = "I WALK ALONE";
            PropiedadPublica = 10;
            MetodoPrivado();
        }
        public void MetodoPrivado()
        {

        }
    }
    internal class ClaseInterna
    {

    }
}
