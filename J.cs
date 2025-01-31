using System;

class Program
{
    static void Main()
    {
        string texto = null;  // Você pode mudar esse valor para testar

        // Verificando se a variável é nula com operador ternário
        string resultado = (texto == null) ? "A variável é nula." : "A variável não é nula.";

        Console.WriteLine(resultado);
    }
}
