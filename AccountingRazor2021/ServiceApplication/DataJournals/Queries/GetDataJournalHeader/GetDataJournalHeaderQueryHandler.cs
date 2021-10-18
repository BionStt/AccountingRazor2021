using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.Persistence.Context;
using AccountingRazor2021.ServiceApplication.DataJournals.Queries.ListDataJournalHeaders;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AccountingRazor2021.ServiceApplication.DataJournals.Queries.GetDataJournalHeader
{
    public class GetDataJournalHeaderQueryHandler : IRequestHandler<GetDataJournalHeaderQuery, IReadOnlyCollection<GetDataJournalHeaderQueryResponse>>
    {
        private readonly AccountingDbContext _dbContext;

        public GetDataJournalHeaderQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<GetDataJournalHeaderQueryResponse>> Handle(GetDataJournalHeaderQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _dbContext.DataJournalHeaders.Select(x => new GetDataJournalHeaderQueryResponse
            {
              DataJournalHeaderId = x.DataJournalHeaderId,
              NoUrutId = x.NoUrutId ,
              JournalHeaders = string.Format("{0:d}",x.TanggalInput) + " - " + x.NoBuktiJournal + " - " + x.Keterangan

            }).AsNoTracking().ToListAsync(cancellationToken);

            return returnQuery;
        }
    }
}
