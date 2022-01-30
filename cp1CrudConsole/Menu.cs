using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp1CrudConsole
{
    public class Menu : Crud
    {
        string opcion_menu = "";
        public void iniciar()
        {
            do
            {
                cabezera();
            }while (opcion_menu != "0");
        }


        /// <summary>
        /// Molde para que siempre vaya en la parte superior
        /// </summary>
        public void cabezera()
        {
            Console.Write("---------- CONTROL DE PELICULAS ----------");
            Console.Write("\n");
            Console.Write("----------Menu Princial----------");
            Console.Write("\n");
            Console.Write(" 1 [ Crear Pelicula ]       |  3 [ Eliminar Pelicula ] ");
            Console.Write("\n");
            Console.Write(" 2 [ Ver Peliculas ]  |  4 [ Modificar Pelicula ] ");
            Console.Write("\n");
            Console.Write(" 0 [ Salir ]  |             |  5 [ Buscar Pelicula ] ");
            Console.Write("\n");
            Console.Write("Selecciona una opcion");
            Console.Write("\n");
            Console.Write("\n");
            opcion_menu = Console.ReadLine();
            selectionMenu(opcion_menu);
            
        }

        /// <summary>
        /// Segun sea el caso nos lleva a ejecutar una accion
        /// </summary>
        /// <param name="opcion"></param>
        private void selectionMenu(string opcion)
        {
            if (opcion == "")
            {
                return;
            }
            else
            {
               
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        crearPelicula();
                        retornarMenu();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        lista();
                        retornarMenu();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        eliminar();
                        retornarMenu();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        modificar();
                        retornarMenu();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        buscar();
                        retornarMenu();
                        Console.ReadKey();
                        break;
                    case "r":
                        Console.Clear();
                        cabezera();
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("Opcion invalida");
                        break;
                }
            }


        }

        public void retornarMenu()
        {
            string op;
            Console.WriteLine("presione r para retornar al menu principal");
            op = Console.ReadLine().ToLower();
            selectionMenu(op);

        }

    }
}
