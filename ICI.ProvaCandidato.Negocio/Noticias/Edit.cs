using AutoMapper;
using ICI.ProvaCandidato.Dados;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Noticias
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Noticia Noticia { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var noticia = await _context.Noticias.FindAsync(request.Noticia.Id);

                _mapper.Map(request.Noticia, noticia);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
