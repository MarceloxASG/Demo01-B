using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_B
{
    public class Persona
    {
        public Persona()
        {
            
        }
        public Persona(string nombres, string apellidos)
        {
            Nombres = nombres;
            Apellidos = apellidos;
        }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string NombresCompletos { get; set; }

        //Procedimiento
        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }

        //Función
        public string MayorEdad()
        {
            string mensaje = "Es menor de edad";
            if (Edad > 18)
                mensaje = "Es mayor de edad";

            return mensaje;
        }
    }
}
