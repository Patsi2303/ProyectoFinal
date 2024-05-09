using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Mediator
{
    internal abstract class ISistema
    {
        private IMediator mediador;
        public IMediator Mediador { get { return mediador; } }
        public ISistema(IMediator m)
        {
            this.mediador = m;
        }


        public abstract void responderSolicitud(string mensaje, int nHabitacion);

        public abstract void recibirMensaje(string mensaje, int nHabitacion, int tipo);
    }
}
