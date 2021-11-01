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

namespace AccountingRazor2021.ServiceApplication.DataAccount.Queries.GetDataAccountIdByNoUrutId
{
    public class GetDataAccountIdByNoUrutIdQueryHandler : IRequestHandler<GetDataAccountIdByNoUrutIdQuery, GetDataAccountIdByNoUrutIdResponse>
    {
        private readonly AccountingDbContext _dbContext;

        public GetDataAccountIdByNoUrutIdQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetDataAccountIdByNoUrutIdResponse> Handle(GetDataAccountIdByNoUrutIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _dbContext.DataAccounts.Where(x=>x.NoUrutId == request.NoUrutId).Select(x=> new GetDataAccountIdByNoUrutIdResponse { 
            NoUrutId = x.NoUrutId,
            DataAccountId = x.DataAccountId
            }).SingleOrDefaultAsync();

            return returnQuery;
        }
    }
}
