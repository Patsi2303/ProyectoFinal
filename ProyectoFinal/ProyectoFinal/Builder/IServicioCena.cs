using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Builder
{
    internal interface IServicioCena
    {
        void mostrarServicioCena();
    }
    class CenaEstandar : IServicioCena
    {
        public void mostrarServicioCena()
        {
            Console.WriteLine("EL SERVICIO DE CENA ESTANDAR INCLUYE:\n 1 Plato del dia por persona + Refresco");
        }
    }
    class CenaLujo : IServicioCena
    {
        public void mostrarServicioCena()
        {
            Console.WriteLine("EL SERVICIO DE CENA DE LUJO INCLUYE:\n Rodizio del menu + Refresco ilimitado");
        }
    }
    class CenaInteligente : IServicioCena
    {
        public void mostrarServicioCena()
        {
            Console.WriteLine("EL SERVICIO DE CENA INTELIGENTE INCLUYE:\n Rodizio del menu + Refresco + Servicio a habitacion gratis");
        }
    }
}
