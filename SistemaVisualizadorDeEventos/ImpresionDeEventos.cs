using System;


namespace SistemaVisualizadorDeEventos
{
    internal class ImpresionDeEventos
    {
        public void imprimirEncabezado()
        {
            UbicarArchivoDeTexto objUbicar = new UbicarArchivoDeTexto();
            LecturaDeArchivoDeTexto objLectura = new LecturaDeArchivoDeTexto();

            Console.WriteLine("SISTEMA VISUALIZADOR DE EVENTOS\n");
            objLectura.leerArchivoTxt(objUbicar.ubicacionDeArchivo());
        }

        public void imprimirEventosPasados(int resultado, string date)
        {
                Console.WriteLine("El evento paso hace " + resultado * -1 + date);
        }

        public void imprimirEventosProximos(int resultado, string date)
        {
                Console.WriteLine("El evento sera dentro de " + resultado + date);
        }
    }
}
