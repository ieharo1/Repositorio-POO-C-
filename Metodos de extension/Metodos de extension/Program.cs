using System;

public static class Utilidadesdefecha
{
    public static int CalcularEdad(this DateTime fechanacimiento)
    {
        var edad = DateTime.Today.Year - fechanacimiento.Year;
        var temp = new DateTime(DateTime.Today.Year, fechanacimiento.Month, fechanacimiento.Day);
        if (temp > DateTime.Today)
        {
            edad--;
        }
        return edad;
    }
}
class Persona
{
    public DateTime Fechadenacimiento { get; set; }
    public int Edad
    {
        get
        {
            return Fechadenacimiento.CalcularEdad();
        }
    }
}
namespace Metodos_de_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona() { Fechadenacimiento= new DateTime (2001,6,24)};
            Console.WriteLine($"La edad de la persona es: {persona1.Edad}");
            
        }
    }
}
