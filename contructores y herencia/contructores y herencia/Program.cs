using System;

namespace Constructores_y_herencia_class_abstract
{
    public abstract class Muebles
    {
        public Muebles()
        {
            Console.WriteLine("Primero");
        }
        public Muebles(string parametro)
        {
            Console.WriteLine($"{parametro} segundi");
        }
        public abstract void TipodeMueble();
    }
    public class Silla : Muebles
    {
        public Silla()
        {
            Console.WriteLine("constructor silla");
        }
        public Silla(string para):base(para)
        {
            Console.WriteLine("constructor silla con parametro ");
        }
        public override void TipodeMueble()
        {
            Console.WriteLine("Vendo sillas");
        }
    }
    public class Mesa : Muebles
    {
        public Mesa()
        {
            Console.WriteLine("Constructor mesa");
        }
        public override void TipodeMueble()
        {
            Console.WriteLine("Vendo mesas");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Muebles sillagamer = new Silla("felipe ");
        }
    }
}
