using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Command
{
    internal abstract class CACommand
    {
        protected ReceiverHabitacion habitacion;


        public CACommand(ReceiverHabitacion habitacion)
        {
            this.habitacion = habitacion;

        }

        public abstract void ejecutar();
    }
}
