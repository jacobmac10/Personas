using System;

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear objeto Persona, a partir de la clase Persona
            // Un objeto es una instancia de su clase
            // (Una galleta es una instancia de su molde de galletitas)
            Persona persona = new Persona("Evelyn", "Rubio");

            persona.presentarse();
            Console.WriteLine(persona.nombre);
            Console.WriteLine(persona.apellido);
            // null no tiene valor, valor vacio
            Persona persona2 = new Persona("Skrillex", null);
            persona2.presentarse();
            Console.WriteLine(persona2.nombre);
            Console.WriteLine(persona2.apellido);

        }
    }

}





