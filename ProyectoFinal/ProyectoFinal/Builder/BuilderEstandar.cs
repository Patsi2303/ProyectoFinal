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
        public Habitacion devolverHabitacion()
        {
            return habitacion;
        }
    }
}
