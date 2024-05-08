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

        public void asignarNumHabitacion(int num)
        {
            habitacion.seleccionarNumHabitacion(num);
        }

        public void asignarTipoHabitacion()
        {
            habitacion.seleccionarTipoHabitacion("Lujo");
        }

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

        public void asignarPrecio() 
        {
            habitacion.seleccionarPrecio(350);
        }

        public Habitacion devolverHabitacion()
        {
            //habitacion.detalleHabitacion();
            return habitacion;
        }
    }
}
