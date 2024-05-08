using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Mediator;

namespace ProyectoFinal.Visitor
{
    internal class VisitorSistemas : IVisitor
    {
        int precioMantenimiento = 20;
        int precioCocina = 50;
        int precioLimpieza = 25;
        int precioBar = 70;
        int precioSpa = 20;
        public string visitar(Mantenimiento mantenimiento)
        {
            //En cada uno solo habria que multiplicar el precio por el contador y ponerlo como un mensaje Console.WriteLine
            throw new NotImplementedException();
        }

        public string visitar(Cocina cocina)
        {
            throw new NotImplementedException();
        }

        public string visitar(Limpieza limpieza)
        {
            throw new NotImplementedException();
        }

        public string visitar(Bar bar)
        {
            throw new NotImplementedException();
        }

        public string visitar(Spa spa)
        {
            throw new NotImplementedException();
        }
    }
}
