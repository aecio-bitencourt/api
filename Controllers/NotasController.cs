using API.Data;
using API.Interfaces;
using API.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace API.Controllers
{
    [Route("api/notas")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        private readonly INotasRepo _notasRepo;

        private readonly IAlmoxarifadosRepo _almoxarifadosRepo;
        public NotasController(ApplicationDBContext context, INotasRepo notasRepo, IAlmoxarifadosRepo almoxarifadosRepo)
        {
            _notasRepo = notasRepo;
            _context = context;
            _almoxarifadosRepo = almoxarifadosRepo;
        }

        [HttpGet("{rota}")]
        //Chamada utilizando Procedure
        public async Task<IActionResult> spGetNotas(string rota)
        {
            if (rota.ToLower() != "notas" && rota.ToLower() != "almoxarifados")
                return BadRequest();

            /*
            var notas = await _notasRepo.GetAllAsync();
            
            var notasDto = notas.Select(s => s.ToNotasDto());

            return Ok(notas);
            */
        }
        /*
        [HttpGet("almoxarifados")]
        public async Task<IActionResult> spGetAlmoxarifados()
        {
            var almoxarifados = await _almoxarifadosRepo.GetAllAsync();

            var almoxarifadosDto = almoxarifados.Select(s => s.ToAlmoxarifadosDto());

            return Ok(almoxarifados);
        */
        }
    }
}
