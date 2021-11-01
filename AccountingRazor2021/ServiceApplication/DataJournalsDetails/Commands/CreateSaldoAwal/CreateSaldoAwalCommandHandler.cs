using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AccountingRazor2021.Persistence.Context;
using AccountingRazor2021.ServiceApplication.DataAccount.Queries.GetDataAccountIdByNoUrutId;
using MediatR;

namespace AccountingRazor2021.ServiceApplication.DataJournalsDetails.Commands.CreateSaldoAwal
{
    public class CreateSaldoAwalCommandHandler : IRequestHandler<CreateSaldoAwalCommand, Guid>
    {
        private readonly AccountingDbContext _dbContext;
        private readonly IMediator _mediator;

        public CreateSaldoAwalCommandHandler(AccountingDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<Guid> Handle(CreateSaldoAwalCommand request, CancellationToken cancellationToken)
        {
          //  var dtAccountId = await _mediator.Send(new GetDataAccountIdByNoUrutIdQuery {NoUrutId = request.DataAccountId });

            var dtSaldoAwal = Domain.DataJournalDetails.CreateSaldoAwal(request.DataAccountId, request.Debit,request.Kredit);

            await _dbContext.DataJournalDetails.AddAsync(dtSaldoAwal);
            await _dbContext.SaveChangesAsync();

            return dtSaldoAwal.DataAccountId;
        }
    }
}
