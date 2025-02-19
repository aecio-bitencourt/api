using API.Models;

namespace API.Interfaces
{
    public interface IAlmoxarifadosRepo
    {
        Task<List<Almoxarifados>> GetAllAsync();
    }
}
