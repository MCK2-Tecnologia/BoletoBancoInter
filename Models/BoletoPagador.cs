using System;
using System.ComponentModel.DataAnnotations;

namespace BoletoInter.Models
{
    public class BoletoPagador
    {
        /*
            Tipo da Pessoa: FISICA ou JURIDICA
        */
        [Required]
        [MaxLength(8)]
        public String tipoPessoa { get; set; }

        /*
            Nome da pessoa
            Tamanho máximo: 100
        */
        [Required]
        [MaxLength(100)]
        public String nome { get; set; }

        /*
            Endereço da pessoa
            Tamanho máximo: 90
        */
        [Required]
        [MaxLength(90)]
        public String endereco { get; set; }

        /*
            Número do endereço da pessoa
            Tamanho máximo: 10
        */
        [Required]
        [MaxLength(10)]
        public String numero { get; set; }

        /*
            Complemento do endereço da pessoa
            Tamanho máximo: 30
        */
        [MaxLength(30)]
        public String complemento { get; set; }

        /*
            Bairro da pessoa
            Tamanho máximo: 60
        */
        [Required]
        [MaxLength(60)]
        public String bairro { get; set; }

        /*
            Cidade da pessoa
            Tamanho máximo: 60
        */
        [Required]
        [MaxLength(60)]
        public String cidade { get; set; }

        /*
            UF da pessoa
        */
        [Required]
        [MaxLength(2)]
        public String uf { get; set; }

        /*
            CEP da pessoa
            Tamanho: 8
        */
        [Required]
        [MaxLength(8)]
        public String cep { get; set; }

        /*
            CPF/CNPJ do pagador do título CNPJ:
            CNPJ: NNNNNNNNNFFFFCC
            CPF : 0000NNNNNNNNNCC,
            Onde NNNNNNNNN é a raiz do CNPJ/CPF FFFF = filial do CNPJ CC = dígitos de controle
            Tamanho máximo: 15
        */
        [Required]
        [MaxLength(15)]
        public String cnpjCpf { get; set; }

        /*
            E-mail da pessoa
            Tamanho máximo: 50
        */
        [MaxLength(50)]
        public String email { get; set; }

        /*
            DDD do telefone da pessoa
            Tamanho: 2
        */
        [MaxLength(2)]
        public String ddd { get; set; }

        /*
            Telefone da pessoa
            Tamanho máximo: 9
        */
        [MaxLength(9)]
        public String telefone { get; set; }
    }
}
