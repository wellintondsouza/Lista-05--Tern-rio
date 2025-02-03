using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        // Calculando o valor absoluto com operador ternário
        int valorAbsoluto = (numero < 0) ? -numero : numero;

        Console.WriteLine("O valor absoluto de {0} é {1}.", numero, valorAbsoluto);
        Console.ReadKey();
    }
}
