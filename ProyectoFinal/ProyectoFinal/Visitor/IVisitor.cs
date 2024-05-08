using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Mediator;

namespace ProyectoFinal.Visitor
{
    internal interface IVisitor
    {
        string visitar(Mantenimiento mantenimiento);
        string visitar(Cocina cocina);
        string visitar(Limpieza limpieza);
        string visitar(Bar bar);
        string visitar(Spa spa);
    }
}
