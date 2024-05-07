using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal abstract class ComponentPaquete
    {
        public string Name { get; set; }

        public ComponentPaquete(string name) 
        {
            Name = name;
        }

        public abstract void DetallesPaquete();
    }
}
