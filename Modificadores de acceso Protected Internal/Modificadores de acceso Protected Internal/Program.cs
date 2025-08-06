using System;

namespace Modificadores_de_acceso_Protected_Internal
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
            var clasecombinada = new ClaseDePrueba();
            clasecombinada.Combinacion = "B";
        }
    }
    public class ClaseDePrueba
    {
        protected internal string Combinacion { get; set; }
    }
}
