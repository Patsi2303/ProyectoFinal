using ProyectoFinal.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.State
{
    internal class StateReservado : AbstractState
    {
        public StateReservado(Spa spa) : base(spa) { }
        public override string reservar()
        {
            return "\nHorario reservado. El sistema le permitirá hacer una segunda reserva en este horario.";
        }
    }
}
