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
                Contabilizacao = notasModel.Contabilizacao,
                Emissao = notasModel.Emissao,
                Total_Nota = notasModel.Total_Nota,
                Descontos = notasModel.Descontos,
                Acrescimos = notasModel.Acrescimos,
                Vendedor = notasModel.Vendedor,
                Pedido = notasModel.Pedido,
                Tipo = notasModel.Tipo,
                Tipo_Nota = notasModel.Tipo_Nota,
                Centro_de_Custo = notasModel.Centro_de_Custo,
                Endereco_Entrega = notasModel.Endereco_Entrega,
                Estado_Entrega = notasModel.Estado_Entrega,
                Cep_Entrega = notasModel.Cep_Entrega,
                Contato = notasModel.Contato,
                Natureza_Operacao = notasModel.Natureza_Operacao,
                Bairro_Entrega = notasModel.Bairro_Entrega,
                Numero_Serie_NotaAtivo = notasModel.Numero_Serie_NotaAtivo,
                Municipio_Entrega = notasModel.Municipio_Entrega,
                NumeroEntrega = notasModel.NumeroEntrega,
                Historico1 = notasModel.Historico1,
                Historico2 = notasModel.Historico2,
                Historico3 = notasModel.Historico3,
                Historico4 = notasModel.Historico4,
                Frete = notasModel.Frete,
                RetencaoCofins = notasModel.RetencaoCofins,
                RetencaoCSll = notasModel.RetencaoCSll,
                RetencaoPis = notasModel.RetencaoPis,
                ValorRetencaoIRRF = notasModel.ValorRetencaoIRRF,
                ValorRetencaoISS = notasModel.ValorRetencaoISS,
                Complemento = notasModel.Complemento,
                Valor_Titulo_COFINS = notasModel.Valor_Titulo_COFINS,
                Valor_Titulo_CSLL = notasModel.Valor_Titulo_CSLL,
                Valor_Titulo_INSS = notasModel.Valor_Titulo_INSS,
                Valor_Titulo_IRRF = notasModel.Valor_Titulo_IRRF,
                Valor_Titulo_PIS = notasModel.Valor_Titulo_PIS,
                Total_Servicos = notasModel.Total_Servicos,
                Total_IPI = notasModel.Total_IPI
            };
        }
    }
}
