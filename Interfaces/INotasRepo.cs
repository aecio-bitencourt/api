using API.Models;

namespace API.Interfaces
{
    public interface INotasRepo
    {
        Task<List<Notas>> GetAllAsync();
    }
}
