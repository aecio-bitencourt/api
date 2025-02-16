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
    }
}
