using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
      
        string resultado = (numero > 10) ? "A condição é verdadeira." : "A condição é falsa.";

        Console.WriteLine(resultado);
        Console.ReadKey();
    }
}
