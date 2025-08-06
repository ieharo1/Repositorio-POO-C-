using System;
// Palabras reservadas new , virtual , override
namespace Polimorfismo
{
    class Empleado
    {
        private string Nombre;
        // Constructor
        public Empleado(string nombre)
        { Nombre = nombre; }
        public void Salario(int num_Horas, ref int Salario)
        { Salario = num_Horas * 7; }
        //SE DEBE UTILIZAR  "VIRTUAL" --> Modificacion
        // Que queremos decir con esto?
        // todas las subclases de Empleado deberian tener el metodo Generar_Informe() que modifiquen el comportamiento del mismo
        public virtual void Generar_Informe()//Todas las clases utilizan el mismo metodo pero el comportamiento del mismo cambia en cada clase
        { Console.WriteLine("Estoy Generando un informe"); }
    }
    class Director : Empleado
    {
        public Director(string NombreDirec) : base(NombreDirec) { }
        new public  void Generar_Informe() // con ocultar se refierre a que es un metodo diferente  
        { Console.WriteLine("Genero informe el area de Manteniento"); } // IMPORANTE --> Si deseamos utilizar un metodo o funcion
        // Que tiene el mismo nombre y recibe los mismos parametros -->  oculta el metodo de la clase padre --> Empleado
        // Si se desea eliminar la advertencia debemos anadir "new"
    }
    // Todos deben generar informes pero los informes van a ser diferentes dependiendo de cada area
    class Secretaria : Empleado
    {
        public Secretaria(string NombreSec) : base(NombreSec) { }
        public override void Generar_Informe() // Metodo independiente que oculta al metodo de la clase padre
        { Console.WriteLine("Genero informe de mi puesto de trabajo"); } 
        // Cuando se utliza virtual en un metodo "Base" en las subclases se debe usar override por que vamos a modificar el metodo.
    }
    class Jefe_Sec : Empleado
    {
        public Jefe_Sec(string NombrJEF) : base(NombrJEF) { }
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
            Console.ReadKey();


            

            Secretaria[] BD = new Secretaria[3]; 
            Empleado[] BD2 = new Empleado[3];

            BD2[0] = Direc;
            BD2[1] = Sec; 
            BD2[2] = Jef;
            for (int i = 0; i < BD2.Length; i++)
            {
                BD2[i].Generar_Informe(); // POLIMORFISMO
            }
            //Niveles de acceso
            // public , private , protected
            // public y private ya se conoce cual es su nivel de acceso
            // Protected:
            // Mezcla de public y private se puede decir
            // Es accedible desde la clase donde se la declaro y desde las clases heredadas
        }
    }
}
