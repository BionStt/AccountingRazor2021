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

namespace AccountingRazor2021.ServiceApplication.DataJournalsDetails.Queries.ListDataJournalDetailsByAkunTanggal
{
    public class ListDataJournalDetailsByAkunTanggalQueryHandler : IRequestHandler<ListDataJournalDetailsByAkunTanggalQuery, IReadOnlyCollection<ListDataJournalDetailsByAkunTanggalResponse>>
    {
        private readonly AccountingDbContext _dbContext;

        public ListDataJournalDetailsByAkunTanggalQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<ListDataJournalDetailsByAkunTanggalResponse>> Handle(ListDataJournalDetailsByAkunTanggalQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _dbContext.DataJournalDetails
                                     join b in _dbContext.DataAccounts on a.DataAccountId equals b.DataAccountId
                                     join c in _dbContext.DataJournalHeaders on a.DataJournalHeaderId equals c.DataJournalHeaderId
                                     where b.NoUrutId == int.Parse(request.NoUrutId)  && (c.TanggalInput >= request.PeriodeAwal && c.TanggalInput <= request.PeriodeAkhir)
                                     select new ListDataJournalDetailsByAkunTanggalResponse
                                     {
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
