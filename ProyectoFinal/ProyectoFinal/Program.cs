using System;
using System.Security.Cryptography.X509Certificates;
using ProyectoFinal.Builder;
using ProyectoFinal.DecoratorComposite;
using ProyectoFinal.Mediator;
using ProyectoFinal.Visitor;

namespace ProyectoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MediatorRecepcion miRecepcion = new MediatorRecepcion();
            Cliente miCliente = new Cliente(miRecepcion);

            Console.WriteLine("Bienvenido al sistema del hotel. Por favor elija su usuario:\n1. Cliente\n2. Recepcion\n3. Salir");
            int usuario = int.Parse(Console.ReadLine());
            int eleccion = 1;

            while (usuario != 3 && eleccion != 0) 
            {
                if (usuario == 1)
                {
                    Console.WriteLine("Ha iniciado la aplicacion como cliente. Que desea hacer:");
                    Console.WriteLine("1. Reservar habitacion y paquete.\n2. Usar habitacion inteligente\n3. Notificar/Solicitar a recepcion\n4. Cambiar a usuario recepcion\n0. Salir");
                    eleccion = int.Parse(Console.ReadLine());
                    switch(eleccion) 
                    {
                        case 1:
                            miCliente.reservarHabitacion();
                            break;
                        case 2:
                            if (miCliente.miHabitacion != null)
                                miCliente.usarHabitacionInteligente();
                            else
                                Console.WriteLine("No puede usar esta funcion sin tener una habitacion.");
                            break;
                        case 3:
                            if (miCliente.miHabitacion != null)
                                miCliente.mandarSolicitud();
                            else
                                Console.WriteLine("No puede usar esta funcion sin tener una habitacion.");
                            break;
                        case 4:
                            usuario = 2;
                            break;
                        default: 
                            Console.WriteLine("Ingrese una opcion valida");
                            break;
                    }
                    
                }
                else 
                {
                    Console.WriteLine("Ha iniciado la aplicacion como recepcion. Que desea hacer:");
                    Console.WriteLine("1. Ingresar solicitud manualmente.\n2. Generar reportes de los sistemas\n3. Cambiar a usuario cliente\n0. Salir");
                    eleccion = int.Parse(Console.ReadLine());
                    switch (eleccion)
                    {
                        case 1:
                            miRecepcion.procesarSolicitud();
                            break;
                        case 2:
                            miRecepcion.generarReportes();
                            break;
                        case 3:
                            usuario = 1;
                            break;
                        default:
                            Console.WriteLine("Ingrese una opcion valida");
                            break;
                    }
                }
            }
            Console.WriteLine("Vuelva pronto");
        
        }
    }
}