using System;
using System.ComponentModel.DataAnnotations;

namespace BoletoInter.Models
{
    public class BoletoMensagem
    {
        /*
            Linha 1 do campo de texto do título
            Tamanho máximo: 78
        */
        [MaxLength(78)]
        public String linha1 { get; set; }

        /*
            Linha 2 do campo de texto do título
            Tamanho máximo: 78
        */
        [MaxLength(78)]
        public String linha2 { get; set; }

        /*
            Linha 3 do campo de texto do título
            Tamanho máximo: 78
        */
        [MaxLength(78)]
        public String linha3 { get; set; }

        /*
            Linha 4 do campo de texto do título
            Tamanho máximo: 78
        */
        [MaxLength(78)]
        public String linha4 { get; set; }

        /*
            Linha 5 do campo de texto do título
            Tamanho máximo: 78
        */
        [MaxLength(78)]
        public String linha5 { get; set; }
    }
}
