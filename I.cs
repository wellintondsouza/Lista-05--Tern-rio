using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Verificando se numero1 é divisível por numero2 com operador ternário
        string resultado = (numero2 != 0 && numero1 % numero2 == 0) ? "Divisível" : "Não divisível";

        // Corrigindo a interpolação de string
        Console.WriteLine("O número {0} é {1} por {2}.", numero1, resultado, numero2);
        Console.ReadKey();
    }
}
