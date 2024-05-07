using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DecoratorComposite
{
    internal abstract class Decorator : ComponentPaquete
    {
        public ComponentPaquete paquete;
        public string Extra { get; set; }
        public int Precio { get; set; }

        public Decorator(ComponentPaquete paquete, string extra, int precio) : base(paquete.Name)
        {
            this.paquete = paquete;
            Extra = extra;
            Precio = precio;
        }

        public override void DetallesPaquete()
        {
            paquete.DetallesPaquete();
            Console.WriteLine($"Servicio extra: {Extra} por {Precio}Bs.");
        }
    }

    internal class DecoratorInternet : Decorator
    {
        public DecoratorInternet(ComponentPaquete paquete) : base(paquete, "Internet", 10) { }
    }

    internal class DecoratorGimnasio : Decorator
    {
        public DecoratorGimnasio(ComponentPaquete paquete) : base(paquete, "Gimnasio", 20) { }
    }

    internal class DecoratorSpa : Decorator
    {
        public DecoratorSpa(ComponentPaquete paquete) : base(paquete, "Spa", 20) { }
    }

    internal class DecoratorKaraoke : Decorator
    {
        public DecoratorKaraoke(ComponentPaquete paquete) : base(paquete, "Karaoke", 30) { }
    }

    internal class DecoratorCine : Decorator
    {
        public DecoratorCine(ComponentPaquete paquete) : base(paquete, "Cine", 30) { }
    }
}
