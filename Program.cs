using System;

namespace Aula8Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();

            visa.limite = 1200;
            visa.valor = 900;

        //Limite é modificado, dando o resultado do limite atual mais o acrescimo    
        System.Console.WriteLine($"Limite do cartão de credito foi modificado para R${visa.AumentarLimite(visa.limite, 300)}");    
        Console.WriteLine();
        System.Console.WriteLine(visa.Pagar(visa.valor));
        Console.WriteLine();
        System.Console.WriteLine($"Um valor de R${visa.valor} foi utilizado!!");
            
        }
    }
}
