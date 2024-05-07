using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class LeafPaqueteOne : ComponentPaqueteBasico
    {
        public string Habitacion { get; set; }

        public LeafPaqueteOne(string nombre) : base(nombre)
        {
            Habitacion = "1 habitación";
        }

        public override void DetallesPaquete() 
        {
            Console.WriteLine($"{base.Name}: {Habitacion}");
        }
    }
}
