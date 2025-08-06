using System;

namespace herencia
{
    public class Animales
    {
        public int Identidad { get; set; }
        public DateTime Fechadenacimiento { get; set; }
        public DateTime Fechaactual { get; set; }
    }
    public class Perro: Animales
    {
        public string Nombre { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Jake = new Perro() { Nombre = "Jake Starsky" };
            Jake.Identidad = 1722370101;
            Console.WriteLine(Jake.Nombre);
            Console.WriteLine(Jake.Identidad);
        }
    }
}
