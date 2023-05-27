using System;
using System.Collections.Generic;

public class Valoreesaleatorios
{
    public void MainValoreesaleatorios()
    {
    
        List<int> elementos = new List<int>();

        while (elementos.Count < 5) 
        {
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out int elemento))
            {
                elementos.Add(elemento);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            }
        }

        
        if (elementos.Count > 20)
        {
            elementos = elementos.GetRange(0, 20);
        }

      
        List<int> numerosAleatorios = new List<int>();

   
        Random random = new Random();

        while (numerosAleatorios.Count < elementos.Count)
        {
            int numeroAleatorio = random.Next(1, 101);

 
            if (!elementos.Contains(numeroAleatorio) && !numerosAleatorios.Contains(numeroAleatorio))
            {
               
                numerosAleatorios.Add(numeroAleatorio);
            }
        }


        foreach (int numero in numerosAleatorios)
        {
            Console.WriteLine(numero);
        }
    }
}
