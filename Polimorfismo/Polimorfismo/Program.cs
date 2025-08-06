using System;

namespace Polimorfismo
{
    class Employee
    {
        private string Name;
        public Employee(string name)
        {
            Name = name;
        }
        public void Salary(int num_hours, ref int Salario)
        {
            Salario = num_hours * 7;
        }
        public virtual void Generar_Informe()
        {
            Console.WriteLine("Estoy generando informe ");
        }
    }
    class Director : Employee
    {
        public Director(string name) : base(name)
        {

        }
        new public void Generar_Informe()
        {
            Console.WriteLine("Genero indorme de areas de mantenimiento");
        }
    }
    class Secretary : Employee
    {
        public Secretary(string name) : base(name)
        {

        }
        public override void Generar_Informe()
        {
            Console.WriteLine("Genero informe de mi puesto de trabajo");
        }
    }
    class Boss : Employee
    {
        public Boss(string name) : base(name)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Salard= 0;
            Employee Direc = new Director("Daniel");
            Employee Sec = new Secretary("Alan");
            Employee Bos = new Boss("Isaac");
            Direc.Salary(20, ref Salard);
            Sec.Salary(10, ref Salard);
            Bos.Salary(15, ref Salard);

            Employee emp = new Employee("Jack");
            emp = Bos;
            Object Person = new Boss("Bob");

            Employee[] empleados = new Employee[3];
            empleados[0] = Direc;
            empleados[1] = Sec;
            empleados[2] = Bos;
            for (int i = 0;i< empleados.Length; i++)
            {
                empleados[i].Generar_Informe();//Polimorfismo
            }

            
        }
    }
}
