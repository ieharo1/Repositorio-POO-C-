using System;
using Libreria;
namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            var classprueba = new ClaseDePrueba();
            classprueba.Bulevard;//no sale porque es una propiedad interna
            var claseinterna = new ClaseInterna;//es inaccesible debido a su nivel de proteccion

        }
    }
}
