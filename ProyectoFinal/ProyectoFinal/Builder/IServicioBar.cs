using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Builder
{
    internal interface IServicioBar
    {
        void mostrarServicioBar();
    }
    class BarEstandar : IServicioBar
    {
        public void mostrarServicioBar()
        {
            Console.WriteLine("EL SERVICIO DE BAR ESTANDAR CUENTA CON:\nRefrescos\nBebidas locales");
        }
    }
    class BarLujo : IServicioBar
    {
        public void mostrarServicioBar()
        {
            Console.WriteLine("EL SERVICIO DE BAR DE LUJO CUENTA CON:\nRefrescos\nBebidas clasicas\nAperativos");
        }

    }
    class BarInteligente : IServicioBar
    {
        public void mostrarServicioBar()
        {
            Console.WriteLine("EL SERVICIO DE BAR INTELIGENTE CUENTA CON:\nRefrescos\nBebidas clasicas\nJugo de frutas");
        }

    }
}