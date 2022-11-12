//@Felipe Aguilera 15.771.527-5
using conBiblioteca.Clases;
using conBiblioteca.Colecciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conBiblioteca
{
    internal class Program
    {
        static Biblioteca b1 = new Biblioteca("Felipe", "Mayor", "Prestamo.txt");
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("1.- Mostrar contenido Biblioteca");
                Console.WriteLine("2.- Informacion de un prestamo");
                Console.WriteLine("3.- Cantidad de peliculas que llevan mas de");
                Console.WriteLine("0.- Salir");
                Console.WriteLine("Ingrese su opcion: ");
                int.TryParse(Console.ReadLine(), out op);
                switch (op)
                {
                    case 1:
                        MostrarBliblioteca();
                        break;
                    case 2:
                        InformacionPrestamo();
                        break; 
                    case 3:
                        CantidadPelisMasDias();
                        break;
                }
            } while (op != 0);
        }

        private static void MostrarBliblioteca()
        {
            Console.WriteLine(b1.ToString());
            Console.ReadKey();
        }
        private static void InformacionPrestamo()
        {
            string ops1;
            Console.WriteLine("Ingrese un numero: ");
            ops1 = Console.ReadLine();
            Console.WriteLine("Prestado a: " + b1.ObtenerPrestamo(ops1));
            Console.ReadKey();
        }
        private static void CantidadPelisMasDias()
        {
            int ops2;
            Console.WriteLine("Ingrese una cantidad de dias: ");
            int.TryParse(Console.ReadLine(), out ops2);
            Console.WriteLine("Peliculas con esa cantidad de dias: " + b1.TotalPrestamoMasDe(ops2));
            Console.ReadKey();  
        }





    }
}
