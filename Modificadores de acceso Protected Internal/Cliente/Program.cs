using System;
using Modificadores_de_acceso_Protected_Internal;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            var claseafuera = new ClaseDePrueba();
            //claseafuera.Combinacion = "B";//NO VALE POR EL TIPO DE MODIFICADOR DE ACCESO
        }
    }
    class Maspruebas : ClaseDePrueba
    {
        public void Probando()
        {
            Combinacion = "Massachusetts";
        }
    }
}
