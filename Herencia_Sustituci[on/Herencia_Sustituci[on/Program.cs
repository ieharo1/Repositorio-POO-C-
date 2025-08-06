using System;

namespace Herencia_Sustituci_on
{
    class Employee
    {
        private string Name;
        public Employee(string name)
        {
            Name = name;
        }
        public void Salary(int num_hours, ref int Salary)
        {
            Console.WriteLine(Salary = num_hours * 7); 
        }
    }
    class Director : Employee
    {
        public Director(string Name) : base(Name)
        {

        }
        public void Generate_report()
        {
            Console.WriteLine("Genera reporte");
        }
    }
    class Secretary: Employee
    {
        public Secretary(string Name) : base(Name)
        {

        }
    }
    class Boss : Employee
    {
        public Boss(string Name) : base (Name)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Salary = 0;
            Employee Isaac = new Boss("Isaac");
            Employee Nico = new Director("Nico");
            Employee Daniel = new Secretary("Daniel");
            Isaac.Salary(20, ref Salary);
            Nico.Salary(20, ref Salary);
            Daniel.Salary(10, ref Salary);
            var Alan = new Director("Alan");
            Alan.Generate_report();

            Secretary[] Sec = new Secretary[3];

            object[] Emplo = new object[3];
            Emplo[0] = Isaac;
            Emplo[1] = Nico;
            Emplo[2] = Daniel;
        }
    }
}
