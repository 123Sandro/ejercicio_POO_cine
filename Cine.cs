using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_POO_cine
{
    public class Cine
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Funcion { get; set; }
        public String Direccion { get; set; }

        //Constructores
        public Cine() {
            Nombre = "";
            Funcion = "";

        }
        public Cine(string nombre, string funcion) 
        {
            Nombre = nombre;
            Funcion = funcion;
        }
        //Metodo que esta asociado al largometraje
        public void reproducir(LargoMetraje largo, string horario)
        {
            Console.WriteLine("La funcion inicia a las "+ horario);
            Console.WriteLine("Se esta reproducuinedo " + largo.Nombre);
            Console.WriteLine("Dirigida por " + largo.Director);
        }
        //Metodod con referencia a largometraje
        public void mostraCartelera(LargoMetraje largo1, LargoMetraje largo2)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("Nombre: "+largo1.Nombre);
            Console.WriteLine("Director: " + largo1.Director);
            Console.WriteLine("Duracion: " + largo1.Duracion);
            Console.WriteLine("-------------");

            Console.WriteLine("Nombre: " + largo2.Nombre);
            Console.WriteLine("Director: " + largo2.Director);
            Console.WriteLine("Duracion: " + largo2.Duracion);
        }
    }
}
