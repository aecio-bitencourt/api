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
    }
}
