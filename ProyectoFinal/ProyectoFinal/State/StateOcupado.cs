using ProyectoFinal.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.State
{
    internal class StateOcupado : AbstractState
    {
        public StateOcupado(Spa spa) : base(spa) { }
        public override string reservar()
        {
            return "\nHorario no diponible. No se pudo realizar la reserva.";
        }
    }
}
