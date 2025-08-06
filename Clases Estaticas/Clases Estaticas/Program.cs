using System;

namespace Clases_Estaticas
{
    public static class UtilidadesDeFechas
    {
        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            var edad = DateTime.Today.Year - fechaNacimiento.Year;
            var temp = new DateTime(DateTime.Today.Year, fechaNacimiento.Month, fechaNacimiento.Day);
            if (temp > DateTime.Today)
            {
                edad--;
            }
            return edad;
        }
    }
    class Person
    {
        public DateTime FechaNacimiento { get; set; }
        public int Edad
        {
            get
            {
                return UtilidadesDeFechas.CalcularEdad(FechaNacimiento);
            }
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            var persona = new Person() { FechaNacimiento = new DateTime(2001, 6, 24) };
        
            Console.WriteLine("La edad de la persona es: " + persona.Edad);
        }
    }
}
