using System;

class No
{
    public int data;
    public No esquerda, direita;

    public No(int value)
    {
        data = value;
        esquerda = direita = null;
    }
}

class Arvore
{
    // Raiz da árvore binária
    public No raiz;

    public Arvore()
    {
        raiz = null;
    }

    public void InOrderTraversal(No no)
    {
        if (no == null)
            return;

        InOrderTraversal(no.esquerda);

        Console.Write(no.data + " ");

        InOrderTraversal(no.direita);
    }

    public void PrintInOrder()
    {
        InOrderTraversal(raiz);
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {

        Arvore arvore = new Arvore();
        arvore.raiz = new No(4);
        arvore.raiz.esquerda = new No(2);
        arvore.raiz.direita = new No(5);
        arvore.raiz.esquerda.esquerda = new No(1);
        arvore.raiz.esquerda.direita = new No(3);

        Console.WriteLine("Valores da árvore em ordem:");
        arvore.PrintInOrder();
    }
}
