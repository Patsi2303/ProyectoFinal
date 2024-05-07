using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Command
{
    internal class ReceiverHabitacion
    {
        public void seleccionarArtista(string artista, string horario)
        {
            Console.WriteLine($"Reproduciendo {artista} en horario: {horario}");
        }
        public void seleccionarVolumen(string volumen, string horario) 
        {
            Console.WriteLine($"Ajustando volumen a: {volumen} en horario: {horario}");
        }
        public void seleccionarTemperaturaTina(string temperatura, string horario)
        {
            Console.WriteLine($"Llenando tina a temperatura: {temperatura}°C en horario: {horario}");
        }
        public void seleccionarIntensidadLuz(string intensidad, string horario)
        {
            if (intensidad == "1")
                Console.WriteLine($"Seleccionando intensidad LEVE de luz en horario: {horario}");
            if (intensidad == "2")
                Console.WriteLine($"Seleccionando intensidad MEDIA de luz en horario: {horario}");
            else
                Console.WriteLine($"Seleccionando intensidad ALTA de luz en horario: {horario}");
            
        }
        public void seleccionarCortinas(string abiertocerrado, string horario)
        {
            if (abiertocerrado == "1")
                Console.WriteLine($"Abriendo cortinas en horario: {horario}");
            else
                Console.WriteLine($"Cerrando cortinas en horario: {horario}");
        }

    }
}
