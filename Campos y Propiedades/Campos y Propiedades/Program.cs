using System;

namespace Campos_y_Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var persona1 = new Persona() { Nombre = " Felipe" };
            Console.WriteLine("Nombre antes del cambio" + persona1.Nombre);
            persona1.SalarioMensual = 1000;
            Console.WriteLine($"Salario mensual: {persona1.SalarioMensual}");
            Console.WriteLine($"Salario anual: {persona1.SalarioAnual}");
            CambiarNombre(persona1);
            Console.WriteLine("Nombre despues del cambio"+persona1.Nombre);

            //valor
            Console.WriteLine("Valor");
            var numero = 10;
            Aumentar(numero);
            Console.WriteLine(numero);
            //Referencia
            Console.WriteLine("Referencia");
            Aumentar(ref numero);
            Console.WriteLine(numero);

        }
        public static void CambiarNombre(Persona persona)
        {
            persona.Nombre = " Claudia";
        }
        public static void Aumentar(int numero)
        {
            numero++;
        }
        public static void Aumentar(ref int numero)
        {
            numero++;
        }
    }
    public class Persona
    {
        public string Nombre { get; set; } //get solo lectura y set cambia el dato
        public decimal SalarioMensual { get; set; }
        public decimal SalarioAnual
        {
            get
            {
                return SalarioMensual * 12;
            }
        }
    }
}
