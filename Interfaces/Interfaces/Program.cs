using System;

namespace Interfaces
{
    public interface IRepositorio_Personas
    {
        void ObtenerPersonas();
    }
    public class RepositorioPersonasBD : IRepositorio_Personas
    {
        public void ObtenerPersonas()
        {
            Console.WriteLine("OBTENIENDO PERSONAS DE LA BASE DE DATOS");
        }
    }
    public class RepositorioPersonasEnMemoria : IRepositorio_Personas
    {
        public void ObtenerPersonas()
        {
            Console.WriteLine("OBTENIENDO PERSONAS DE LA MEMORIA");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ProcesarRepositorio(new RepositorioPersonasBD());
            //ProcesarRepositorio(new RepositorioPersonasEnMemoria());
            var repositorio = ObtenerRepositorio(TipoRepositorio.Memoria);
            ProcesarRepositorio(repositorio);
        }
        public static void ProcesarRepositorio(IRepositorio_Personas repositorio)
        {
            repositorio.ObtenerPersonas();
        }
        enum TipoRepositorio { Memoria=1, BD=2}
        static IRepositorio_Personas ObtenerRepositorio (TipoRepositorio tipoRepositorio)
        {
            switch (tipoRepositorio)
            {
                case TipoRepositorio.Memoria:
                    return new RepositorioPersonasEnMemoria();
                case TipoRepositorio.BD:
                    return new RepositorioPersonasBD();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
