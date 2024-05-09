using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Builder;
using ProyectoFinal.DecoratorComposite;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ProyectoFinal.Mediator
{
    internal class MediatorRecepcion : IMediator
    {
        Director miDirector;
        BuilderEstandar builderEstandar;
        BuilderLujo builderLujo;
        BuilderInteligente builderInteligente;

        int numHabitacion = 1;

        List<ISistema> sistemas;

        public MediatorRecepcion() 
        {
            miDirector = new Director();
            builderEstandar = new BuilderEstandar();
            builderLujo = new BuilderLujo();
            builderInteligente = new BuilderInteligente();

            numHabitacion = 1;

            sistemas = new List<ISistema>();
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
            Console.WriteLine("A que servicio va dirigida su solicitud: ");
            int tipo;
            Console.WriteLine("1. Mantenimiento");
            Console.WriteLine("2. Limpieza");
            Console.WriteLine("3. Cocina");
            Console.WriteLine("4. Bar");
            Console.WriteLine("5. Spa");
            Console.WriteLine("Ingrese una opcion: ");
            if (!int.TryParse(Console.ReadLine(), out tipo) || tipo > 5 || tipo < 0)
            {
                Console.WriteLine("El caracter ingresado no es valido.");
                return;
            }


            Console.WriteLine("Ingrese el numero de habitacion: ");
            int nHabitacion;
            if(!int.TryParse(Console.ReadLine(), out nHabitacion))
            {
                Console.WriteLine("El caracter ingresado no es un número. Por favor intente de nuevo");
                return;
            }
            Console.WriteLine("Ingrese el un mensaje explicando la solicitud: ");
            string mensaje = Console.ReadLine();
            if (string.IsNullOrEmpty(mensaje)) 
            {
                Console.WriteLine("No puede enviar un mensaje vacio.");
                return;
            }
            
            enviar(mensaje, nHabitacion, tipo);
            
        }
    }
}
