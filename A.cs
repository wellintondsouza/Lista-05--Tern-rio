using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        // Usando operador ternário
        string resultado = (numero % 2 == 0) ? "Par" : "Ímpar";

        Console.WriteLine("O número {0} é {1}.", numero, resultado);
        
        Console.ReadKey(true);
    }
}
