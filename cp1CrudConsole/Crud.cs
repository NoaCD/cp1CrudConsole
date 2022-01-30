using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp1CrudConsole
{
    public class Crud
    {
        List<Pelicula> dataset = new List<Pelicula>();
       public string titulo, pais;
       public int anio;

        public void crearPelicula()
        {
            Console.WriteLine("Ingrese titulo de la pelucula");
            string titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el pais de la pelicula");
            string pais = Console.ReadLine();
            Console.WriteLine("Ingrese año de la pelicula (aaaa)");
            int anio = int.Parse(Console.ReadLine());
            dataset.Add(new Pelicula(titulo, pais, anio));
            Console.WriteLine("\n");
            Console.WriteLine("Datos Guardados");

        }

        /// <summary>
        /// Nos devuelve Falso o verdadero si esta vacio la lista o no
        /// </summary>
        /// <returns> bool</returns>
        private bool listaVacia()
        {
            if (dataset.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Retorna la coleccion completa
        /// </summary>
        public void lista()
        {
            if (listaVacia() == true)
            {
                Console.WriteLine("No hay datos en la lista");
            }
            else
            {

                Console.WriteLine(" Total de PELICULAS " + dataset.Count);
                Console.WriteLine("---- Registro -----");
                foreach (Pelicula item in dataset)
                {
                    imprimir(item);
                }
            }
            Console.WriteLine(" \n ");

        }
        private void imprimir(Pelicula item)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine(" | Titulo :  {0} | Pais Origen : {1} |  Año Lanzamiento {2} | ", item.tituloPelicula, item.paisPelicula, new DateTime(item.anio, 01, 01).Year.ToString());
            Console.WriteLine("  ");
        }

        public void eliminar()
        {
            string buscar;
            if (listaVacia() == true)
            {
                Console.WriteLine("No se encuentra ningun dato en la lista");
            }
            else
            {

                Console.WriteLine("Ingrese nombre de la pelicula");
                buscar = Console.ReadLine();
                foreach (var item in dataset)
                {
                    if (buscar == item.tituloPelicula)
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine(" | Titulo :  {0} |  , Pais Origen : {1} | , Año Lanzamiento {2} | ", item.tituloPelicula, item.paisPelicula, new DateTime(item.anio, 01, 01).Year.ToString());
                        dataset.Remove(item);
                        Console.WriteLine("Pelicula eliminada");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" No se encontro la pelicula {0} ", buscar);
                    }


                }
            }
        }

        /// <summary>
        /// Funcion para editar objeto
        /// </summary>
        public void modificar()
        {
            string buscar;
            if (listaVacia() == true)
            {
                Console.WriteLine("No se encuentra ningun dato");
            }
            else
            {
                Pelicula ap = new Pelicula();
                Console.WriteLine("Ingrese el nombre ");
                buscar = Console.ReadLine();
                foreach (Pelicula item in dataset)
                {
                    if(buscar == item.tituloPelicula)
                    {
                        Console.WriteLine(" | Titulo :  {0} |  , Pais Origen : {1} | , Año Lanzamiento {2} | ", item.tituloPelicula, item.paisPelicula, new DateTime(item.anio, 01, 01).Year.ToString());
                        Console.WriteLine("---------------------------\n\n");
                        Console.Write("Ingrese titulo pelicula ");
                         ap.tituloPelicula = Console.ReadLine();
                        item.tituloPelicula = ap.tituloPelicula;
                        Console.Write("Ingrese el pais de la pelicula ");
                        ap.paisPelicula = Console.ReadLine();
                        item.paisPelicula = ap.paisPelicula;
                        Console.Write("Ingrese el año de la pelicula ");
                        ap.anio = int.Parse(Console.ReadLine());
                        item.anio = ap.anio;
                        Console.Write("\n");
                        Console.Write("DATOS MODIFICADOS");






                    }
                }
            }

        }


        /// <summary>
        /// Si coincide con algun titulo nos devuelve el objeto completo
        /// </summary>
        public void buscar()
        {
            if( listaVacia() == true)
            {
                Console.WriteLine("No hay datos guardados");
            }
            else
            {
                string buscar;
                Console.WriteLine("Ingrese titulo de la pelicula a buscar ");
                buscar = Console.ReadLine();
                foreach( Pelicula item in dataset)
                {
                    if(buscar == item.tituloPelicula)
                    {
                        Console.WriteLine(" | Titulo :  {0} |  , Pais Origen : {1} | , Año Lanzamiento {2} | ", item.tituloPelicula, item.paisPelicula, new DateTime(item.anio, 01, 01).Year.ToString());
                    }
                    else
                    {
                        Console.WriteLine("No se encontro {0}", buscar);
                    }
                }
            }
        }

    }
}
