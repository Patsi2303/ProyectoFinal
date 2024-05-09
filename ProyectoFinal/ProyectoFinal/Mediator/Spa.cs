using ProyectoFinal.State;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Mediator
{
    internal class Spa : ISistema
    {
        //public Spa(IMediator m) : base(m) { }
        public AbstractState Disponible { get; set; }
        public AbstractState Ocupado { get; set; }
        public AbstractState Reservado { get; set; }
        public AbstractState estadoActual;

        Dictionary<DateTime, int> reservasPorHorario = new Dictionary<DateTime, int>();
        public Spa(IMediator m) : base(m)
        {
            Disponible = new StateDisponible(this);
            Ocupado = new StateOcupado(this);
            Reservado = new StateReservado(this);
            estadoActual = Disponible;
        }


        public override void recibirMensaje(string mensaje, int nHabitacion, int tipo)
        {
            if (tipo == 5)
            {
                Console.WriteLine($"Servicio de Spa. Mensaje recibido: {mensaje}");
                string respuesta;
                respuesta = verificarHorario();
                if (respuesta == "No se pudo reservar el spa. Fecha invalida.")
                {
                    responderSolicitud(respuesta, nHabitacion);
                }
                else
                {
                    respuesta = respuesta + estadoActual.reservar();
                    responderSolicitud(respuesta, nHabitacion);
                }
                
            }
        }
        public override void responderSolicitud(string mensaje, int nHabitacion)
        {
            string msj = $"Servicio de Spa. Respuesta a solicitud: {mensaje}\nHabitación: {nHabitacion}";
            base.Mediador.recibirRespuesta(msj);
        }
        public string verificarHorario()
        {
            string error = "No se pudo reservar el spa. Fecha invalida.";
            DateTime fecha;
            Console.WriteLine("Ingrese la fecha en formato dd/MM/yyyy:");
            string inputFecha = Console.ReadLine();


            if (!DateTime.TryParseExact(inputFecha, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fecha))
            {
                Console.WriteLine("Formato de fecha/hora incorrecto.");
                return error;
            }


            int hora;

            Console.WriteLine("Ingrese la hora en formato HH (entre las 7 y las 21):");
            string inputHora = Console.ReadLine();
            if (!int.TryParse(inputHora, out hora))
            {
                Console.WriteLine("Formato de hora incorrecto. Por favor, ingrese la hora en el formato correcto.");
                return error;
            }
            // Verificar si la hora está dentro del rango permitido (7 - 21)
            if (hora < 7 || hora > 21)
            {
                Console.WriteLine("La hora ingresada está fuera del rango permitido (entre las 7 y las 21).");
                return error;
            }

            DateTime fechaHoraElegida = fecha.Date.AddHours(hora);

            // Verificar si la fecha y la hora elegidas son pasadas
            if (fechaHoraElegida.AddMinutes(-30) < DateTime.Now)
            {
                Console.WriteLine("La fecha y hora elegidas son pasadas. Por favor, elija una fecha y hora con 30 min de anticipación.");
                return error;
            }
            else
            {
                Console.WriteLine("La fecha y hora elegidas son válidas: " + fechaHoraElegida.ToString("dd/MM/yyyy HH:mm"));
            }

            if (!reservasPorHorario.ContainsKey(fechaHoraElegida))
            {
                reservasPorHorario[fechaHoraElegida] = 1;
                estadoActual = Disponible;
            }
            else if (reservasPorHorario[fechaHoraElegida] == 1)
            {
                reservasPorHorario[fechaHoraElegida]++;
                estadoActual = Reservado;
            }
            else
            {
                estadoActual = Ocupado;
            }
            return "Fecha válida:" + fechaHoraElegida;
        }
    }
}
