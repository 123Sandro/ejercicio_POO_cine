using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_POO_cine
{
   public class Documental : LargoMetraje
    {
        public string Tema { get; set; }
        public string Genero { get; set; }
       //Constructores
        public Documental() 
        {
            Tema = "";
            Genero = "";

        }
        public Documental(string nombre, double duracion, string director, decimal costo, string tema, string genero) : base(nombre, duracion, director, costo)
        {
            Nombre = nombre;
            Duracion = duracion;
            Director = director;
            Costo = costo;
            Tema = tema;
            Genero = genero;
        }
    }
}
