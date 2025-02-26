using API.Models;

namespace API.Interfaces
{
    public interface IOperacoesRepo
    {
        Task<List<Almoxarifados>> GetAlmoxarifados();
        Task<List<Notas>> GetNotas();
    }
}
