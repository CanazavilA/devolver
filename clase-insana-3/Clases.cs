using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Security.Cryptography;
using libreriaClases;

namespace libreriaClases{
    class Persona{

        private string nombre;
        public string Nombre {get; set;}

        private string fechaNacimiento;
        public string FechaNacimiento {get; set;}
        private int dni;
        public int Dni {get; set;}

        private int edad;
        public int Edad {get; set;}
        
        private int curso;
        public int Curso {get; set;}




  
        public Persona(string rnombre, string rfechaNacimiento, int rdni, int redad){
            Nombre = rnombre;
            FechaNacimiento = rfechaNacimiento;
            Dni = rdni;
            Edad = redad;
        }
 
        public Persona(){

        }
    
        public int devolverEdad(){
            return Edad;
        }

       
        public string caminar(){
            return "caminando";
        }
         
            

        public void mostrarPersona(){
            Console.WriteLine("nombre: {0}", Nombre);
            Console.WriteLine("fechaNacimiento: {0}", FechaNacimiento);
            Console.WriteLine("dni: {0}", Dni);
        }
    }
}


    class Alumno : Persona{

        private int legajo;
        private string curso;
        private int[] notas;

        public void estudiar(){
            Console.WriteLine("Estudiando");
        }
         public int devolverCurso(){
            return Curso;
        }
}