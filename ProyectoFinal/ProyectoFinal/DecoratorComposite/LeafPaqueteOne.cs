using ProyectoFinal.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DecoratorComposite
{
    internal class LeafPaqueteOne : ComponentPaqueteBasico
    {
        public Habitacion habitacion;

        public LeafPaqueteOne(Habitacion h, string nombre, int descuento) : base(nombre, descuento)
        {
            habitacion = h;
        }

        public override void DetallesPaquete()
        {
            Console.WriteLine($"------------{Name}------------");
            habitacion.detalleHabitacion();
        }

        public override double PrecioPaquete()
        {
            return habitacion.Precio;
        }

        public override void MostrarPrecio() 
        {
            Console.WriteLine($"=================\nPaquete {Name}\nPrecio paquete: {habitacion.Precio}");
        }
    }
}
