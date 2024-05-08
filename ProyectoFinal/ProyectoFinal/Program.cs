using System;
using ProyectoFinal.Builder;
using ProyectoFinal.DecoratorComposite;
using ProyectoFinal.Mediator;

namespace ProyectoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Director miDirector = new Director();
            BuilderInteligente builderInteligente = new BuilderInteligente();

            MediatorRecepcion miRecepcion = new MediatorRecepcion();

            ComponentPaquete miPaquete1;
            ComponentPaquete miPaquete2;
            ComponentPaquete miPaquete3;

            miPaquete1 = miRecepcion.generarPaqueteOne(miDirector.seleccionarHabitacion(builderInteligente, 1));
            miPaquete2 = miRecepcion.generarPaqueteMedium(miDirector.seleccionarHabitacion(builderInteligente, 2));
            miPaquete3 = miRecepcion.generarPaqueteBig(miDirector.seleccionarHabitacion(builderInteligente, 3));

            miPaquete1.MostrarPrecio();
            miPaquete2.MostrarPrecio();
            miPaquete3.MostrarPrecio();

            miPaquete1 = new DecoratorInternet(miPaquete1);
            miPaquete1.MostrarPrecio();
            miPaquete1.DetallesPaquete();*/

            Cliente miCliente = new Cliente();

            int continuar = 1;

            while (continuar == 1) 
            {
                miCliente.reservarHabitacion();
                Console.WriteLine("Desea resevar otro paquete\n1. Si\n2. No");
                continuar = int.Parse(Console.ReadLine());
            }
        }
    }
}