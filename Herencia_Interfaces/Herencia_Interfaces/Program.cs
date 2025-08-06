using System;

namespace Herencia_Interfaces
{
    interface ICaracteristicas_Unicas
    {
        int Numero_Dibujos();
    }
    interface ITorneo_Interno_JEFES
    {
        string Campeon();
    }
    interface IRepetido
    {
        int Numero_Dibujos();
    }
    class Employee
    {
        private string Name;
        public Employee(string name)
        {
            Name = name;
        }
        public void Salary( int numhours,  int Salary)
        {
            Salary = numhours * 7;
            Console.WriteLine(Salary);
        }
        public virtual void Generar_Informe()
        {
            Console.WriteLine("Estoy generando un informe");
        }
    }
    class Director: Employee
    {
        public Director(string name): base(name)
        {
            
        }
        public string Campeon()
        {
            return "Campeon";
        }
        new public void Generar_Informe()
        {
            Console.WriteLine("Genero informe de area de mantenimiento");
        }
    }
    class Secretaria : Employee
    {
        public Secretaria(string name) : base(name) { }
        public override void Generar_Informe()
        {
            Console.WriteLine("Geneto informe de mi puesto de trabajo");
        }
    }
    class Jefe_Sec : Employee, ITorneo_Interno_JEFES
    {
        public Jefe_Sec(string name): base(name)
        {

        }
        public string Campeon()
        {
            return "CAMPEOOON";
        }
    }
    class Disenadores: Employee, ICaracteristicas_Unicas, IRepetido
    {
        public Disenadores(string name):base(name)
        {

        }
        public void Dib()
        {
            Console.WriteLine("Estoy dibujando");
        }
        int ICaracteristicas_Unicas.Numero_Dibujos()
        {
            int numero = 10;
            return numero;
        }
        int IRepetido.Numero_Dibujos()
        {
            return 90;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Salary = 0;
            Employee Direc = new Director("Daniel");
            Employee Sec = new Secretaria("Martin");
            Employee Jef = new Jefe_Sec("Jack");
            Direc.Salary(20,  Salary);
            Sec.Salary(10,  Salary);
            Jef.Salary(15, Salary);

            var dise = new Disenadores("Bob");
            IRepetido dibujos = dise;
            dise.Generar_Informe();
            dise.Dib();
            Console.WriteLine(dibujos.Numero_Dibujos());

        }
    }
}
