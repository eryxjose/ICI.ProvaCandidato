﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Descricao { get; set; }
    }
}
