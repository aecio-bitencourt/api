using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Almoxarifados
    {
        [Key]
        [Column(TypeName = "string(3)")]
        public string? Codigo { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Filial { get; set; }

        [Column(TypeName = "string(40)")]
        public string? Nome { get; set; }

        [Column(TypeName = "float(1)")]
        public float? Ult_Qtd { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal Ult_Custo { get; set; }
        public int Almoxarifado_de_Venda { get; set; }
    }
}
