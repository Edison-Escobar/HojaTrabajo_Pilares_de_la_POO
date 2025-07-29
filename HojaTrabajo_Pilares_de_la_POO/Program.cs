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
            Biblioteca b = new Biblioteca();
            b.registrar("El Principito", "Saint-Exupéry");
            b.registrar("1984", "George Orwell");
            b.MostrarLibrosDisponibles();
            b.Prestar("El Principito", "Saint-Exupéry");
            b.MostrarLibrosDisponibles();
            b.Devolver("El Principito");
            b.MostrarLibrosDisponibles();
            b.registrar("Cien años de soledad", "Gabriel García Márquez,");
            b.registrar("Orgullo y prejuicio", "Jane Auste");
            b.registrar("Don Quijote de la Mancha", "Miguel de Cervantes");
            b.MostrarLibrosDisponibles();
            b.Prestar("Don Quijote de la Mancha", "Miguel de Cervantes");
            b.MostrarLibrosDisponibles();


            Console.ReadLine();
        }
    }

    class Program1
    {
        static void Main()
        {
            Usuario u = new Usuario("Carlos");

            u.AsignarDpi("1234567890123");
            u.IngrsarContrasenia("clave123");
            u.MostrarNombre();

            Console.WriteLine("Autenticando con clave 'clave123': " + u.Autenticar("clave123"));
            Console.WriteLine("Autenticando con clave 'otra': " + u.Autenticar("otraa"));

            Console.ReadLine();
        }
    }

    class Program3
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

            inventario.RetirarProducto("Peras", 5);
            inventario.MostrarInventario();
        }
    }
}
