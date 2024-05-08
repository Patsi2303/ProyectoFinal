using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DecoratorComposite
{
    internal abstract class ComponentPaqueteBasico : ComponentPaquete
    {
        public ComponentPaqueteBasico(string name, int descuento) : base(name, descuento)
        {
        }
    }
}
