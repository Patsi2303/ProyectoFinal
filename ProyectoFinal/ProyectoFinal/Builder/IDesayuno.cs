using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Builder
{
    internal interface IDesayuno
    {
        void mostrarDesayuno();
    }
    class DesayunoEstandar : IDesayuno
    {
        public void mostrarDesayuno()
        {
            Console.WriteLine("EL DESAYUNO ESTANDAR CUENTA CON:\nInfusion\nPan\nGalletas\nMermeladas");
        }

    }
    class DesayunoLujo : IDesayuno
    {
        public void mostrarDesayuno()
        {
            Console.WriteLine("EL DESAYUNO DE LUJO CUENTA CON:\nInfusion\nJugo de frutas\nPan\nGalletas\nRacion de alimento cocinado");
        }
    }
    class DesayunoInteligente : IDesayuno
    {
        public void mostrarDesayuno()
        {
            Console.WriteLine("EL DESAYUNO INTELIGENTE CUENTA CON:\nRefresco\nJugo\nFrutas\nPan\nGalletas\nRacion de alimento cocinado\nAlimento fitness");
        }
    }
}
