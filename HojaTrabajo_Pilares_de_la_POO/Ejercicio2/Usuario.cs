using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HojaTrabajo_Pilares_de_la_POO.Ejercicio2
{
    public class Usuario
    {
        private string Nombre;
        private string DPI;
        private string Contrasenia;

        public Usuario(string nombre)
        {
            this.Nombre = nombre;
        }

        public void AsignarDpi(string dpiIngresado)
        {
            if(dpiIngresado.Length == 13 && EsNumerico(dpiIngresado))
            {
                DPI = dpiIngresado;
            }
            else
            {
                Console.WriteLine("DpI no es valido debe tener 13 valores numericos");
            }
        }

        public void IngrsarContrasenia(string clave)
        {
            if(clave.Length >= 6)
            {
                Contrasenia = clave;
            }
            else
            {
                Console.WriteLine("La contraseña debe de ser mayor a 6 caracteres");
            }
        }

        public bool Autenticar(string intento)
        {
            return intento == Contrasenia;
        }

        public void MostrarNombre()
        {
            Console.WriteLine("Nombre: " + Nombre);
        }

        private bool EsNumerico(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] < '0' || texto[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }



    }
}
