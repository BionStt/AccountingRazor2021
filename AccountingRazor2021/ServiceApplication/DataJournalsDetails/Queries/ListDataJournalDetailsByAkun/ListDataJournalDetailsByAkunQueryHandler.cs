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

namespace AccountingRazor2021.ServiceApplication.DataJournalsDetails.Queries.ListDataJournalDetailsByAkun
{
    public class ListDataJournalDetailsByAkunQueryHandler : IRequestHandler<ListDataJournalDetailsByAkunQuery, IReadOnlyCollection<ListDataJournalDetailsByAkunResponse>>
    {
        private readonly AccountingDbContext _dbContext;

        public ListDataJournalDetailsByAkunQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<ListDataJournalDetailsByAkunResponse>> Handle(ListDataJournalDetailsByAkunQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _dbContext.DataJournalDetails
                                     join b in _dbContext.DataAccounts on a.DataAccountId equals b.DataAccountId
                                     join c in _dbContext.DataJournalHeaders on a.DataJournalHeaderId equals c.DataJournalHeaderId
                                     where b.NoUrutId == int.Parse(request.NoUrutId)
                                     select new ListDataJournalDetailsByAkunResponse { 
                                        NoUrutId = b.NoUrutId,
                                        NoIdBUkti = a.NoUrutId,
                                        KodeNamaAkun = b.KodeAccount + " - " + b.Account,
                                        Debit1 = a.Debit,
                                        Kredit1 = a.Kredit,
                                        Keterangan = a.Keterangan,
                                        TanggalInput = c.TanggalInput,
                                        NoBuktiJurnal = c.NoBuktiJournal
                                     }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
