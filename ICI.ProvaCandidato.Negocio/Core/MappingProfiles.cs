﻿using ICI.ProvaCandidato.Dados;
using ICI.ProvaCandidato.Negocio.Noticias;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Core
{
    public class MappingProfiles : AutoMapper.Profile
    {
        public MappingProfiles()
        {
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<NoticiaTag, NoticiaTagDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Tag.Descricao)); ;
            CreateMap<Tag, NoticiaTagDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Descricao));

            CreateMap<Noticia, NoticiaDTO>()
                .ForMember(dest => dest.Usuario, opt => opt.MapFrom(src => src.Usuario)) // Mapeamento do usuário
                .ForMember(dest => dest.TagsNoticia, opt => opt.MapFrom(src => src.TagsNoticia)); // Mapeamento das tags

        }
    }
}