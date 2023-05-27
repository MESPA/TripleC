using System;
using System.Collections.Generic;
public class NumerosPrimos

{
    public void NumerosPrimo() { 
        // Pedir al usuario la cantidad de números primos a generar (por defecto: 9)
        Console.Write("Ingrese la cantidad de números primos a generar (por defecto: 9): ");
        int cantidadNumerosPrimos;
        if (!int.TryParse(Console.ReadLine(), out cantidadNumerosPrimos) || cantidadNumerosPrimos <= 0)
        {
            cantidadNumerosPrimos = 9;
        }

        // Crear una lista para almacenar los números primos
        List<int> numerosPrimos = new List<int>();

        // Iniciar el contador en 2 (el primer número primo)
        int contador = 2;

        // Generar números primos hasta alcanzar la cantidad deseada
        while (numerosPrimos.Count < cantidadNumerosPrimos)
        {
            if (EsPrimo(contador))
            {
                numerosPrimos.Add(contador);
            }
            contador++;
        }

        // Imprimir los números primos generados
        foreach (int numeroPrimo in numerosPrimos)
        {
            Console.WriteLine(numeroPrimo);
        }
    }

    // Función para verificar si un número es primo
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
}
