using ProyectoFinal.Builder;
using ProyectoFinal.Command;
using ProyectoFinal.DecoratorComposite;
using ProyectoFinal.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Cliente
    {
        public MediatorRecepcion miRecepcion;
        public Habitacion miHabitacion;
        public ComponentPaquete miPaquete;
        public Cliente(MediatorRecepcion r) 
        {
            miRecepcion = r;
        }    

        public void reservarHabitacion() 
        {
            Console.WriteLine("Bienvenido al sistema de reservas del hotel\nSeleccione el tipo de habitacion que desea reservar");
            Console.WriteLine("1. Estandar (200bs)\n2. Lujo (350bs)\n3. Inteligente (400bs)\n4. Salir");
            int eleccion = int.Parse(Console.ReadLine());
            if (eleccion == 4) 
            {
                return; 
            }
            else
            {
                switch (eleccion) 
                {
                    case 1:
                        miHabitacion = miRecepcion.crearHabitacionEstandar();
                        break;
                    case 2:
                        miHabitacion = miRecepcion.crearHabitacionLujo();
                        break;
                    case 3:
                        miHabitacion = miRecepcion.crearHabitacionInteligente();
                        break;
                }
            }

            Console.WriteLine("Ahora seleccione el paquete que desea reservar");
            Console.WriteLine("1. Paquete One (1 Habitacion)\n2. Paquete Medium (2 Habitaciones)\n3. Paquete Big (5 Habitaciones)");
            eleccion = int.Parse(Console.ReadLine());
            
            switch (eleccion)
            {
                case 1:
                    miPaquete = miRecepcion.generarPaqueteOne(miHabitacion);
                    break;
                case 2:
                    miPaquete = miRecepcion.generarPaqueteMedium(miHabitacion);
                    break;
                case 3:
                    miPaquete = miRecepcion.generarPaqueteBig(miHabitacion);
                    break;
                default:
                    Console.WriteLine("Ocurrio un error");
                    return;
            }

            Console.WriteLine("Desea añadir servicios adicionales a su paquete");
            Console.WriteLine("1. Si, quiero añadir servicios adicionales\n2. No, no quiero servicios adicionales");
            eleccion = int.Parse(Console.ReadLine());
            int servAdicional = 0;

            while (eleccion == 1 && servAdicional != 6) 
            {
                Console.WriteLine("Servicios adicionales");
                Console.WriteLine("1. Internet (10bs)\n2. Gimnasio (20bs)\n3. Spa (20bs)\n4. Karaoke (30bs)\n5. Cine (30bs)\n6. Salir");
                servAdicional = int.Parse(Console.ReadLine());
                switch (servAdicional) 
                {
                    case 1:
                        miPaquete = new DecoratorInternet(miPaquete);
                        break;
                    case 2:
                        miPaquete = new DecoratorGimnasio(miPaquete);
                        break;
                    case 3:
                        miPaquete = new DecoratorSpa(miPaquete);
                        break;
                    case 4:
                        miPaquete = new DecoratorKaraoke(miPaquete);
                        break;
                    case 5:
                        miPaquete = new DecoratorCine(miPaquete);
                        break;
                }
            }

            Console.WriteLine("Su paquete ha sido reservado con exito");
            miPaquete.MostrarPrecio();
            Console.WriteLine("Desea ver el detalle de la reserva\n1. Si\n2. No");
            eleccion = int.Parse (Console.ReadLine());
            if (eleccion == 1)
                miPaquete.DetallesPaquete();
            Console.WriteLine("Gracias por confiar en nosotros");
        }

        public void usarHabitacionInteligente() 
        {
            if (miHabitacion.TipoHabitacion == "Inteligente")
            {
                ReceiverHabitacion miReceiver = new ReceiverHabitacion();
                InvokerAppHotel miApp = new InvokerAppHotel();
                int accion = 1;

                while (accion != 4) 
                {
                    Console.WriteLine("Que quiere hacer\n1. Programar accion\n2. Eliminar ultima accion\n3. Ejecutar acciones\n4. Salir");
                    accion = int.Parse (Console.ReadLine());
                    int eleccion = 1;

                    while (accion == 1 && eleccion != 5) 
                    {
                        CACommand miCommand;
                        Console.WriteLine("Programar accion:\n1. Programar Cortinas\n2. Programar Luz\n3. Programar Musica\n4. Programar Tina\n5. Salir");
                        eleccion = int.Parse(Console.ReadLine()); 
                        switch (eleccion) 
                        {
                            case 1:
                                miCommand = new CommandCortinas(miReceiver);
                                miApp.anadirSolicitud(miCommand);
                                break;
                            case 2:
                                miCommand = new CommandLuz(miReceiver);
                                miApp.anadirSolicitud(miCommand);
                                break;
                            case 3:
                                miCommand = new CommandMusica(miReceiver);
                                miApp.anadirSolicitud(miCommand);
                                break;
                            case 4:
                                miCommand = new CommandTina(miReceiver);
                                miApp.anadirSolicitud(miCommand);
                                break;
                            case 5:
                                break;
                            default:
                                Console.WriteLine("Ingrese una opcion valida");
                                break;
                        }
                    }
                    if (accion == 2)
                        miApp.eliminarSolicitud();

                    if (accion == 3)
                        miApp.procesarSolicitudes();
                }
            }
            else 
            {
                Console.WriteLine("Lo sentimos, su habitacion no puede usar esta funcion.");
            }
        }

        public void mandarSolicitud() 
        {
            miRecepcion.procesarSolicitudEspecifica(miHabitacion.NumHabitacion);
        }
    }
}
