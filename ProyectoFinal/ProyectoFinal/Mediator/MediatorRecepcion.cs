using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinal.Mediator
{
    internal class MediatorRecepcion : IMediator
    {
        List<ISistema> sistemas;
        
        public MediatorRecepcion()
        {
            sistemas = new List<ISistema>();
        }

        public void añadirColega(ISistema c)
        {
            sistemas.Add(c);
        }
        public void enviar(string mensaje, int nHabitacion, int tipo)
        {
            foreach (var sistema in sistemas)
            {
                sistema.recibirMensaje(mensaje, nHabitacion, tipo);
            }
        }
        public void recibirRespuesta(string msj)
        {
            Console.WriteLine(msj);
            return;
        }

        public void procesarSolicitud()
        {
            Console.WriteLine("Ingrese el numero de habitacion: ");
            int nHabitacion;
            if(!int.TryParse(Console.ReadLine(), out nHabitacion))
            {
                Console.WriteLine("El caracter ingresado no es un número. Por favor intente de nuevo");
                return;
            }
            Console.WriteLine("Ingrese un mensaje explicando la solicitud: ");
            string mensaje = Console.ReadLine();
            if (string.IsNullOrEmpty(mensaje)) 
            {
                Console.WriteLine("No puede enviar un mensaje vacio.");
                return;
            }
            Console.WriteLine("A que servicio va dirigida su solicitud: ");
            int tipo;
            Console.WriteLine("1. Mantenimiento");
            Console.WriteLine("2. Limpieza");
            Console.WriteLine("3. Cocina");
            Console.WriteLine("4. Bar");
            Console.WriteLine("5. Spa");
            Console.WriteLine("Ingrese una opcion: ");
            if (!int.TryParse(Console.ReadLine(), out tipo) || tipo > 5 || tipo < 1)
            {
                Console.WriteLine("El caracter ingresado no es valido. Por favor intente de nuevo");
                return;
            }
            enviar(mensaje, nHabitacion, tipo);
            
        }
    }
}
