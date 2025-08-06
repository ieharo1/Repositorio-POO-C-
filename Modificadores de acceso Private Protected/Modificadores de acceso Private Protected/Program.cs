using System;

namespace Modificadores_de_acceso_Private_Protected
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class ClaseDePrueba
    {
        private protected string PRIVATEPROTECTED;
        public void Guitarra()
        {
            PRIVATEPROTECTED = "Electrica";
        }
    }
    public class ClaseDePrueba2
    {
        public void Prueba()
        {
            var PruebaPrivateProtected = new ClaseDePrueba();
            //PruebaPrivateProtected.PRIVATEPROTECTED; // NO EN OTRAS CLASES
        }
    }
    public class ClaseDePrueba3 : ClaseDePrueba
    {
        public void Perro()
        {
            PRIVATEPROTECTED = "Labrador";
        }
    }
}
