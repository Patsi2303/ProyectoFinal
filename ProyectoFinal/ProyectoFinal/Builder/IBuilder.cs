using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Builder
{
    internal interface IBuilder
    {
        void asignarNumHabitacion(int num);
        void asignarTipoHabitacion();
        void asignarDesayuno();
        void asignarServicioBar();
        void asignarAccesoAreasLudicas();
        void asignarServicioCena();
        void asignarPrecio();
        Habitacion devolverHabitacion();
    }
}
