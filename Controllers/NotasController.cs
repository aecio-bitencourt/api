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

        private readonly IOperacoesRepo _operacoesRepo;

        public NotasController(ApplicationDBContext context, IOperacoesRepo operacoesRepo)
        {
            _operacoesRepo = operacoesRepo;
            _context = context;
        }

        [HttpGet("{rota}")]
        //Chamada utilizando Procedure
        public async Task<IActionResult> spGetNotas(string rota)
        {
            if (rota.ToLower() != "notas" && rota.ToLower() != "almoxarifados")
                return BadRequest();

            var notas = await _notasRepo.GetAllAsync();
            
            var notasDto = notas.Select(s => s.ToNotasDto());

            return Ok(notas);
        }
    }
}
