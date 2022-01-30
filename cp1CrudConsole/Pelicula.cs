using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp1CrudConsole
{

    /// <summary>
    /// Clase PELICULA PARA CLONAR SUS PROPIEDADES
    /// </summary>
    public class Pelicula
    {
        public string tituloPelicula { set; get; }
        public string paisPelicula { set; get; }
        public int anio { set; get; } 

        public Pelicula()
        {

        }

        public Pelicula( string tituloPelicula, string paisPelicula, int anio)
        {
            this.tituloPelicula = tituloPelicula;
            this.paisPelicula = paisPelicula;
            this.anio = anio;

        }




    }



}
