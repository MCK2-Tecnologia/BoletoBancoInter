using System;
using System.ComponentModel.DataAnnotations;

namespace BoletoInter.Models
{
    public class BoletoDetalhamento
    {
        public String nomeBeneficiario { get; set; }
        public String cnpjCpfBeneficiario { get; set; }
        public String tipoPessoaBeneficiario { get; set; }
        public String dataHoraSituacao { get; set; }
        public String codigoBarras { get; set; }
        public String linhaDigitavel { get; set; }
        public String dataVencimento { get; set; }
        public String dataEmissao { get; set; }
        public String seuNumero { get; set; }
        public float valorNominal { get; set; }
        public String nomePagador { get; set; }
        public String emailPagador { get; set; }
        public String dddPagador { get; set; }
        public String telefonePagador { get; set; }
        public String tipoPessoaPagador { get; set; }
        public String cnpjCpfPagador { get; set; }
        public String codigoEspecie { get; set; }
        public String dataLimitePagamento { get; set; }
        public float valorAbatimento { get; set; }
        public String situacao { get; set; }
        public BoletoMensagem mensagem { get; set; }
        public BoletoDesconto desconto1 { get; set; }
        public BoletoDesconto desconto2 { get; set; }
        public BoletoDesconto desconto3 { get; set; }
        public BoletoMulta multa { get; set; }
        public BoletoMora mora { get; set; }
    }
}
