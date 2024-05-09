using System;
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
            Cliente miCliente = new Cliente();

            int continuar = 1;

            while (continuar == 1) 
            {
                miCliente.reservarHabitacion();
                Console.WriteLine("Desea resevar otro paquete\n1. Si\n2. No");
                continuar = int.Parse(Console.ReadLine());
            }

            miCliente.usarHabitacionInteligente();
            
            /*
            char continuar = 'y';

            IMediator mediator = new MediatorRecepcion();
            ISistema mantenimiento = new Mantenimiento(mediator);
            ISistema limpieza = new Limpieza(mediator);
            ISistema cocina = new Cocina(mediator);
            ISistema bar = new Bar(mediator);
            ISistema spa = new Spa(mediator);
            mediator.añadirColega(mantenimiento);
            mediator.añadirColega(limpieza);
            mediator.añadirColega(cocina);
            mediator.añadirColega(bar);
            mediator.añadirColega(spa);

            while (continuar == 'y') 
            {
                ((MediatorRecepcion)mediator).procesarSolicitud();
                Console.WriteLine("Enviar otra solicitud");
                continuar = char.Parse(Console.ReadLine());
            }

            IVisitor visitor = new VisitorSistemas();
            mantenimiento.aceptarVisitor(visitor);
            limpieza.aceptarVisitor(visitor);
            cocina.aceptarVisitor(visitor);
            bar.aceptarVisitor(visitor);
            spa.aceptarVisitor(visitor);

            */

        }
    }
}