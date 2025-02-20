using API.Models;

namespace API.Interfaces
{
    public interface IOperacoesRepo
    {
        Task<(List<Notas>, List<Almoxarifados>)> GetTodas();
    }
}
