using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        // Verificando se o número é positivo, negativo ou zero com operador ternário
        string resultado = (numero > 0) ? "Positivo" : (numero < 0) ? "Negativo" : "Zero";

        Console.WriteLine("O número {0} é {1}.", numero, resultado);
        Console.ReadKey();
    }
}
