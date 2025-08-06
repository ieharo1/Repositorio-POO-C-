using System;

namespace Clase_Abstracta
{
    public abstract class PADRE
    {
        public abstract void Educarhijos();
    }
    public class WOOKIEE : PADRE
    {
        public override void Educarhijos()
        {
            Console.WriteLine("Educo a Jake y Paris"); ;
        }
    }
    public class ESTEBAN : PADRE
    {
        public override void Educarhijos()
        {
            Console.WriteLine("Educo a Isaac y Nico");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PADRE Wookiee = new WOOKIEE();
            PADRE esteban = new ESTEBAN();
            esteban.Educarhijos();
            Wookiee.Educarhijos();
            Console.WriteLine();
            Comoeducar(esteban);
            Comoeducar(Wookiee);
        }
        static void Comoeducar(PADRE padre)
        {
            Console.WriteLine("Sigue los pasos y educa a tu hijo");
            padre.Educarhijos();
        }
    }
}
