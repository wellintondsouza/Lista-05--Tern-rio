using System;

class Program
{
    static void Main()
    {
        string texto = null;  // Podemos mudar o valor para testar e assim o sistema identifica que a variável não é nula. string texto = "Palavra";

        // Verificando se a variável é nula com operador ternário
        string resultado = (texto == null) ? "A variável é nula." : "A variável não é nula.";

        Console.WriteLine(resultado);
        Console.ReadKey();
    }
}
