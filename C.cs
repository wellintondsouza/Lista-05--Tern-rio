using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int>();

        // Verifica se a lista está vazia
        string resultado = lista.Count == 0 ? "A lista está vazia." : "A lista não está vazia.";
        Console.WriteLine(resultado);

        // Adiciona um numero na lista
        lista.Add(1);

        // Verifica novamente se a lista está vazia ou não
        resultado = lista.Count == 0 ? "A lista está vazia." : "A lista não está vazia.";
        Console.WriteLine(resultado);
   
        Console.ReadKey();
    }
}
