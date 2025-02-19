using API.Data;
using API.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class OperacoesRepository : IOperacoesRepo
    {
        private readonly ApplicationDBContext _context;
        public OperacoesRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public Task<List<Almoxarifados>> GetAlmoxarifados()
        {
            return _context.Almoxarifados
                .FromSqlRaw("EXEC spGetDados @Tipo = {rota}")
                .ToListAsync();
        }
        public Task<List<Notas>> GetNotas()
        {
            return _context.Notas
                .FromSqlRaw("EXEC spGetDados @Tipo = {rota}")
                .ToListAsync();
        }
    }
}
