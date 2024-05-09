using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Mediator
{
    internal abstract class ISistema
    {
        public Dictionary<int, int> registrousos;

        private IMediator mediador;
        public IMediator Mediador { get { return mediador; } }
        public ISistema(IMediator m)
        {
            registrousos = new Dictionary<int, int>();
            this.mediador = m;
        }

        public abstract void responderSolicitud(string mensaje, int nHabitacion);

        public abstract void recibirMensaje(string mensaje, int nHabitacion, int tipo);
    }
}
