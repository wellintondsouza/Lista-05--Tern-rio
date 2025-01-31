using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine();

        // Verificando se a string está vazia com operador ternário
        string resultado = (string.IsNullOrEmpty(texto)) ? "A string está vazia." : "A string não está vazia.";

        Console.WriteLine(resultado);
    }
}
