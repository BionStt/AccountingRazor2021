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

namespace AccountingRazor2021.ServiceApplication.DataAccount.Queries.GetDataSaldoAwal
{
    //public class GetDataSaldoAwalQueryHandler : IRequestHandler<GetDataSaldoAwalQuery, IReadOnlyCollection<GetDataSaldoAwalResponse>>
    //{
    //    private readonly AccountingDbContext _dbContext;

    //    public GetDataSaldoAwalQueryHandler(AccountingDbContext dbContext)
    //    {
    //        _dbContext = dbContext;
    //    }

    //    public async Task<IReadOnlyCollection<GetDataSaldoAwalResponse>> Handle(GetDataSaldoAwalQuery request, CancellationToken cancellationToken)
    //    {
    //       //var returnQuery = await _dbContext.DataAccounts.ToListAsync():

    //       //     return returnQuery;
    //    }
    //}
}
