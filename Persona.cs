using System;

namespace Personas
{
    class Persona
    {
        public string nombre;
        public string apellido;

        //metodo constructor
        // se llama igual que la clase
        public Persona(string nombre, string apellido)
        {
          this.nombre = nombre;
          this.apellido = apellido;
        }


        public void presentarse()
        {
           // Console.WriteLine("hola, mi nombre es " +  this.nombre + "" + this.apellido);
           Console.WriteLine("hola, mi nombre es {this.nombre} {this.apellido}");
           
        }
    }

}