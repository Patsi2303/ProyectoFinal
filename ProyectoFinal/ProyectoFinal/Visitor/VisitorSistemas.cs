using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Mediator;

namespace ProyectoFinal.Visitor
{
    internal class VisitorSistemas : IVisitor
    {
        int precioMantenimiento = 20;
        int precioCocina = 50;
        int precioLimpieza = 25;
        int precioBar = 70;
        int precioSpa = 20;
        public string visitar(Mantenimiento mantenimiento)
        {
            string reporte = $"======== Reporte - Mantenimiento ========";

            foreach (var registro in mantenimiento.registroUsos) 
            {
                reporte += $"\nHabitacion {registro.Key}. Usos: {registro.Value}. Costo: {precioMantenimiento * registro.Value}";
            }

            return reporte;
        }

        public string visitar(Cocina cocina)
        {
            string reporte = $"======== Reporte - Cocina ========";

            foreach (var registro in cocina.registroUsos)
            {
                reporte += $"\nHabitacion {registro.Key}. Usos: {registro.Value}. Costo: {precioCocina * registro.Value}";
            }

            return reporte;
        }

        public string visitar(Limpieza limpieza)
        {
            string reporte = $"======== Reporte - Limpieza ========";

            foreach (var registro in limpieza.registroUsos)
            {
                reporte += $"\nHabitacion {registro.Key}. Usos: {registro.Value}. Costo: {precioLimpieza * registro.Value}";
            }

            return reporte;
        }

        public string visitar(Bar bar)
        {
            string reporte = $"======== Reporte - Bar ========";

            foreach (var registro in bar.registroUsos)
            {
                reporte += $"\nHabitacion {registro.Key}. Usos: {registro.Value}. Costo: {precioBar * registro.Value}";
            }

            return reporte;
        }

        public string visitar(Spa spa)
        {
            string reporte = $"======== Reporte - Spa ========";

            foreach (var registro in spa.registroUsos)
            {
                reporte += $"\nHabitacion {registro.Key}. Usos: {registro.Value}. Costo: {precioSpa * registro.Value}";
            }

            return reporte;
        }
    }
}
