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
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"almoxarifados"}")
                .ToListAsync();
        }
        public Task<List<Notas>> GetNotas()
        {
            return _context.Notas
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"notas"}")
                .ToListAsync();
        }
        public Task<List<Centro_de_Custo>> GetCentro_de_Custo()
        {
            return _context.Centro_de_Custo
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"Centro_de_Custo"}")
                .ToListAsync();
        }
    }
}
