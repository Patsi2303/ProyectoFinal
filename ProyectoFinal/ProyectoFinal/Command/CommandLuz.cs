using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Command
{
    internal class CommandLuz : CACommand
    {
        public CommandLuz(ReceiverHabitacion habitacion) : base(habitacion) { }
        public override void ejecutar()
        {
            Console.WriteLine("Seleccione la intensidad de la luz:\n 1. Leve\n 2. Media\n 3. Alta");
            string intensidad = Console.ReadLine();
            Console.WriteLine("Seleccione el horario en el que desea aplicar esta intensidad de luz:");
            string horario  = Console.ReadLine();
            habitacion.seleccionarIntensidadLuz(intensidad, horario);
        }
    }
}
