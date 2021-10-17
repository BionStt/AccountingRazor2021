using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AccountingRazor2021.ServiceApplication.TipeJournal.Queries.ListTIpeJournal
{
    public class ListTIpeJournalQueryHandler : IRequestHandler<ListTIpeJournalQuery, IReadOnlyCollection<ListTIpeJournalResponse>>
    {
        private readonly AccountingDbContext _dbContext;

        public ListTIpeJournalQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public  async Task<IReadOnlyCollection<ListTIpeJournalResponse>> Handle(ListTIpeJournalQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _dbContext.TipeJournals.Select(x => new ListTIpeJournalResponse
            {
               NamaJournal=x.NamaJournal,
               NoUrutId= x.NoUrutId

            }).AsNoTracking().OrderBy(x=>x.NoUrutId).ToListAsync(cancellationToken);

            return returnQuery;
        }
    }
}
