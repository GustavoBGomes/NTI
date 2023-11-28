using System;

class Palindromo
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra para verificar se é um palíndromo:");
        string palavra = Console.ReadLine();

        bool verifica = VerificarPalindromo(palavra);

        if (verifica)
        {
            Console.WriteLine($"'{palavra}' é um palíndromo.");
        }
        else
        {
            Console.WriteLine($"'{palavra}' não é um palíndromo.");
        }
    }

    static bool VerificarPalindromo(string palavra)
    {
        palavra = palavra.ToLower(); 

        int esquerda = 0;
        int direita = palavra.Length - 1;

        while (esquerda < direita)
        {
            if (palavra[esquerda] != palavra[direita])
            {
                return false; 
            }
            esquerda++;
            direita--;
        }

        return true; 
    }
}
