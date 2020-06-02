namespace Aula8Abstração
{
    public class Cartao : Pagamento
    {
        public string bandeira { get; set; }

        public int numero { get; set; }

        public string titular { get; set; }

        public string cvv { get; set; }

        private string token = "ddwnjiffvsdfsdffdb";

        public bool ValidarToken(){
            if(token != null && token == ""){
                return true;
            }
            return false;
        }
    
    }
}