using System;

namespace PensamientoLOgico
{
    

    class Program
    {
        static void Main()
        {
            Valoreesaleatorios valoreesaleatorios = new Valoreesaleatorios();
            valoreesaleatorios.MainValoreesaleatorios();

            NumerosPrimos numerosPrimos = new NumerosPrimos() ;
            numerosPrimos.NumerosPrimo();

            EmularcajeroAutomatico emularcajeroAutomatico = new EmularcajeroAutomatico();
            emularcajeroAutomatico.EmularcajeroAutomaticon();

            Coincidencias coincidencias = new Coincidencias();
            coincidencias.Coincidencia();

        }
    }
}
