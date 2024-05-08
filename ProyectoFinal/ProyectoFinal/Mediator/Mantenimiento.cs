﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Mediator
{
    internal class Mantenimiento : ISistema
    {
        public Mantenimiento(IMediator m) : base(m) { }
        public override void recibirMensaje(string mensaje, int nHabitacion, int tipo)
        {
            if (tipo == 1)
            {
                Console.WriteLine($"Servicio de Mantenimiento. Mensaje recibido: {mensaje}");
                if (mensaje != null)
                {
                    responderSolicitud(mensaje, nHabitacion);
                }
            }         
        }
        public override void responderSolicitud(string mensaje, int nHabitacion)
        {
            string msj = $"Servicio de Mantenimiento. Se atendera la solicitud: {mensaje}.\nHabitación: {nHabitacion}";
            base.Mediador.recibirRespuesta(msj);          
        }
    }
}