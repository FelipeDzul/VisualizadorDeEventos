using System;
using System.Threading;
using System.IO;

namespace SistemaVisualizadorDeEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            ImpresionDeEventos objImprimir = new ImpresionDeEventos();
            objImprimir.imprimirEncabezado();
            Console.ReadKey();
        }
    }
}
