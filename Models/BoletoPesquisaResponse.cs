using System;
using System.Collections.Generic;

namespace BoletoInter.Models
{
    public class BoletoPesquisaResponse
    {
        public Int32 totalPages { get; set; }
        public Int32 totalElements { get; set; }
        public Int32 numberOfElements { get; set; }
        public Boolean last { get; set; }
        public Boolean first { get; set; }
        public Int32 size { get; set; }
        public BoletoPesquisaResponseSummary summary { get; set; }
        public List<BoletoPesquisaResponseBoleto> content { get; set; }
    }

    public class BoletoPesquisaResponseSummary
    {
        public BoletoPesquisaResponseSummaryItem recebidos { get; set; }

        public BoletoPesquisaResponseSummaryItem previstos { get; set; }

        public BoletoPesquisaResponseSummaryItem baixados { get; set; }

        public BoletoPesquisaResponseSummaryItem expirados { get; set; }
    }

    public class BoletoPesquisaResponseSummaryItem
    {
        public Int32 quantidade { get; set; }

        public float valor { get; set; }
    }

    public class BoletoPesquisaResponseBoleto
    {
        public String nossoNumero { get; set; }
        public String seuNumero { get; set; }
        public String cnpjCpfSacado { get; set; }
        public String nomeSacado { get; set; }
        public String situacao { get; set; }
        public String dataPagtoBaixa { get; set; }
        public String dataVencimento { get; set; }
        public float valorAbatimento { get; set; }
        public float valorNominal { get; set; }
        public String telefone { get; set; }
        public String email { get; set; }
        public String dataEmissao { get; set; }
        public String dataLimite { get; set; }
        public String linhaDigitavel { get; set; }
        public float valorJuros { get; set; }
        public float valorMulta { get; set; }
        public BoletoDesconto desconto1 { get; set; }
        public BoletoDesconto desconto2 { get; set; }
        public BoletoDesconto desconto3 { get; set; }
        public BoletoMulta multa { get; set; }
        public BoletoMora mora { get; set; }
    }
}
