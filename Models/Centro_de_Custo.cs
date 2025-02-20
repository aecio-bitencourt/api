using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Centro_de_Custo
    {
        [Key]
        [Column(TypeName = "string(8)")]
        public string? Codigo { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Nome { get; set; }
    }
}