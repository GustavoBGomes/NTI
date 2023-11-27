using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };

        Console.WriteLine($"Lista de números inteiros: {string.Join(", ", numeros)}");

        Console.Write("Digite um número para buscar na lista: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int posicao = BuscarNumero(numeros, num);

        if (posicao != -1)
        {
            Console.WriteLine($"O número {num} está na posição {posicao} da lista.");
        }
        else
        {
            Console.WriteLine($"O número {num} não está presente na lista.");
        }
    }

    static int BuscarNumero(List<int> lista, int num)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i] == num)
            {
                return i;
            }
        }

        return -1;
    }
}
