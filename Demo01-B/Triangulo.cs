using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_B
{
    public class Triangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public int CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }

    //INICIO DEL EJERCICIO PROPUESTO:
    public class Punto
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punto(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public class Triangulito
    {
        public Punto PuntoA { get; set; }
        public Punto PuntoB { get; set; }
        public Punto PuntoC { get; set; }

        public Triangulito(Punto puntoA, Punto puntoB, Punto puntoC)
        {
            PuntoA = puntoA;
            PuntoB = puntoB;
            PuntoC = puntoC;
        }

        public double CalcularDistancia(Punto p1, Punto p2)
        {
            double distancia = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            return distancia;
        }

        public double CalcularPerimetro()
        {
            double ladoAB = CalcularDistancia(PuntoA, PuntoB);
            double ladoBC = CalcularDistancia(PuntoB, PuntoC);
            double ladoCA = CalcularDistancia(PuntoC, PuntoA);

            double perimetro = ladoAB + ladoBC + ladoCA;
            return perimetro;
        }
    }

}
