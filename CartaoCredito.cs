namespace Aula8Abstração
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }

        public float AumentarLimite(float limite, float acrescimo){
            return limite + acrescimo;
        }

        public string Bloquear(){
            return "Seu cartao foi bloqueado";
        }
    }
}