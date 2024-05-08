﻿using System;
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

<<<<<<< HEAD
            int continuar = 1;

            while (continuar == 1) 
            {
                miCliente.reservarHabitacion();
                Console.WriteLine("Desea resevar otro paquete\n1. Si\n2. No");
                continuar = int.Parse(Console.ReadLine());
            }
=======
            ComponentPaquete paqueteMedium = new CompositePaquete("Paquete Medium", 10);
            ((CompositePaquete)paqueteMedium).AñadirElemento(paqueteOne);

            ComponentPaquete paqueteBig = new CompositePaquete("Paquete Big", 20);*/

            //LeafPaqueteOne paqueteOne = new LeafPaqueteOne("Paquete One");

            /*Console.WriteLine("--------------Paquete One--------------");
            ComponentPaquete paqueteOneBasico = new LeafPaqueteOne("Paquete One");

            paqueteOneBasico.DetallesPaquete();

            ComponentPaquete paqueteOneDecorado = new DecoratorInternet(paqueteOneBasico);

            paqueteOneDecorado.DetallesPaquete();

            paqueteOneDecorado = new DecoratorCine(paqueteOneDecorado);
            paqueteOneDecorado = new DecoratorKaraoke(paqueteOneDecorado);
            paqueteOneDecorado = new DecoratorSpa(paqueteOneDecorado);

            paqueteOneDecorado.DetallesPaquete();

            Console.WriteLine("--------------Paquete Medium--------------");
            ComponentPaquete paqueteMediumBasico = new CompositePaquete("Paquete Medium", 10);
            ((CompositePaquete)paqueteMediumBasico).AñadirElemento((ComponentPaqueteBasico)paqueteOneBasico);
            ((CompositePaquete)paqueteMediumBasico).AñadirElemento((ComponentPaqueteBasico)paqueteOneBasico);
            paqueteMediumBasico.DetallesPaquete();

            ComponentPaquete paqueteMedianoDecorado = new DecoratorGimnasio(paqueteMediumBasico);
            paqueteMedianoDecorado.DetallesPaquete();

            Console.WriteLine("--------------Paquete Big--------------");
            ComponentPaquete paqueteBigBasico = new CompositePaquete("Paquete Big", 20);
            ((CompositePaquete)paqueteBigBasico).AñadirElemento((ComponentPaqueteBasico)paqueteOneBasico);
            ((CompositePaquete)paqueteBigBasico).AñadirElemento((ComponentPaqueteBasico)paqueteMediumBasico);
            ((CompositePaquete)paqueteBigBasico).AñadirElemento((ComponentPaqueteBasico)paqueteMediumBasico);
            paqueteBigBasico.DetallesPaquete();

            ComponentPaquete paqueteBigDecorado = new DecoratorCine(paqueteBigBasico);
            paqueteBigDecorado = new DecoratorKaraoke(paqueteOneDecorado);
            paqueteBigDecorado = new DecoratorSpa(paqueteOneDecorado);
            paqueteBigDecorado.DetallesPaquete();*/

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
            ((MediatorRecepcion)mediator).procesarSolicitud();
            Console.ReadKey();
>>>>>>> origin/Mediator
        }
    }
}