using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Builder
{
    internal class Habitacion
    {
        IDesayuno desayuno;
        IServicioBar serviciobar;
        IAreasLudicas areasludicas;
        IServicioCena serviciocena;

        public void seleccionarDesayuno(IDesayuno midesayuno)
        {
            desayuno = midesayuno;
            Console.WriteLine($"-------------------------------------------\nSELECCION DE DESAYUNO:\n{desayuno.mostrarDesayuno}\n-------------------------------------------");
        }
        public void seleccionarServicioBar(IServicioBar miserviciobar)
        {
            serviciobar = miserviciobar;
            Console.WriteLine($"-------------------------------------------\nSELECCION DE BAR:\n{serviciobar.mostrarServicioBar}\n-------------------------------------------");
        }
        public void seleccionarAreasLudicas(IAreasLudicas miarealudica)
        {
            areasludicas = miarealudica;
            Console.WriteLine($"-------------------------------------------\nSELECCION DE ACCESO PARA AREAS LUDICAS:\n{areasludicas.mostrarServicioAreasLudicas}\n-------------------------------------------");
        }
        public void seleccionarServicioCena(IServicioCena miservicioCena)
        {
            serviciocena = miservicioCena;
            Console.WriteLine($"-------------------------------------------\nSELECCION DE SERVICIO DE CENA:\n{serviciocena.mostrarServicioCena}\n-------------------------------------------");
        }
        public void detalleHabitacion()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("=======DETALLES DE LA HABITACION SELECCIONADA=======");
            desayuno.mostrarDesayuno();
            serviciobar.mostrarServicioBar();
            areasludicas.mostrarServicioAreasLudicas();
            serviciocena.mostrarServicioCena();
            Console.WriteLine("-------------------------------------------");
        }
    }
}
