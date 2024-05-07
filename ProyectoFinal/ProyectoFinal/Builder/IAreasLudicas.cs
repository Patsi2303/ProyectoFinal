using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Builder
{
    internal interface IAreasLudicas
    {
        void mostrarServicioAreasLudicas();
    }
    class AreaEstandar : IAreasLudicas
    {
        public void mostrarServicioAreasLudicas()
        {
            Console.WriteLine("EL ACCESO ESTANDAR A AREAS LUDICAS CONSISTE EN:\n1 vez al dia:\n Piscina\n Juegos infantiles");
        }

    }
    class AreaLujo : IAreasLudicas
    {
        public void mostrarServicioAreasLudicas()
        {
            Console.WriteLine("EL ACCESO DE LUJO A AREAS LUDICAS CONSISTE EN:\nIlimitado:\n Piscina\n Juegos infantiles\n Casino");
        }
    }
    class AreaInteligente : IAreasLudicas
    {
        public void mostrarServicioAreasLudicas()
        {
            Console.WriteLine("EL ACCESO INTELIGENTE A AREAS LUDICAS CONSISTE EN:\nIlimitado:\n Piscina\n Casino");
        }

    }
}
