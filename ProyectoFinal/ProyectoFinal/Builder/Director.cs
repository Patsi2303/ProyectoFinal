using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Builder
{
    internal class Director
    {
        IBuilder builderHabitacion = null;
        public Habitacion seleccionarHabitacion(IBuilder builder, int num)
        {
            builderHabitacion = builder;
            builderHabitacion.asignarNumHabitacion(num);
            builderHabitacion.asignarTipoHabitacion();
            builderHabitacion.asignarDesayuno();
            builderHabitacion.asignarServicioBar();
            builderHabitacion.asignarAccesoAreasLudicas();
            builderHabitacion.asignarServicioCena();
            builderHabitacion.asignarPrecio();
            return builderHabitacion.devolverHabitacion();
        }
    }
}
