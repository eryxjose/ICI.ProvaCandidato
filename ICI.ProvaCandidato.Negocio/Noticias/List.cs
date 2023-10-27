using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using ICI.ProvaCandidato.Dados;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Microsoft.Extensions.Logging;
using System.Linq;
using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace ICI.ProvaCandidato.Negocio.Noticias
{
    public class List
    {
        public class Query : IRequest<List<NoticiaDTO>>
        {
            private readonly DataContext _context;
        }

        public class Handler : IRequestHandler<Query, List<NoticiaDTO>>
        {
            private readonly DataContext _context;
            private readonly ILogger<List> _logger;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper, ILogger<List> logger)
            {
                _logger = logger;
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<NoticiaDTO>> Handle(Query request, CancellationToken cancellationToken)
            {
                var noticiasDTO = await _context.Noticias
                    .Include(n => n.Usuario)
                    .Include(n => n.TagsNoticia)
                    .ProjectTo<NoticiaDTO>(_mapper.ConfigurationProvider)
                    .ToListAsync();

                return noticiasDTO;
            }
        }
    }
}
