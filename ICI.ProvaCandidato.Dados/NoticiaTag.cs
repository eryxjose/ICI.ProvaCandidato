﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados
{
    public class NoticiaTag
    {
        public int Id { get; set; }
        public int NoticiaId { get; set; }
        public virtual Noticia Noticia { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
