using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Command
{
    internal class CommandCortinas : CACommand
    {
        public CommandCortinas(ReceiverHabitacion habitacion) : base(habitacion) { }
        public override void ejecutar()
        {
            Console.WriteLine("Seleccione la posición de las cortinas:\n 1. Abiertas\n 2. Cerradas");
            string posicion = Console.ReadLine();
            Console.WriteLine("Seleccione el horario en el que desea aplicar esta posición para las cortinas:");
            string horario = Console.ReadLine();
            habitacion.seleccionarCortinas(posicion, horario);
        }
    }
}
