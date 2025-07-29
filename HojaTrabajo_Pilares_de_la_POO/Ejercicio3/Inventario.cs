using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HojaTrabajo_Pilares_de_la_POO.Ejercicio3
{
    public class Inventario
    {

        private List<Producto> productos = new List<Producto>();


        public void AgregarProducto (string nombre, int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("Agregue una cantidad positiva y mayor a 0");
                    return;
            }

            Producto existente = productos.Find(p => p.Nombre == nombre);

            if (existente != null)
            {
                existente.Cantidad += cantidad;
            }
            else
            {
                productos.Add(new Producto(nombre, cantidad));
            }
        }

        public void RetirarProducto(string nombre, int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe de ser positiva o mayor a 0");
                return;
            }

            Producto existente = productos.Find(p => p.Nombre == nombre);

            if (existente == null)
            {
                Console.WriteLine("Producto no existe.");
                return;
            }

            if(existente.Cantidad < cantidad)
            {
                Console.WriteLine("No hay suficiente cantidad para Retirar");
                return;
            }

            existente.Cantidad -= cantidad;

            if (cantidad == 0)
            {
                productos.Remove(existente);
            }
        }

        public void MostrarInventario()
        {
            Console.WriteLine("\nInventario actual:");
            for (int i = 0; i < productos.Count; i++)
            {
                Console.WriteLine($"{productos[i].Nombre}: {productos[i].Cantidad}");
            }
        }



    }
}
