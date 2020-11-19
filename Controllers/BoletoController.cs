using System;
using System.Collections.Generic;
using System.Linq;
using BoletoInter.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BoletoInter.Services;
using System.IO;

namespace BoletoInter.Controllers
{
    [ApiController]
    [Route("boleto")]
    public class BoletoController : ControllerBase
    {
        private readonly BoletoService _boletoService;

        public BoletoController(BoletoService boletoService)
        {
            _boletoService = boletoService;
        }

        [Route("{nossoNumero}")]
        [HttpGet]
        public async Task<BoletoDetalhamento> obterPorNossoNumero(String nossoNumero)
        {
            return await _boletoService.obterPorNossoNumero(nossoNumero);
        }

        [Route("{nossoNumero}/pdf")]
        [HttpGet]
        public async Task<IActionResult> gerarPdf(String nossoNumero)
        {
            String base64 = await _boletoService.gerarPdf(nossoNumero);
            
            MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64));

            return File(ms, "pplication/pdf", "Boleto.pdf");
        }

        [Route("cadastro")]
        [HttpPost]
        public async Task<ActionResult<BoletoResponse>> CadastraBoleto(Boleto dados)
        {
            return await _boletoService.CadastrarBoleto(dados);
        }
    }
}
