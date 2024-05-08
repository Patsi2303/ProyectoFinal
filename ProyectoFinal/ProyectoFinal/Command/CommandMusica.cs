using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Command
{
    internal class CommandMusica : CACommand
    {
        public CommandMusica(ReceiverHabitacion habitacion) : base (habitacion) { }
        public override void ejecutar()
        {
            Console.WriteLine("Ingrese el nombre del artista que desea escuchar:");
            string artista = Console.ReadLine();
            Console.WriteLine("Ingrese el horario en el que desea escucharlo:");
            string horario = Console.ReadLine();
            habitacion.seleccionarArtista(artista, horario);
            Console.WriteLine("Ingrese el volúmen de 1 a 100 en el que desea escuchar:");
            string volumen = Console.ReadLine();
            habitacion.seleccionarVolumen(volumen, horario);
        }
    }
}
