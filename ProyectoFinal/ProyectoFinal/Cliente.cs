using ProyectoFinal.Builder;
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
        MediatorRecepcion miRecepcion = new MediatorRecepcion();
        Habitacion miHabitacion;
        ComponentPaquete miPaquete;
        public Cliente() { }    

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
                    miPaquete = miRecepcion.generarPaqueteBig(miHabitacion);
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
    }
}
