using System;
// Principio de sustitucion 
// Sutituir un objeto de un tipo por uno diferente 
// Siempre teniedo en cuanta la gerarquia de la clase
// Al momento de dar una gerarquia a cada clase es de gran ayuda utilizar el pricipio de sustitucion
// Aplicar la frase "Es siempre un..."
// Caballo es siempre un humano? NO, no hay gerarquia de herencia si realizamos la pregunta al reves igual es no
// Un mamifero es siempre un caballo ? NO 
// Un caballlo simpre es un mamifero ? SI

// EJEMPLO para entender mejor
// Caballo animal = new Mamifero(); MAL 
// Mamifero animal = new Caballo(); BIEN por que la clase mamiferio es heredada por Caballo, Humano y Gorila

// Director General , Empleado , Secretaria , Jefe seccion
// GERARQUIA DE HERENCIA
// Cuspide Empleado por que un director general, secretaria y jefe de seccion es un empleado ? SI si la respuesta es la reves la respuesta es no
//            Empleado                      (Clase padre)
// Director   Secretaria   Jefe de seccion  (NO existe relacion entre estas clases) El diseno de gerarquia siempre va a varia depende lo que se va a programar


namespace Herencia_Sustitucion
{
    class Empleado
    {
        private string Nombre;
        // Constructr
        public Empleado(string nombre)
        { Nombre = nombre; }
        public void Salario(int num_Horas ,ref int Salario)// Pagar por horas trabajadas
                                                  // Utilizamos la referencia para que los cambios ralizados en metodo si tengan influencia en el main
        { Salario = num_Horas * 7; }
    }
    class Director : Empleado
    {
        public Director(string NombreDirec) : base(NombreDirec) { }
        
        public void Generar_Informe()
        { Console.WriteLine("Genero informe"); }
    }
    class Secretaria : Empleado
    {
        public Secretaria (string NombreSec) : base(NombreSec) { }
    }
    class Jefe_Sec : Empleado
    {
        public Jefe_Sec (string NombrJEF) : base(NombrJEF) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Salario =0;
            //Princio de sustitucion
            Empleado Direc = new Director("Daniel");
            //Director pepe = new Empleado("MArio");
            Empleado Sec = new Secretaria("Isaac");
            Empleado Jef = new Jefe_Sec("Jack");
            var juan = new Director("EL PEPE");
            Direc.Salario(20, ref Salario);
            Sec.Salario(10, ref Salario);
            Jef.Salario(15, ref Salario);
            //Si trato de accder al metodo Generar_Informe() no me va a dejar por que la intancia es de Empleado
            //Direc.Generar_Informe(); // Sole me deja accder a los metodos de la clase objet y a la Empleado
            juan.Generar_Informe();

            // Otra forma de utilizar el principo de sustitucion es:
            Empleado emp = new Empleado("Alan");
            emp = Jef;
            Object PErsona = new Jefe_Sec("Martin");
            //Console.ReadKey();


            // PARA QUE SIRVE??
            // Crear un arreglo donde deseamos guardar las clases de que tipo sera el arreglo ???

            Secretaria[] BD = new Secretaria[3]; // Solo puedo guardar Secretarios , no puedo guardar jefes es decir no se puede transformar
            //BD[0] = emp;
            object[] BD2 = new object[3];
            BD2[0] = Direc;
            BD2[1] = Sec;
            BD2[2] = emp;
            // Existe una mayor flexibilidad
        }
    }
}
