using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_B
{
    internal class Program
    {
        static void Main2(string[] args)
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
            };


            Triangulo triangulo = new Triangulo();
            triangulo.Altura = 5;
            triangulo.Base = 4;


            Console.WriteLine(triangulo.CalcularArea());
            Console.WriteLine("Hola mundo");
            Console.Read();

            Estudiante estudiantes = new Estudiante
            {
                Nombres = "Dave",
                Apellidos = "Santivañez",
                Nota = 20
            };
        }

        //EJECUCION DEL EJERCICIO PROPUESTO
        static void Main()
        {
            Punto puntoA = new Punto(0, 0);
            Punto puntoB = new Punto(3, 4);
            Punto puntoC = new Punto(6, 0);

            Triangulito triangulito = new Triangulito(puntoA, puntoB, puntoC);

            double distanciaAB = triangulito.CalcularDistancia(puntoA, puntoB);
            double distanciaBC = triangulito.CalcularDistancia(puntoB, puntoC);
            double distanciaCA = triangulito.CalcularDistancia(puntoC, puntoA);

            Console.WriteLine($"Distancia AB: {distanciaAB}");
            Console.WriteLine($"Distancia BC: {distanciaBC}");
            Console.WriteLine($"Distancia CA: {distanciaCA}");

            double perimetro = triangulito.CalcularPerimetro();
            Console.WriteLine($"Perímetro del triángulo: {perimetro}");
        }
    }
}
