using API.Data;
using API.Interfaces;
using API.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/notas")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        private readonly INotasRepo _notasRepo;
        public NotasController(ApplicationDBContext context, INotasRepo notasRepo)
        {
            _notasRepo = notasRepo;
            _context = context;
        }

        [HttpGet]
        //Chamada utilizando Procedure
        public async Task<IActionResult> spGetNotas()
        {
            var notas = await _notasRepo.GetAllAsync();
            
            var notasDto = notas.Select(s => s.ToNotasDto());

            return Ok(notas);
        }
    }
}
