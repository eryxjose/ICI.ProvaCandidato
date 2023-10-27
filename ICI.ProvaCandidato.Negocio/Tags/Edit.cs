using AutoMapper;
using ICI.ProvaCandidato.Dados;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Tags
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Tag Tag { get; set; }
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
                var tag = await _context.Tags.FindAsync(request.Tag.Id);

                _mapper.Map(request.Tag, tag);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
