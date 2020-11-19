using System;
using System.ComponentModel.DataAnnotations;

namespace BoletoInter.Models
{
    public class BoletoMulta
    {
        /*
            Código de Multa do título.
            NAOTEMMULTA - Não tem multa
            VALORFIXO – Valor Fixo
            PERCENTUAL - Percentual
        */
        [Required]
        public String codigoMulta { get; set; }

        /*
            Data da Multa do título.
            Obrigatório se informado código de multa VALORFIXO ou PERCENTUAL.
            Deve ser maior que o vencimento e marca a data de início de cobrança de multa (incluindo essa data).
            Formato: YYYY-MM-DD
        */
        public String data { get; set; }

        /*
            Taxa Percentual de Multa do título. 
            Obrigatória se informado código de multa PERCENTUAL
        */
        public float taxa { get; set; }

        /*
            Valor de Multa expresso na moeda do título.
            Obrigatório se informado código de multa VALORFIXO
        */
        public float valor { get; set; }
    }
}
