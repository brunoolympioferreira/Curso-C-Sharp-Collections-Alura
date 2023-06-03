﻿namespace _09_Stack;
internal class Navegador
{
    private readonly Stack<string> historicoAnterior = new Stack<string>();
    private readonly Stack<string> historicoProximo = new();
    private string atual = "vazia";

    public Navegador()
    {
        Console.WriteLine("Página atual: " + atual);
    }

    internal void Anterior()
    {
        if (historicoAnterior.Any())
        {
            historicoProximo.Push(atual);
            atual = historicoAnterior.Pop();
            Console.WriteLine("Página atual: " + atual);
        }
    }

    internal void NavegarPara(string url)
    {
        historicoAnterior.Push(atual);
        atual = url;
        Console.WriteLine("Página atual: " + atual);
    }

    internal void Proximo()
    {
        if (historicoProximo.Any())
        {
            historicoAnterior.Push(atual);
            atual = historicoProximo.Pop();
            Console.WriteLine("Página atual: " + atual);
        }    
    }
}
