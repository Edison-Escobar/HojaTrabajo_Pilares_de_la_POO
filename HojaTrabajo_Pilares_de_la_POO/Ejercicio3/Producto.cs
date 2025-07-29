using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HojaTrabajo_Pilares_de_la_POO.Ejercicio3
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }


        public Producto(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }
    }
}
