using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Builder;
using ProyectoFinal.DecoratorComposite;

namespace ProyectoFinal.Mediator
{
    internal class MediatorRecepcion : IMediator
    {
        Director miDirector;
        BuilderEstandar builderEstandar;
        BuilderLujo builderLujo;
        BuilderInteligente builderInteligente;

        int numHabitacion = 1;

        public MediatorRecepcion() 
        {
            miDirector = new Director();
            builderEstandar = new BuilderEstandar();
            builderLujo = new BuilderLujo();
            builderInteligente = new BuilderInteligente();

            numHabitacion = 1;
        }

        public Habitacion crearHabitacionEstandar() 
        {
            Habitacion h = miDirector.seleccionarHabitacion(builderEstandar, numHabitacion);
            numHabitacion++;
            return h;
        }

        public Habitacion crearHabitacionLujo()
        {
            Habitacion h = miDirector.seleccionarHabitacion(builderLujo, numHabitacion);
            numHabitacion++;
            return h;
        }

        public Habitacion crearHabitacionInteligente()
        {
            Habitacion h = miDirector.seleccionarHabitacion(builderInteligente, numHabitacion);
            numHabitacion++;
            return h;
        }

        public ComponentPaquete generarPaqueteOne(Habitacion h) 
        {
            ComponentPaquete paqueteOneBasico = new LeafPaqueteOne(h,"Paquete One", 0);
            return paqueteOneBasico;
        }

        public ComponentPaquete generarPaqueteMedium(Habitacion h)
        {
            ComponentPaquete paqueteMediumBasico = new CompositePaquete("Paquete Medium", 10);

            ComponentPaquete paqueteOneBasico = new LeafPaqueteOne(h, "Paquete One", 0);

            ((CompositePaquete)paqueteMediumBasico).AñadirElemento((ComponentPaqueteBasico)paqueteOneBasico);
            ((CompositePaquete)paqueteMediumBasico).AñadirElemento((ComponentPaqueteBasico)paqueteOneBasico);

            return paqueteMediumBasico;
        }

        public ComponentPaquete generarPaqueteBig(Habitacion h)
        {
            ComponentPaquete paqueteBigBasico = new CompositePaquete("Paquete Big", 20);

            ComponentPaquete paqueteMediumBasico = new CompositePaquete("Paquete Medium", 0);
           
            ComponentPaquete paqueteOneBasico = new LeafPaqueteOne(h, "Paquete One", 0);

            ((CompositePaquete)paqueteMediumBasico).AñadirElemento((ComponentPaqueteBasico)paqueteOneBasico);
            ((CompositePaquete)paqueteMediumBasico).AñadirElemento((ComponentPaqueteBasico)paqueteOneBasico);

            ((CompositePaquete)paqueteBigBasico).AñadirElemento((ComponentPaqueteBasico)paqueteOneBasico);
            ((CompositePaquete)paqueteBigBasico).AñadirElemento((ComponentPaqueteBasico)paqueteMediumBasico);
            ((CompositePaquete)paqueteBigBasico).AñadirElemento((ComponentPaqueteBasico)paqueteMediumBasico);

            return paqueteBigBasico;
        }

    }
}
