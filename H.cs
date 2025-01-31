using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero))
        {
            Console.WriteLine($"O número digitado foi: {numero}");
        }
        else
        {
            Console.WriteLine("Entrada inválida! Por favor, insira um número.");
        }
    }
}
