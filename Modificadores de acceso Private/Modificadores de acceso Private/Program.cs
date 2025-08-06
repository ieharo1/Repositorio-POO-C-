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
    class Comprobar
    {
        public void Hellso()
        {
            var k = new ClaseDePrueba();
            k.MetodoPrivado;//no se puede acceder fuera de la clase
        }
    }
    public class ClaseDePrueba
    {
        public int PropiedadPublica { get; set; }
        public void MetodoPublico()
        {
            PropiedadPublica = 10;
            MetodoPrivado();
        }
        private void MetodoPrivado()
        {

        }
    }
}
