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