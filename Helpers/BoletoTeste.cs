
using System;
using BoletoInter.Models;

namespace BoletoInter.Helpers
{
    public static class BoletoTeste
    {

        public static Boleto geraBoletoDemo()
        {
            Boleto boleto = new Boleto();

            //Raiz Boleto
            //boleto.seuNumero = Convert.ToString(new Random().Next());
            boleto.seuNumero = "1";
            boleto.cnpjCPFBeneficiario = "89942965000107"; //INFORME O CNPJ DA SUA EMPRESA
            boleto.dataEmissao = DateTime.Now.ToString("yyyy-MM-dd");
            boleto.dataVencimento = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd");
            boleto.numDiasAgenda = "TRINTA";
            boleto.valorNominal = 10.15f;
            boleto.valorAbatimento = 2.10f;
            //Pagador (DADOS DO CLIENTE)
            boleto.pagador = new BoletoPagador();
            boleto.pagador.tipoPessoa = "FISICA";
            boleto.pagador.nome = "Moacir Carlos Kurmann";
            boleto.pagador.endereco = "QNL 50 Bloco h Apartamento";
            boleto.pagador.numero = "500";
            boleto.pagador.complemento = "Ed. Teste";
            boleto.pagador.bairro = "Taguatinga Norte";
            boleto.pagador.cidade = "Brasília";
            boleto.pagador.uf = "DF";
            boleto.pagador.cep = "72152310";
            boleto.pagador.cnpjCpf = "25647766048";
            boleto.pagador.email = "moacir@mck2.com.br";
            boleto.pagador.telefone = "999999999";
            //Mensagens
            boleto.mensagem = new BoletoMensagem();
            boleto.mensagem.linha1 = "Mensagem da linha 1";
            boleto.mensagem.linha2 = "Mensagem da linha 2";
            boleto.mensagem.linha3 = "Mensagem da linha 3";
            boleto.mensagem.linha4 = "Mensagem da linha 4";
            boleto.mensagem.linha5 = "Mensagem da linha 5";
            //Desconto 1
            boleto.desconto1 = new BoletoDesconto();
            boleto.desconto1.codigoDesconto = "NAOTEMDESCONTO";
            boleto.desconto1.data = String.Empty;
            boleto.desconto1.taxa = 0f;
            boleto.desconto1.valor = 0f;
            //Desconto 2
            boleto.desconto2 = new BoletoDesconto();
            boleto.desconto2.codigoDesconto = "NAOTEMDESCONTO";
            boleto.desconto2.data = String.Empty;
            boleto.desconto2.taxa = 0f;
            boleto.desconto2.valor = 0f;
            //Desconto 3
            boleto.desconto3 = new BoletoDesconto();
            boleto.desconto3.codigoDesconto = "NAOTEMDESCONTO";
            boleto.desconto3.data = String.Empty;
            boleto.desconto3.taxa = 0f;
            boleto.desconto3.valor = 0f;
            //Multa
            boleto.multa = new BoletoMulta();
            boleto.multa.codigoMulta = "VALORFIXO";
            boleto.multa.data = DateTime.Now.AddDays(8).ToString("yyyy-MM-dd");
            boleto.multa.valor = 5.5f;
            //Mora
            boleto.mora = new BoletoMora();
            boleto.mora.codigoMora = "TAXAMENSAL";
            boleto.mora.data = DateTime.Now.AddDays(8).ToString("yyyy-MM-dd");
            boleto.mora.taxa = 2f;

            return boleto;
        }
    }
}
