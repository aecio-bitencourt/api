using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Notas
    {
        // Primary Key
        [Key]
        [Column(TypeName = "string(9)")]
        public string? Nota { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Filial { get; set; }
        
        [Column(TypeName = "string(3)")]
        public string? Almoxarifado { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Serie { get; set; }
        
        [Column(TypeName = "string(3)")]
        public string? Codigo_Movimentacao { get; set; }

        [Column(TypeName = "string(5)")]
        public string? Cliente_Fornecedor  { get; set; }

        public DateTime Contabilizacao { get; set; }

        public DateTime Emissao { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal? Total_Nota { get; set; }
        
        [Column(TypeName = "decimal(9,2")]
        public decimal? Descontos { get; set; }
        
        [Column(TypeName = "decimal(9,2")]
        public decimal? Acrescimos { get; set; }
        
        [Column(TypeName = "string(3)")]
        public string? Vendedor { get; set; }
        
        [Column(TypeName = "string(10)")]
        public string? Pedido { get; set; }

        [Column(TypeName = "string(1)")]
        public string? Tipo { get; set; }

        [Column(TypeName = "string(1)")]
        public string? Tipo_Nota { get; set; }

        [Column(TypeName = "string(10)")]
        public string? Centro_de_Custo { get; set; }

        [Column(TypeName = "string(35)")]
        public string? Endereco_Entrega { get; set; }

        [Column(TypeName = "string(2)")]
        public string? Estado_Entrega { get; set; }

        [Column(TypeName = "string(9)")]
        public string? Cep_Entrega { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Contato { get; set; }

        [Column(TypeName = "string(9)")]
        public string? Natureza_Operacao { get; set; }

        [Column(TypeName = "string(30)")]
        public string? Bairro_Entrega { get; set; }

        [Column(TypeName = "string(30)")]
        public string? Numero_Serie_NotaAtivo { get; set; }

        [Column(TypeName = "string(255)")]
        public string? Municipio_Entrega { get; set; }

        [Column(TypeName = "string(50)")]
        public string? NumeroEntrega { get; set; }

        [Column(TypeName = "string(100)")]
        public string? Historico1 { get; set; }

        [Column(TypeName = "string(100)")]
        public string? Historico2 { get; set; }

        [Column(TypeName = "string(100)")]
        public string? Historico3 { get; set; }

        [Column(TypeName = "string(100)")]
        public string? Historico4 { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal? Frete { get; set; }
        
        /* Confirmar com a Edneia
        [Column(TypeName = "int(100)")]
        public int? Retencao_INSS { get; set; }
        */

        [Column(TypeName = "decimal(9,2)")]
        public decimal? RetencaoCofins { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal? RetencaoCSll { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal? RetencaoPis { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal? ValorRetencaoIRRF { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal? ValorRetencaoISS { get; set; }

        [Column(TypeName = "string")]
        public string? Complemento { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal? Valor_Titulo_COFINS { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal? Valor_Titulo_CSLL { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal? Valor_Titulo_INSS { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal? Valor_Titulo_IRRF { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal? Valor_Titulo_PIS { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal? Total_Servicos { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal? Total_IPI { get; set; }

    }
}
