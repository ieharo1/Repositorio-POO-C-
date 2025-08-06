using System;
using Modificadores_de_acceso_Protected;
namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            var probando = new ClaseDePrueba();
            //probando.News();//no se puede acceder por que es protected
        }
        public class clasederivada : ClaseDePrueba
        {
            public void Probando()
            {
                News = "hola";
            }
        }
    }
}
