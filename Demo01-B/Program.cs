using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombres = "Hugo Felipe";
            persona.Apellidos = "Torrico Marquez";

            persona.AsignarNombresCompletos();
            Console.WriteLine(persona.NombresCompletos);

            Persona persona1 = new Persona("Reyna","Torrico");
            Persona persona2 = new Persona
            {
                Nombres = "Derek",
                Apellidos = "Torrico",
                Edad = 5
            }


            Triangulo triangulo = new Triangulo();
            triangulo.Altura = 5;
            triangulo.Base = 4;


            Console.WriteLine(triangulo.CalcularArea());
            Console.WriteLine("Hola mundo");
            Console.Read();

        }
    }
}
