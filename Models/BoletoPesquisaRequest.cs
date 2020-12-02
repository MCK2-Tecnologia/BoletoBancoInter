using System;

namespace BoletoInter.Models
{
    public class BoletoPesquisaRequest
    {
        /*
            Situação atual do boleto para filtro.
            Valores
                Nome: TODOS (Default)
                Descrição: Todos os títulos do cliente no período.
                Nome: VENCIDOSAVENCER
                Descrição: Todos os títulos a vencer/vencidos do cliente no período.
                Nome: EXPIRADOS
                Descrição: Todos os títulos expirados (não passível de pagamento) no período.
                Nome: PAGOS
                Descrição: Todos os títulos pagos em condições normais do cliente no período.
                Nome: TODOSBAIXADOS
                Descrição: Todas as demais baixas do cliente no período.
        */
        public String filtrarPor { get; set; }

        /*
            Data para filtro.
            Valores
                Nome: VENCIMENTO (Default)
                Descrição: Filtro de data (inicial e final) pelo vencimento.
                Nome: EMISSAO
                Descrição: Filtro de data (inicial e final) pela emissão.
                Nome: SITUACAO
                Descrição: Filtro de data (inicial e final) pela última situação.
                Exemplo:
                Caso filtrarPor seja PAGOS as datas corresponderão a data de pagamento dos boletos;
                Caso filtrarPor seja EXPIRADOS as datas corresponderão a data de expiração dos boletos;
                Caso filtrarPor seja VENCIDOSAVENCER as datas corresponderão a data de boletos EMABERTO ou VENCIDO (passíveis de pagamento);
                Caso filtrarPor seja TODOSBAIXADOS as datas corresponderão a data de baixa dos boletos;
        */
        public String filtrarDataPor { get; set; }

        /*
            Data início para o filtro (referente ao campo filtrarDataPor).
            Formato: YYYY-MM-DD
        */
        public String dataInicial { get; set; }

        /*
            Data fim para o filtro (referente ao campo filtrarDataPor).
            Formato: YYYY-MM-DD
        */
        public String dataFinal { get; set; }

        /*
            Ordenação do retorno da consulta:
            Valores:
                Nome: NOSSONUMERO (Default)
                Descrição: Nosso Número.
                Nome: SEUNUMERO
                Descrição: Seu Número.
                Nome: DATAVENCIMENTO_ASC
                Descrição: Data de Vencimento crescente.
                Nome: DATAVENCIMENTO_DSC
                Descrição: Data de Vencimento decrescente.
                Nome: NOMESACADO
                Descrição: Nome do Sacado.
                Nome: VALOR_ASC
                Descrição: Valor do Título crescente.
                Nome: VALOR_DSC
                Descrição: Valor do Título decrescente.
                Nome: STATUS_ASC
                Descrição: Status do Título crescente.
                Nome: STATUS_DSC
                Descrição: Status do Título decrescente.
        */
        public String ordenarPor { get; set; }

        /*
            Número da página.
            Página inicial possui o valor 0
        */
        public Int32 page { get; set; }

        /*
            Tamanho da página.
            Tamanho máximo é 20
        */
        public Int32 size { get; set; }
    }
}
