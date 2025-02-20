using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Almoxarifados
{
    public class AlmoxarifadosDto
    {
        public string? Codigo { get; set; }
        public string? Filial { get; set; }
        public string? Nome { get; set; }
        public double? Ult_Qtd { get; set; }
        public decimal? Ult_Custo { get; set; }
        public bool Almoxarifado_de_Venda { get; set; }
    }
}
