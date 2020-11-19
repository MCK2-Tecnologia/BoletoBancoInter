using System;
using System.ComponentModel.DataAnnotations;

namespace BoletoInter.Models
{
    public class BoletoMora
    {
        /*
            Código de Mora do título.
            VALORDIA - Valor ao dia
            TAXAMENSAL - Taxa mensal
            ISENTO - Não há mora
        */
        [Required]
        public String codigoMora { get; set; }

        /*
            Data da Mora do título.
            Obrigatório se informado código de mora VALORDIA ou TAXAMENSAL.
            Deve ser maior que o vencimento e marca a data de início de cobrança de mora (incluindo essa data).
            Formato: YYYY-MM-DD
        */
        public String data { get; set; }

        /*
            Percentual de Mora do título.
            Obrigatória se informado código de mora TAXAMENSAL
        */
        public float taxa { get; set; }

        /*
            Valor de Mora expresso na moeda do título.
            Obrigatório se informado código de mora VALORDIA
        */
        public float valor { get; set; }
    }
}
