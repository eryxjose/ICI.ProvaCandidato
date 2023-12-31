﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Nome { get; set; }
        [Required]
        [StringLength(128)]
        public string Senha { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
    }
}
