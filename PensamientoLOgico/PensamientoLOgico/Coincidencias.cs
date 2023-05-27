using System;
namespace PensamientoLOgico
{

    public class Coincidencias

    {
        public void Coincidencia()
        {

            List<int> numerosAleatorios = GenerarNumerosAleatorios();


            List<int> numerosPrimos = ObtenerNumerosPrimos(numerosAleatorios);


            int mayorValor = ObtenerMayorValor(numerosPrimos);


            List<int> numerosFibonacci = ObtenerNumerosFibonacci(mayorValor);


            Console.WriteLine("Números primos encontrados:");
            foreach (int numeroPrimo in numerosPrimos)
            {
                Console.WriteLine(numeroPrimo);
            }


            Console.WriteLine("Listado de números Fibonacci:");
            foreach (int numeroFibonacci in numerosFibonacci)
            {
                Console.WriteLine(numeroFibonacci);
            }
        }


        static List<int> GenerarNumerosAleatorios()
        {
            Random random = new Random();
            List<int> numerosAleatorios = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                int numeroAleatorio = random.Next(1, 101);
                numerosAleatorios.Add(numeroAleatorio);
            }

            return numerosAleatorios;
        }


        static bool EsPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }


        static List<int> ObtenerNumerosPrimos(List<int> numeros)
        {
            List<int> numerosPrimos = new List<int>();

            foreach (int numero in numeros)
            {
                if (EsPrimo(numero))
                {
                    numerosPrimos.Add(numero);
                }
            }

            return numerosPrimos;
        }


        static int ObtenerMayorValor(List<int> numeros)
        {
            int mayorValor = int.MinValue;

            foreach (int numero in numeros)
            {
                if (numero > mayorValor)
                {
                    mayorValor = numero;
                }
            }

            return mayorValor;
        }


        static List<int> ObtenerNumerosFibonacci(int cantidadElementos)
        {
            List<int> numerosFibonacci = new List<int>();

            int numeroAnterior = 0;
            int numeroActual = 1;

            for (int i = 0; i < cantidadElementos; i++)
            {
                numerosFibonacci.Add(numeroActual);

                int temp = numeroActual;
                numeroActual = numeroAnterior + numeroActual;
                numeroAnterior = temp;
            }
            return numerosFibonacci;
        }
    }

}