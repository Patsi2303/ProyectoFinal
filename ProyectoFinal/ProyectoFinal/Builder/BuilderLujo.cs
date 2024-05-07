using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Builder
{
    internal class BuilderLujo : IBuilder
    {
        Habitacion habitacion = new Habitacion();

        public void asignarAccesoAreasLudicas()
        {
            habitacion.seleccionarAreasLudicas(new AreaLujo());
        }

        public void asignarDesayuno()
        {
            habitacion.seleccionarDesayuno(new DesayunoLujo());
        }

        public void asignarServicioBar()
        {
            habitacion.seleccionarServicioBar(new BarLujo());
        }

        public void asignarServicioCena()
        {
            habitacion.seleccionarServicioCena(new CenaLujo());
        }
        public Habitacion devolverHabitacion()
        {
            return habitacion;
        }
    }
}
