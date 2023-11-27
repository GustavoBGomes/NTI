using System;
using System.Collections.Generic;

class Insertion_Sort
{
    static void Main()
    {
        List<int> Lista_Inteiros = new List<int> { 12, 11, 13, 24, 36, 5 };

        Console.WriteLine("Ordenação Simples com Insertion Sort");
        Console.WriteLine("Lista Inicial:");
        PrintList(Lista_Inteiros);

        int n = Lista_Inteiros.Count;
        for (int i = 1; i < n; ++i)
        {
            int num = Lista_Inteiros[i];
            int j = i - 1;

            while (j >= 0 && Lista_Inteiros[j] > num)
            {
                Lista_Inteiros[j + 1] = Lista_Inteiros[j];
                j = j - 1;
            }
            Lista_Inteiros[j + 1] = num;
        }

        Console.WriteLine("\nLista Ordenada:");
        PrintList(Lista_Inteiros);
    }

    static void PrintList(List<int> list)
    {
        foreach (var i in list)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
