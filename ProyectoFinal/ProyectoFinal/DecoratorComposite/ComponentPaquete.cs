using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DecoratorComposite
{
    internal abstract class ComponentPaquete
    {
        public string Name { get; set; }
        public int Descuento { get; set; }

        public ComponentPaquete(string name, int descuento)
        {
            Name = name;
            Descuento = descuento;
        }

        public abstract void DetallesPaquete();
        public abstract double PrecioPaquete();
        public abstract void MostrarPrecio();
    }
}
