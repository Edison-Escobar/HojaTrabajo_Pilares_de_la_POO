using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HojaTrabajo_Pilares_de_la_POO.Ejercicio1
{
    public class Libro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public bool Disponible { get; private set; }
        private int Id;
        private string usuarioPrestamo;

        public Libro(int id, string titulo, string autor)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Disponible = true;
        }

        public bool Prestar(string usuario)
        {
            if (!Disponible)
            {
                return false;
            }
                Disponible = false;
                usuarioPrestamo = usuario;
                return true;
        }

        public void Devolver()
        {
            Disponible = true;
            usuarioPrestamo = null;
        }

        public override string ToString()
        {
            return $"{Id}: { Titulo} - { Autor} (Disponible: { Disponible})";
        }
    }
}
