using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Mediator
{
    internal interface IMediator
    {
        void enviar(string mensaje, int nHabitacion, int tipo);
        void recibirRespuesta(string msj);
        void añadirColega(ISistema c);

    }
}
