using System;
using System.ComponentModel.DataAnnotations;

namespace BoletoInter.Models
{
    public class BoletoDesconto
    {
        /*
            Código de Desconto do título.
            NAOTEMDESCONTO - Não tem desconto.
            VALORFIXODATAINFORMADA - Valor fixo até data informada.
            PERCENTUALDATAINFORMADA - Percentual até data informada.
            VALORANTECIPACAODIACORRIDO - Valor por antecipação (dia corrido).
            VALORANTECIPACAODIAUTIL - Valor por antecipação (dia útil).
            PERCENTUALVALORNOMINALDIACORRIDO - Percentual sobre o valor nominal por dia corrido.
            PERCENTUALVALORNOMINALDIAUTIL - Percentual sobre o valor nominal por dia útil.
        */
        [Required]
        public String codigoDesconto { get; set; }

        /*
            Data de Desconto do título.
            Obrigatório para códigos de desconto VALORFIXODATAINFORMADA e PERCENTUALDATAINFORMADA. Não informar para os demais.
            Deve ser vazio ('') para código de desconto NAOTEMDESCONTO.
            Formato: YYYY-MM-DD
        */
        [Required]
        public String data { get; set; }

        /*
            Taxa Percentual de Desconto do título.
            Obrigatório para códigos de desconto PERCENTUALDATAINFORMADA, PERCENTUALVALORNOMINALDIACORRIDO e PERCENTUALVALORNOMINALDIAUTIL.
            Deve ser 0 para código de desconto NAOTEMDESCONTO
        */
        [Required]
        public float taxa { get; set; }

        /*
            Valor de Desconto, expresso na moeda do título.
            Obrigatório para códigos de desconto VALORFIXODATAINFORMADA, VALORANTECIPACAODIACORRIDO e VALORANTECIPACAODIAUTIL
            Deve ser 0 para código de desconto NAOTEMDESCONTO
        */
        [Required]
        public float valor { get; set; }
    }
}
