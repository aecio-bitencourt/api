using API.Interfaces;
using API.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/operacoes")]
    [ApiController]
    public class OperacoesController : ControllerBase
    {
        private readonly IOperacoesRepo _operacoesRepo;

        public OperacoesController(IOperacoesRepo operacoesRepo)
        {
            _operacoesRepo = operacoesRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var (notas, almoxarifados) = await _operacoesRepo.GetTodas();

            var valorRota = new
            {
                Notas = notas.Select(n => n.ToNotasDto()),
                Almoxarifados = almoxarifados.Select(a => a.ToAlmoxarifadosDto())
            };
            return Ok(valorRota);
        }
    }
}
