using API.Data;
using API.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class NotasRepository : INotasRepo
    {
        private readonly ApplicationDBContext _context;
        public NotasRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        //Consumindo via Procedure
        public Task<List<Notas>> GetAllAsync()
        {
            return _context.Notas
                .FromSqlRaw("EXEC spGetNotas")
                .ToListAsync();
        }
    }
}
