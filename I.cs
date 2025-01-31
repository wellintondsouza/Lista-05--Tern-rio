using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Verificando se o número1 é divisível por numero2 com operador ternário
        string resultado = (numero2 != 0 && numero1 % numero2 == 0) ? "Divisível" : "Não divisível";

        Console.WriteLine($"O número {numero1} é {resultado} por {numero2}.");
    }
}
