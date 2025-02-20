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
        public async Task<(List<Notas>, List<Almoxarifados>)> GetTodas()
        {
            var notas = await _context.Notas
                .FromSqlRaw("EXEC spGetAPIOperacoes @rota = {0}", "notas")
                .ToListAsync();

            var almoxarifados = await _context.Almoxarifados
                .FromSqlRaw("EXEC spGetAPIOperacoes @rota = {0}", "almoxarifados")
                .ToListAsync();

            return (notas, almoxarifados);
        }
    }
}
