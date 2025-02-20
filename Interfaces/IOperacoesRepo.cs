using API.Models;

namespace API.Interfaces
{
    public interface IOperacoesRepo
    {
        Task<List<Almoxarifados>> GetAlmoxarifados();
        Task<List<Notas>> GetNotas();
        Task<List<Centro_de_Custo>> GetCentro_de_Custo();
    }
}
