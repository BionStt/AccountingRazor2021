using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AccountingRazor2021.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AccountingRazor2021.ServiceApplication.DataJournalsDetails.Commands.CreateDataJournalsDetails
{
    public class CreateDataJournalsDetailsCommandHandler : IRequestHandler<CreateDataJournalsDetailsCommand, Guid>
    {
        private readonly AccountingDbContext _dbContext;

        public CreateDataJournalsDetailsCommandHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateDataJournalsDetailsCommand request, CancellationToken cancellationToken)
        {
            var xx = _dbContext.DataAccounts.Where(x => x.NoUrutId == request.DataAccountId).Select(x=>new { x.DataAccountId}).SingleOrDefaultAsync();

            var entity = Domain.DataJournalDetails.CreateDataJournalDetails(request.DataJournalHeaderId, xx.Result.DataAccountId, request.Debit,request.Kredit,request.Keterangan);

            await _dbContext.DataJournalDetails.AddAsync(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return request.DataJournalHeaderId;
        }
    }
}
