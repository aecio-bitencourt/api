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
        public decimal Total_Nota { get; set; }

    }
}
