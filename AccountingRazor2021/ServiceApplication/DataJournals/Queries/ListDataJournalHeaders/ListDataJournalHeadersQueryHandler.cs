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

namespace AccountingRazor2021.ServiceApplication.DataJournals.Queries.ListDataJournalHeaders
{
    public class ListDataJournalHeadersQueryHandler : IRequestHandler<ListDataJournalHeadersQuery, IReadOnlyCollection<ListDataJournalHeadersResponse>>
    {
        private readonly AccountingDbContext _dbContext;

        public ListDataJournalHeadersQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<ListDataJournalHeadersResponse>> Handle(ListDataJournalHeadersQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _dbContext.DataJournalHeaders.Select(x => new ListDataJournalHeadersResponse
            {
             DataJournalHeadersId = x.DataJournalHeaderId,
             Keterangan = x.Keterangan,
             NoBuktiJournal = x.NoBuktiJournal,
             NoUrutId = x.NoUrutId,
             TanggalInput = x.TanggalInput,
             UserInput = x.UserInput,
             ValidasiOleh = x.ValidasiOleh,
             TotalRupiah = x.TotalRupiah


            }).AsNoTracking().ToListAsync(cancellationToken);

            return returnQuery;
        }
    }
}
    

