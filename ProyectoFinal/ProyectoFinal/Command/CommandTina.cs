using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Command
{
    internal class CommandTina : CACommand
    {
        public CommandTina(ReceiverHabitacion habitacion) : base(habitacion) { }
        public override void ejecutar()
        {
            Console.WriteLine("Ingrese la temperatura del agua para llenar la tina:");
            string temperatura = Console.ReadLine();
            Console.WriteLine("Ingrese el horario en el que desea llenar la tina");
            string horario = Console.ReadLine();
            habitacion.seleccionarTemperaturaTina(temperatura, horario);
        }
    }
}
