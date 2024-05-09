using ProyectoFinal.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Mediator
{
    internal class Cocina : ISistema
    {
        public Cocina(IMediator m) : base(m) { }
        public override void recibirMensaje(string mensaje, int nHabitacion, int tipo)
        {
            if (tipo == 3)
            {
                Console.WriteLine($"Servicio de Cocina. Mensaje recibido: {mensaje}");
                if (mensaje != null)
                {
                    responderSolicitud(mensaje, nHabitacion);
                }
            }
        }
        public override void responderSolicitud(string mensaje, int nHabitacion)
        {
            if (registroUsos.ContainsKey(nHabitacion))
                registroUsos[nHabitacion]++;
            else
                registroUsos[nHabitacion] = 1;
            string msj = $"Servicio de Cocina. Se atendera la solicitud: {mensaje}.\nHabitación: {nHabitacion}";
            base.Mediador.recibirRespuesta(msj);
        }
        public override void aceptarVisitor(IVisitor visitor)
        {
            Console.WriteLine(visitor.visitar(this));
        }
    }
}
