using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Mediator;

namespace ProyectoFinal.State
{
    internal class StateDisponible : AbstractState
    {
        public StateDisponible(Spa spa) : base(spa) { }
        public override string reservar()
        {
            return "\nHorario disponible. Su reserva fue realizada con éxito.";
        }
    }
}
