using System;
using System.Collections.Generic;

namespace Signaturas_y_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona();
            persona1.Hablar();
        }
    }
    class Persona
    {
        public Persona()
        {
            Console.WriteLine("Constructor Persona");
            telefonos = new List<string>();
        }
        public Persona(string nombre, decimal salariMensual) : this()
        {
            Nombre = nombre;
            SalarioMensual = salariMensual;
        }
        public string Nombre { get; set; }
        public List<string> telefonos { get; set; }
        public decimal SalarioMensual {get; set;}
        public decimal SalarioAnual
        {
            get
            {
                return SalarioMensual * 12;
            }
        }
        public void Hablar()
        {

        }
        public void Hablar(string mensaje)
        {

        }
        public void Hablar(int numero)
        {

        }
        public void Hablar(string mensaje, int numero)
        {

        }
    }
}
