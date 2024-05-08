using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Builder
{
    internal class BuilderInteligente : IBuilder
    {
        Habitacion habitacion = new Habitacion();

        public void asignarNumHabitacion(int num) 
        {
            habitacion.seleccionarNumHabitacion(num);
        }

        public void asignarTipoHabitacion() 
        {
            habitacion.seleccionarTipoHabitacion("Inteligente");
        }

        public void asignarAccesoAreasLudicas()
        {
            habitacion.seleccionarAreasLudicas(new AreaInteligente());
        }

        public void asignarDesayuno()
        {
            habitacion.seleccionarDesayuno(new DesayunoInteligente());
        }

        public void asignarServicioBar()
        {
            habitacion.seleccionarServicioBar(new BarInteligente());
        }

        public void asignarServicioCena()
        {
            habitacion.seleccionarServicioCena(new CenaInteligente());
        }

        public void asignarPrecio() 
        {
            habitacion.seleccionarPrecio(400);
        }

        public Habitacion devolverHabitacion()
        {
            //habitacion.detalleHabitacion();
            return habitacion;
        }
    }
}
