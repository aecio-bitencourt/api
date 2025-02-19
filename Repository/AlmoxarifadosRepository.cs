using API.Data;
using API.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class AlmoxarifadosRepository : IAlmoxarifadosRepo
    {
        private readonly ApplicationDBContext _context;
        public AlmoxarifadosRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public Task<List<Almoxarifados>> GetAllAsync()
        {
            return _context.Almoxarifados
                .FromSqlRaw("EXEC spGetNotas")
                .ToListAsync();
        }
    }
}
