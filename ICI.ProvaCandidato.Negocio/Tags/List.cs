using ICI.ProvaCandidato.Dados;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Tags
{
    public class List
    {
        public class Query : IRequest<List<Tag>>
        {
            private readonly DataContext _context;
        }

        public class Handler : IRequestHandler<Query, List<Tag>>
        {
            private readonly DataContext _context;
            private readonly ILogger<List> _logger;

            public Handler(DataContext context, ILogger<List> logger)
            {
                _logger = logger;
                _context = context;
            }

            public async Task<List<Tag>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Tags.ToListAsync();
            }
        }
    }
}
