using AccountingRazor2021.Dto;
using AccountingRazor2021.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AccountingRazor2021.ServiceApplication.DataJournalsDetails.Queries.ListDataJournalDetailsByHeaderId
{
    public class ListDataJournalDetailsByHeaderIdQueryHandler : IRequestHandler<ListDataJournalDetailsByHeaderIdQuery, IReadOnlyCollection<ListDataJournalDetailsByHeaderIdQueryResponse>>
    {
        private readonly AccountingDbContext _dbContext;

        public ListDataJournalDetailsByHeaderIdQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<ListDataJournalDetailsByHeaderIdQueryResponse>> Handle(ListDataJournalDetailsByHeaderIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from DtJournal in _dbContext.DataJournalDetails
                                      join DtAccount in _dbContext.DataAccounts on DtJournal.DataAccountId equals DtAccount.DataAccountId
                                      //let DtList1 = DtAccount.KodeAccount + " - " + DtAccount.Account
                                      where DtJournal.DataJournalHeaderId == (request.KodeJournalHeaderId)
                                      select new ListDataJournalDetailsByHeaderIdQueryResponse
                                      {
                                          NourutID = DtAccount.NoUrutId,
                                          KodeJournalHeaderId = DtJournal.DataJournalHeaderId,
                                          // KodeNamaAkun = DtList1,
                                          KodeNamaAkun = DtAccount.KodeAccount + " - " + DtAccount.Account,
                                          Debit1 = DtJournal.Debit,
                                          Kredit1 = DtJournal.Kredit,
                                          Ket1 = DtJournal.Keterangan
                                      }

                     ).ToListAsync();

            return returnQuery;


        }
    }
}
