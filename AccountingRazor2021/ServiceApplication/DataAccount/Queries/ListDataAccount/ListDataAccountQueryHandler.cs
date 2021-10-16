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

namespace AccountingRazor2021.ServiceApplication.DataAccount.Queries.ListDataAccount
{
    public class ListDataAccountQueryHandler : IRequestHandler<ListDataAccountQuery, IReadOnlyCollection<ListDataAccountQueryResponse>>
    {

        private readonly AccountingDbContext _dbContext;

        public ListDataAccountQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<ListDataAccountQueryResponse>> Handle(ListDataAccountQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _dbContext.DataAccounts.Select(x => new ListDataAccountQueryResponse
            {
               KodeAccount = x.KodeAccount,
               Account = x.Account,
               NormalPos = x.NormalPos,
               Kelompok = x.Kelompok //,
              // Parent = x.Parent

            }).AsNoTracking().OrderBy(x=>x.KodeAccount).ToListAsync(cancellationToken);

            return returnQuery;
        }
    }
}
