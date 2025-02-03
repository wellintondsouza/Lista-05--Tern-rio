using System;

class Program
{
    static void Main()
    
    {
        try
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Encontra o número com operador ternário
            int maior = (numero1 > numero2) ? numero1 : numero2;

            Console.WriteLine("O maior número é: {0}", maior);
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, digite um número válido.");
        }

        Console.ReadKey();
    }
