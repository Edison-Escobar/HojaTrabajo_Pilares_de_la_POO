using HojaTrabajo_Pilares_de_la_POO.Ejercicio1;
using HojaTrabajo_Pilares_de_la_POO.Ejercicio2;
using HojaTrabajo_Pilares_de_la_POO.Ejercicio3;
using System;

namespace HojaTrabajo_Pilares_de_la_POO
{
    class Program
    {
        static void Main()
        {
            Inventario inventario = new Inventario();

            inventario.AgregarProducto("Manzanas", 10);
            inventario.AgregarProducto("Peras", 5);

            inventario.MostrarInventario();


            inventario.RetirarProducto("Manzanas", 3);
            inventario.MostrarInventario();

            inventario.RetirarProducto("Peras", 5);
            inventario.MostrarInventario();

            inventario.AgregarProducto("Peras", 5);
            inventario.AgregarProducto("Peras", 5);

            inventario.MostrarInventario();

            inventario.RetirarProducto("Peras", 11);
            inventario.MostrarInventario();
        }
    }
}