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
    public class Create
    {
        public class Command : IRequest
        {
            public Tag Tag { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Tags.Add(request.Tag);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
