using System;
using System.ComponentModel.DataAnnotations;

namespace BoletoInter.Models
{
    public class Boleto
    {
        /*
            Campo Seu Número do título
            Tamanho máximo: 15
        */
        [Required]
        [MaxLength(15)]
        public String seuNumero { get; set; }

        /*
            CPF/CNPJ do beneficiário do título
            CNPJ: NNNNNNNNNFFFFCC
            CPF : 0000NNNNNNNNNCC,
            Onde NNNNNNNNN é a raiz do CNPJ/CPF FFFF = filial do CNPJ CC = dígitos de controle
            Tamanho máximo: 15
        */
        [Required]
        [MaxLength(15)]
        public String cnpjCPFBeneficiario { get; set; }

        /*
            Valor Nominal do título
        */
        [Required]
        public float valorNominal { get; set; }

        /*
            Valor de abatimento do título, expresso na mesma moeda do Valor Nominal
        */
        public float valorAbatimento { get; set; }
        
        /*
            Data de emissão do título.
            Formato: YYYY-MM-DD
        */
        [Required]
        public String dataEmissao { get; set; }

        /*
            Data de vencimento do título.
            Formato: YYYY-MM-DD
        */
        [Required]
        public String dataVencimento { get; set; }

        /*
            Numero de dias corridos após o vencimento para baixa efetiva automática do boleto.
            Valores: (TRINTA, SESSENTA)
        */
        [Required]
        [MaxLength(8)]
        public string numDiasAgenda { get; set; }

        /*
            Informações da pessoa pagadora
        */
        [Required]
        public BoletoPagador pagador { get; set; }

        public BoletoMensagem mensagem { get; set; }

        [Required]
        public BoletoDesconto desconto1 { get; set; }

        [Required]
        public BoletoDesconto desconto2 { get; set; }

        [Required]
        public BoletoDesconto desconto3 { get; set; }

        [Required]
        public BoletoMulta multa { get; set; }

        [Required]
        public BoletoMora mora { get; set; }
    }
}
