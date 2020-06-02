using System;

namespace Aula8Abstração
{
    public class Pagamento
    {
       public DateTime data { get; set; }

       public float valor  { get; set; }

       public string Pagar(float valor){
           return "Valor pago!!";
       }

      public string CancelarCartao(){
          return "Seu cartão cancelado";
      }

    }
}