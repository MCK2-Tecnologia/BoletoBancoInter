using System;

namespace BoletoInter.Models
{
    public class BoletoResponse : BoletoResponseMensagem
    {
        public String seuNumero { get; set; }

        public String nossoNumero { get; set; }

        public String codigoBarras { get; set; }

        public String linhaDigitavel { get; set; }
    }
}
