using System;
using System.Net.Http;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BoletoInter.Helpers;
using BoletoInter.Models;
using Newtonsoft.Json;

namespace BoletoInter.Services
{
    public class BoletoService
    {
        public async Task<BoletoResponse> CadastrarBoleto(Boleto dados)
        {
            try
            {
                Boleto boleto = new Boleto();
                BoletoResponse response = new BoletoResponse();

                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.SslProtocols = SslProtocols.Tls12;
                handler.ClientCertificates.Add(new X509Certificate2("/opt/mck2.com.br.pfx", "<senha_certificado>"));

                var client = new HttpClient(handler);

                client.DefaultRequestHeaders.Add("accept", "application/json");
                client.DefaultRequestHeaders.Add("x-inter-conta-corrente", "<conta_bancaria>");

                // @TODO: Implementar validações do objeto vindo do request
                // boleto = (dados == null) ? geraBoletoDemo() : dados;
                boleto = BoletoTeste.geraBoletoDemo();

                var result = await client.PostAsync("https://apis.bancointer.com.br/openbanking/v1/certificado/boletos", new StringContent(JsonConvert.SerializeObject(boleto), Encoding.UTF8, "application/json"));

                response = JsonConvert.DeserializeObject<BoletoResponse>(result.Content.ReadAsStringAsync().Result);

                return response;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<BoletoDetalhamento> obterPorNossoNumero(String nossoNumero)
        {
            try
            {
                BoletoDetalhamento response = new BoletoDetalhamento();

                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.SslProtocols = SslProtocols.Tls12;
                handler.ClientCertificates.Add(new X509Certificate2("/opt/mck2.com.br.pfx", "<senha_certificado>"));

                var client = new HttpClient(handler);

                client.DefaultRequestHeaders.Add("accept", "application/json");

                client.DefaultRequestHeaders.Add("x-inter-conta-corrente", "<conta_bancaria>");

                var result = await client.GetAsync($"https://apis.bancointer.com.br/openbanking/v1/certificado/boletos/{nossoNumero}");

                response = JsonConvert.DeserializeObject<BoletoDetalhamento>(result.Content.ReadAsStringAsync().Result);

                return response;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<String> gerarPdf(String nossoNumero)
        {
            try
            {
                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.SslProtocols = SslProtocols.Tls12;
                handler.ClientCertificates.Add(new X509Certificate2("/opt/mck2.com.br.pfx", "<senha_certificado>"));

                var client = new HttpClient(handler);

                client.DefaultRequestHeaders.Add("x-inter-conta-corrente", "<conta_bancaria>");

                var result = await client.GetAsync($"https://apis.bancointer.com.br/openbanking/v1/certificado/boletos/{nossoNumero}/pdf");

                return result.Content.ReadAsStringAsync().Result;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
