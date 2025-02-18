using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Notas
{
    public class NotasDto
    {
        public string? Nota { get; set; }
        public string? Filial { get; set; }
        public string? Almoxarifado { get; set; }
        public string? Serie { get; set; }
        public string? Codigo_Movimentacao { get; set; }
        public string? Cliente_Fornecedor { get; set; }
        public DateTime Contabilizacao { get; set; }
        public DateTime Emissao { get; set; }
        public decimal Total_Nota { get; set; }
        public decimal Descontos { get; set; }
        public decimal Acrescimos { get; set; }
        public string? Vendedor { get; set; }
        public string? Pedido { get; set; }
        public string? Tipo { get; set; }
        public string? Tipo_Nota { get; set; }
        public string? Centro_de_Custo { get; set; }
        public string? Endereco_Entrega { get; set; }
        public string? Estado_Entrega { get; set; }
        public string? Cep_Entrega { get; set; }
        public string? Contato { get; set; }
        public string? Natureza_Operacao { get; set; }
        public string? Bairro_Entrega { get; set; }
        public string? Numero_Serie_NotaAtivo { get; set; }
        public string? Municipio_Entrega { get; set; }
        public string? NumeroEntrega { get; set; }
        public string? Historico1 { get; set; }
        public string? Historico2 { get; set; }
        public string? Historico3 { get; set; }
        public string? Historico4 { get; set; }
        public decimal? Frete { get; set; }
        public decimal? RetencaoCofins { get; set; }
        public decimal? RetencaoCSll { get; set; }
        public decimal? RetencaoPis { get; set; }
        public decimal? ValorRetencaoIRRF { get; set; }
        public decimal? ValorRetencaoISS { get; set; }
        public string? Complemento { get; set; }
        public decimal? Valor_Titulo_COFINS { get; set; }
        public decimal? Valor_Titulo_CSLL { get; set; }
        public decimal? Valor_Titulo_INSS { get; set; }
        public decimal? Valor_Titulo_IRRF { get; set; }
        public decimal? Valor_Titulo_PIS { get; set; }
        public decimal? Total_Servicos { get; set; }
        public decimal? Total_IPI { get; set; }
    }
}
