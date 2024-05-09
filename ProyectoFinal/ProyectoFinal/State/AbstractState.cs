using ProyectoFinal.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.State
{
    internal abstract class AbstractState
    {
        protected Spa spa;
        public AbstractState(Spa spa)
        {
            this.spa = spa;
        }
        public abstract string reservar();
    }
}
