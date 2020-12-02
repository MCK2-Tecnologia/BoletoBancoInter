using System;
using System.ComponentModel.DataAnnotations;

namespace BoletoInter.Models
{
    public class BoletoBaixa
    {
        /*
            Número identificador do título.
        */
        [Required]
        public String nossoNumero { get; set; }

        /*
            Domínio que descreve o tipo de baixa sendo solicitado.
            ACERTOS - Baixa por acertos
            PROTESTADO - Baixado por ter sido protestado
            DEVOLUCAO - Baixado para devolução
            PROTESTOAPOSBAIXA - Baixado por protesto após baixa
            PAGODIRETOAOCLIENTE - Baixado, pago direto ao cliente
            SUBISTITUICAO - Baixado por substituição
            FALTADESOLUCAO - Baixado por falta de solução
            APEDIDODOCLIENTE - Baixado a pedido do cliente
        */
        [Required]
        public String codigoBaixa { get; set; }
    }
}
