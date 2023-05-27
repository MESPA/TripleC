using System;
namespace PensamientoLOgico
{


    public class EmularcajeroAutomatico
    {
        public void EmularcajeroAutomaticon()
        {

            Dictionary<string, int> denominaciones = new Dictionary<string, int>()
        {
            { "2,000", 2000 },
            { "1,000", 1000 },
            { "500", 500 },
            { "200", 200 },
            { "100", 100 },
            { "50", 50 },
            { "25", 25 },
            { "10", 10 },
            { "5", 5 },

        };


            Console.Write("Ingrese el valor a calcular: ");
            if (!int.TryParse(Console.ReadLine(), out int valor))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                return;
            }


            List<string> billetesCantidad = new List<string>();


            foreach (KeyValuePair<string, int> denominacion in denominaciones)
            {
                int cantidad = valor / denominacion.Value;
                if (cantidad > 0)
                {
                    billetesCantidad.Add($"{cantidad} billete(s) de {denominacion.Key}");
                    valor %= denominacion.Value;
                }
            }


            Console.WriteLine("Cantidad de billetes y monedas:");
            foreach (string billeteCantidad in billetesCantidad)
            {
                Console.WriteLine(billeteCantidad);
            }
        }
    }
}


