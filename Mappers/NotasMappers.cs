using API.Dtos.Notas;
using API.Models;

namespace API.Mappers
{
    public static class NotasMappers
    {
        public static NotasDto ToNotasDto(this Notas notasModel)
        {
            return new NotasDto
            {
                Nota = notasModel.Nota,
                Filial = notasModel.Filial,
                Almoxarifado = notasModel.Almoxarifado,
                Serie = notasModel.Serie,
                Codigo_Movimentacao = notasModel.Codigo_Movimentacao,
                Cliente_Fornecedor = notasModel.Cliente_Fornecedor,
                Contabilizacao = notasModel.Contabilizacao
            };
        }
    }
}
