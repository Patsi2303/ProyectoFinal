using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class CompositePaquete : ComponentPaqueteBasico
    {
        List<ComponentPaqueteBasico> listaPaquetes; 
        public int Descuento { get; set; }

        public CompositePaquete(string name, int descuento) : base(name)
        {
            listaPaquetes = new List<ComponentPaqueteBasico>();
            Descuento = descuento;
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
            Console.WriteLine($"Descuento: {Descuento}");
        }
    }
}
