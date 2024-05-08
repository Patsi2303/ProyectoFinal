using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Builder
{
    internal class Habitacion
    {
        public int NumHabitacion { get; set; }
        public string TipoHabitacion { get; set; }
        IDesayuno desayuno;
        IServicioBar serviciobar;
        IAreasLudicas areasludicas;
        IServicioCena serviciocena;
        public int Precio { get; set; }

        public void seleccionarNumHabitacion(int num) 
        {
            NumHabitacion = num;
        }
        public void seleccionarTipoHabitacion(string tipo)
        {
            TipoHabitacion = tipo;
        }
        public void seleccionarDesayuno(IDesayuno midesayuno)
        {
            desayuno = midesayuno;
        }
        public void seleccionarServicioBar(IServicioBar miserviciobar)
        {
            serviciobar = miserviciobar;
        }
        public void seleccionarAreasLudicas(IAreasLudicas miarealudica)
        {
            areasludicas = miarealudica;
        }
        public void seleccionarServicioCena(IServicioCena miservicioCena)
        {
            serviciocena = miservicioCena;
        }

        public void seleccionarPrecio(int miPrecio)
        {
            Precio = miPrecio;
        }

        public void detalleHabitacion()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("=======DETALLES DE LA HABITACION SELECCIONADA=======");
            Console.WriteLine($"Numero de habitacion: {NumHabitacion}");
            Console.WriteLine($"Tipo de habitacion: {TipoHabitacion}");
            desayuno.mostrarDesayuno();
            serviciobar.mostrarServicioBar();
            areasludicas.mostrarServicioAreasLudicas();
            serviciocena.mostrarServicioCena();
            Console.WriteLine($"Precio de la habitacion: {Precio}");
            Console.WriteLine("-------------------------------------------");
        }
    }
}
