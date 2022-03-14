using System;
using System.IO;

namespace SistemaVisualizadorDeEventos
{
    internal class LecturaDeArchivoDeTexto
    {
        public void leerArchivoTxt(string archivoTxt)
        {
            CalcularFechasDeEventosPasadosYProximos objCalcular = new CalcularFechasDeEventosPasadosYProximos();

            DateTime fechaActual = DateTime.Now;

            foreach (string lineaDeTexto in File.ReadLines(archivoTxt))
            {
                //Console.WriteLine("Linea 1: ");
                System.Console.WriteLine(lineaDeTexto);
            }

            Console.WriteLine("\n\nEVENTOS: \n");
            foreach (string s in File.ReadLines(archivoTxt))
            {
                int buscar = s.IndexOf(", ");
                DateTime fechaEventoTxt = DateTime.Parse(s.Substring(buscar + 2));

                objCalcular.CalcularFechasDeEventos(fechaEventoTxt.Month, fechaActual.Month, fechaEventoTxt.Day, fechaActual.Day, 
                                                    fechaEventoTxt.Hour, fechaActual.Hour, fechaEventoTxt.Minute, fechaEventoTxt.Minute);
            }
        }
    }
}