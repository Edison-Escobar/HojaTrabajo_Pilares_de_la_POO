using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HojaTrabajo_Pilares_de_la_POO.Ejercicio1
{
    public class Biblioteca
    {
        List<Libro> Libros = new List<Libro>();
        private int ides = 1;

        public bool registrar(string titulo, string autor)
        {
            if(Libros.Any(Libro => Libro.Titulo.ToUpper() == titulo.ToUpper()))
            {
                return false;
            }
            Libros.Add(new Libro(ides++, titulo, autor));
            return true;

        }

        public bool Prestar(string titulo, string usuario)
        {
            foreach(var Libro in Libros)
            {
                if(Libro.Disponible)
                {
                    return Libro.Prestar(usuario);
                }
            }

            return false;
        }

        public bool Devolver(string titulo)
        {
            foreach (var Libro in Libros)
            {
                if(Libro.Titulo.ToUpper() == titulo.ToUpper() && !Libro.Disponible)
                {
                    Libro.Devolver();
                    return true;
                }
            }

            return false;
        }


        public void MostrarLibrosDisponibles()
        {
            List<Libro> disponibles = new List<Libro>();

            foreach (var Libro in Libros)
            {
                if (Libro.Disponible)
                {
                    disponibles.Add(Libro);
                }
            }

            Console.WriteLine(" libros Disponibles");
            if(disponibles.Count == 0)
            {
                Console.WriteLine(" No hay libros Disponibles");
            }
            else
            {
                foreach(var Libro in disponibles)
                {
                    Console.WriteLine(" " + Libro.ToString());
                }
            }
        }

    }
}
