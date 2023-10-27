using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Noticias
{
    public class NoticiaDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public UsuarioDTO Usuario { get; set; }
        public List<NoticiaTagDTO> TagsNoticia { get; set; }
    }
}
