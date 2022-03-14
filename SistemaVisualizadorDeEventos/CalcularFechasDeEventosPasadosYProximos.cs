using System;
using System.IO;

namespace SistemaVisualizadorDeEventos
{
    internal class CalcularFechasDeEventosPasadosYProximos
    {
        public void CalcularFechasDeEventos(int fechaEventoMesEnTxt, int fechaActualMes, int fechaEventoDiaEnTxt, int fechaActualDia, 
                                            int fechaEventoHorasEnTxt, int fechaActualHoras, int fechaEventoMinutoEnTxt, int fechaActualMinutos)
        {

            ImpresionDeEventos objComparar = new ImpresionDeEventos();

            int restaMeses = fechaEventoMesEnTxt - fechaActualMes;
            int restaDias = fechaEventoDiaEnTxt - fechaActualDia;
            int restaHoras = fechaEventoHorasEnTxt - fechaActualHoras;
            int restaMinutos = fechaEventoMinutoEnTxt - fechaActualMinutos;

            if (restaMeses > 0)
            {
                objComparar.imprimirEventosProximos(restaMeses, " Meses");
            }
            else if (restaDias > 0)
            {
                objComparar.imprimirEventosProximos(restaDias, " Dias");
            }
            else if (restaHoras > 0)
            {
                objComparar.imprimirEventosProximos(restaHoras, " Horas");
            }
            else if (restaMinutos > 0)
            {
                objComparar.imprimirEventosProximos(restaMinutos, " Minutos");
            }
            else if (restaMeses < 0)
            {
                objComparar.imprimirEventosPasados(restaMeses, " Meses");
            }
            else if (restaDias < 0)
            {
                objComparar.imprimirEventosPasados(restaDias, " Dias");
            }
            else if (restaHoras < 0)
            {
                objComparar.imprimirEventosPasados(restaHoras, " Horas");
            }
            else if (restaMinutos < 0)
            {
                objComparar.imprimirEventosPasados(restaMinutos, " Minutos");
            }
        }
    }
}