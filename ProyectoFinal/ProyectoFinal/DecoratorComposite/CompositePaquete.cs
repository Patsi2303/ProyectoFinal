using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DecoratorComposite
{
    internal class CompositePaquete : ComponentPaqueteBasico
    {
        List<ComponentPaqueteBasico> listaPaquetes;

        public CompositePaquete(string name, int descuento) : base(name, descuento)
        {
            listaPaquetes = new List<ComponentPaqueteBasico>();
        }

        public void AñadirElemento(ComponentPaqueteBasico e)
        {
            listaPaquetes.Add(e);
        }

        public void EliminarElemento(ComponentPaqueteBasico e)
        {
            listaPaquetes.Remove(e);
        }

        public override void DetallesPaquete()
        {
            foreach (ComponentPaqueteBasico e in listaPaquetes)
            {
                e.DetallesPaquete();
            }
        }

        public override double PrecioPaquete()
        {
            double precio = 0;

            foreach (ComponentPaqueteBasico e in listaPaquetes)
            {
                precio += e.PrecioPaquete() * ((100 - (double)Descuento) / 100);
            }
            
            return precio;
        }

        public override void MostrarPrecio() 
        {
            double precio = PrecioPaquete();
            double precioFinal = precio /* * ((100 - (double)Descuento) / 100) */ ;
            Console.WriteLine($"=================\nPaquete {Name}\nDescuento: {Descuento}%\nPrecio con descuento del paquete: {precioFinal}");
        }
    }
}
