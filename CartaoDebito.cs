namespace Aula8Abstração
{
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }

        public string TransferirValor(){
            return "Valor transferido com sucesso";
        }

        public string PagarTitulo(){
            return "Titulo pago!";
        }
    }
}