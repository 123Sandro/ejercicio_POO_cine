using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_POO_cine
{
    public class LargoMetraje
    {
        //Propiedades autoimplementadas
        public string Nombre { get; set; }
        public double Duracion  { get; set; }
        public string Director { get; set; }
        public decimal Costo { get; set; }

        //Constructores
        public LargoMetraje() 
        {
            Nombre = "";
            Duracion = 0.0;
            Director = "";
            Costo = 0.0m;
        }
        public LargoMetraje(string nombre, double duracion, string director, decimal costo) {
            Nombre = nombre;
            Duracion = duracion;
            Director = director;
            Costo = costo;
        }
        public void mostrarSinopsis(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }

}
