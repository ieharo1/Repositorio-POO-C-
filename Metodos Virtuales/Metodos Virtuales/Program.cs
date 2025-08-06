using System;

namespace Metodos_Virtuales
{
    public abstract class Musica
    {
        public abstract void QHACE();
        public virtual void tocar()
        {
            Console.WriteLine("tocar la guitarra");
        }
    }
    public class Rock : Musica
    {
        public override void tocar()
        {
            Console.WriteLine("Toco la guitarra electrica");
        }
        public override void QHACE()
        {
            Console.WriteLine("toco rock");
        }
    }
    public class Jazz : Musica
    {
        public override void tocar()
        {
            Console.WriteLine("Toco el saxo");
        }
        public override void QHACE()
        {
            Console.WriteLine("toco jazz");
        }
    }
    public class Pop : Musica
    {
        public override void QHACE()
        {
            Console.WriteLine("toco popsito");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Musica Coldplay = new Pop();
            Musica Metallica = new Rock();
            Musica O = new Jazz();
            TOCARLATOCADA(Metallica);
            TOCARLATOCADA(Coldplay);
            TOCARLATOCADA(O);
        }
        static void TOCARLATOCADA(Musica MUSICAXD)
        {
            MUSICAXD.QHACE();
            MUSICAXD.tocar();
        }
    }
}
