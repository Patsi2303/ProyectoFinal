using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Command
{
    internal class InvokerAppHotel
    {
        private List<CACommand> commands = new List<CACommand>();

        public void anadirSolicitud (CACommand solicitud)
        {
            commands.Add(solicitud);
            Console.WriteLine("Solicitud agregada a la lista...");
        }
        public void eliminarSolicitud()
        {
            if (commands.Count > 0)
            {
                commands.RemoveAt(commands.Count - 1);
                Console.WriteLine("Última solicitud eliminada.");
            }
            else
            {
                Console.WriteLine("La lista está vacía, no se puede eliminar ninguna solicitud.");
            }
        }
        public void procesarSolicitudes()
        {
            if (commands.Count == 0)
                Console.WriteLine("No hay solicitudes registradas");
            else
            {
                Console.WriteLine("-------------------------\nEJECUTANDO SOLICITUDES:");
                foreach (var solicitud in commands)
                    solicitud.ejecutar();

                commands.Clear();
            }
        }
    }
}
