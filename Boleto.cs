using System;

namespace Aula8Abstração
{
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento;

        public string bancoEmissor { get; set; }

        public string codigoBarras { get; set; }

        public string RegistrarSistema(){
            return "Ação registrado no sistema";
        }
    }
}