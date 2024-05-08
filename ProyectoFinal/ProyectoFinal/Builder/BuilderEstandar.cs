using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Builder
{
    internal class BuilderEstandar : IBuilder
    {
        Habitacion habitacion = new Habitacion();

        public void asignarNumHabitacion(int num)
        {
            habitacion.seleccionarNumHabitacion(num);
        }

        public void asignarTipoHabitacion()
        {
            habitacion.seleccionarTipoHabitacion("Estandar");
        }

        public void asignarAccesoAreasLudicas()
        {
            habitacion.seleccionarAreasLudicas(new AreaEstandar());
        }

        public void asignarDesayuno()
        {
            habitacion.seleccionarDesayuno(new DesayunoEstandar());
        }

        public void asignarServicioBar()
        {
            habitacion.seleccionarServicioBar(new BarEstandar());
        }

        public void asignarServicioCena()
        {
            habitacion.seleccionarServicioCena(new CenaEstandar());
        }

        public void asignarPrecio() 
        {
            habitacion.seleccionarPrecio(200);
        }

        public Habitacion devolverHabitacion()
        {
            //habitacion.detalleHabitacion();
            return habitacion;
        }
    }
}
