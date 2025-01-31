using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>(); // Lista vazia

        // Verificando se a lista está vazia com operador ternário
        string resultado = (numeros.Count == 0) ? "A lista está vazia." : "A lista não está vazia.";

        Console.WriteLine(resultado);
    }
}
