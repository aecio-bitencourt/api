﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Notas
{
    public class NotasDto
    {
        public string? Nota { get; set; }
      
        public string? Filial { get; set; }

        public string? Almoxarifado { get; set; }
        public string? Serie { get; set; }

    }
}
