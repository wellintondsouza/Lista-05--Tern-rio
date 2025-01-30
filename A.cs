using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        int numero = int.Parse(Console.ReadLine()); // Lê a entrada do usuário

        // Verifica se o número é par ou ímpar
        if (numero % 2 == 0)
        {
            Console.WriteLine("É um número par.");
        }
        else
        {
            Console.WriteLine("É um número ímpar.");
        }

        Console.WriteLine("Aperte qualquer tecla para fechar...");
        Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
    }
}
