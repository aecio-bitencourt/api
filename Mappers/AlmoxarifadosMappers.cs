using API.Dtos.Almoxarifados;
using API.Models;
using System.Runtime.CompilerServices;

namespace API.Mappers
{
    public static class AlmoxarifadosMappers
    {
        public static AlmoxarifadosDto ToAlmoxarifadosDto(this Almoxarifados almoxarifadosModel)
        {
            return new AlmoxarifadosDto
            {
                Codigo = almoxarifadosModel.Codigo,
                Filial = almoxarifadosModel.Filial,
                Nome = almoxarifadosModel.Nome,
                Ult_Qtd = almoxarifadosModel.Ult_Qtd,
                Ult_Custo = almoxarifadosModel.Ult_Custo,
                Almoxarifado_de_Venda = almoxarifadosModel.Almoxarifado_de_Venda
            };

        }
    }
}
