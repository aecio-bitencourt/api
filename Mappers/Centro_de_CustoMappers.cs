using API.Dtos.Centro_de_Custo;
using API.Models;
using System.Runtime.CompilerServices;

namespace API.Mappers
{
    public static class Centro_de_CustoMappers
    {
        public static Centro_de_CustoDto ToCentro_de_CustoDto(this Centro_de_Custo Centro_de_CustoModel)
        {
            return new Centro_de_CustoDto
            {
                Codigo = Centro_de_CustoModel.Codigo,
                Nome = Centro_de_CustoModel.Nome
            };

        }
    }
}
