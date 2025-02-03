using System;

class Program
{
    static void Main()
    {
        // Escolha um número para conversão
        string input = "123";

        // Tenta converter a string para numero inteiro usando o operador ternário
        int numero = int.TryParse(input, out numero) ? numero : 0;

        Console.WriteLine("O número convertido é: " + numero);
        Console.ReadKey();
    }
}
