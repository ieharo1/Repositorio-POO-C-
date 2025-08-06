using System;
using System.Collections.Generic;

namespace Constructor
{
    class Persona
    {
        public Persona()
        {
            Console.WriteLine("Constructor persona");
            telefonos = new List<string>();
        }
        public Persona(string nombre, decimal salarioMensual) : this()//this llama al constructor por defecto y lo ejecuta
        {
            Nombre = nombre;
            SalarioMensual = salarioMensual;
        }
        public string Nombre { get; set; }
        public decimal SalarioMensual { get; set; }
        public decimal SalarioAnual
        {
            get
            {
                return SalarioMensual * 12;
            }
        }
        public List<string> telefonos { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona();
            persona1.telefonos.Add("12345678");
            Console.WriteLine(persona1.telefonos[0]);

            var persona2 = new Persona("Felipe", 1000);
            persona2.telefonos.Add("4252252524");
            Console.WriteLine(persona2.telefonos[0]);
        }
    }
}
