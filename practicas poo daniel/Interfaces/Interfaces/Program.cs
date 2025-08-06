using System;
// INTERFACES
// son conjunto de directrices que  deben cumplir las clases
// Ejmeplo
// Clase 1
// Las clases pueden implementar es decir heredar una interfaz
// ES algo parecido a una clase
// Pero solo exiten las definiciones de los metodos es decir los comportamientos
// Declaracion de un metodo sin completar
// Marca el diseno y compartamiento que hereden las interfaces
// ES posible que el codigo sea modificado por otros como por ejemplo
// Anadir al programa Compradores por ejemplo.
namespace Interfaces
{
    interface ICaracteristicas_Unicas// No tiene constructores
    {
        int Numero_Dibujos();//Nunca hay codigo en esta declaracion
        // No debe llevar modificador de acceso
        // public por default
    }
    interface ITorneo_Interno_JEFES
    {
        string Campeon();
    }
    interface IRepetido
    {
        int Numero_Dibujos();
    }
    class Empleado
    {
        private string Nombre;
        public Empleado(string nombre)
        { Nombre = nombre; }
        public void Salario(int num_Horas, ref int Salario)
        { Salario = num_Horas * 7; }
        public virtual void Generar_Informe()
        { Console.WriteLine("Estoy Generando un informe"); }
        // CUANDO ES FACTIBLE UTILIZAR UNA INTERFAS
        // POR EJEMPLO
        // En este programa tenemos a diferentes empleados
        // TODOS pueden y deben hacer informes pero solo el disenador dibujos
        // Pero como todos tienen la posibilidad de heredar esta funcion
        // Aqui es donde entran las intefaces
        // public int Dibujar() { int dibujos = 0; return dibujos;  }
    }
    class Director : Empleado, ITorneo_Interno_JEFES
    {
        public Director(string NombreDirec) : base(NombreDirec) { }

        public string Campeon()
        {
            return "Campeon";
        }

        new public void Generar_Informe() 
        { Console.WriteLine("Genero informe el area de Manteniento"); } 
        
    }
    class Secretaria : Empleado
    {
        public Secretaria(string NombreSec) : base(NombreSec) { }
        public override void Generar_Informe() 
        { Console.WriteLine("Genero informe de mi puesto de trabajo"); }
        
    }
    class Jefe_Sec : Empleado,ITorneo_Interno_JEFES
    {
        public Jefe_Sec(string NombrJEF) : base(NombrJEF) { }

        public string Campeon()
        {
            return "CAMPEOOOON";
        }
    }
    //Cuando una clase ya hereda se anade una coma ","
    // No da lo mismo el orden de la interfaz
    class Disenadores : Empleado , ICaracteristicas_Unicas, IRepetido
    {
        public Disenadores(string Nombre) : base(Nombre) { } 
        public void Dib() { Console.WriteLine("Estoy dibujando"); }

        int  ICaracteristicas_Unicas.Numero_Dibujos()
        {int numero =10; return numero;  }
        int IRepetido.Numero_Dibujos() { return 90; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Salario = 0;

            Empleado Direc = new Director("Daniel");
            Empleado Sec = new Secretaria("Isaac");
            Empleado Jef = new Jefe_Sec("Jack");
            Direc.Salario(20, ref Salario);
            Sec.Salario(10, ref Salario);
            Jef.Salario(15, ref Salario);

            Empleado emp = new Empleado("Alan");
            emp = Jef;
            Object PErsona = new Jefe_Sec("Martin");
            //Console.ReadKey();




            Secretaria[] BD = new Secretaria[3];
            Empleado[] BD2 = new Empleado[3];

            BD2[0] = Direc;
            BD2[1] = Sec;
            BD2[2] = Jef;
            for (int i = 0; i < BD2.Length; i++)
            {
                BD2[i].Generar_Informe(); // POLIMORFISMO
            }

            
            var dise = new Disenadores("MARIO");
            IRepetido dibujos = dise;
            dise.Generar_Informe();
            dise.Dib();
            Console.WriteLine(dibujos.Numero_Dibujos());
            Console.ReadKey();
            
        }
    }
}
