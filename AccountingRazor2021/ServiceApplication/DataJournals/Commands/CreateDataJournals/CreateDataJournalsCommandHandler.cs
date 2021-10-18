﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AccountingRazor2021.Persistence.Context;
using MediatR;

namespace AccountingRazor2021.ServiceApplication.DataJournals.Commands.CreateDataJournals
{
    public class CreateDataJournalsCommandHandler : IRequestHandler<CreateDataJournalsCommand, Guid>
    {
        private readonly AccountingDbContext _dbContext;

        public CreateDataJournalsCommandHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateDataJournalsCommand request, CancellationToken cancellationToken)
        {
            var entity = Domain.DataJournalHeader.CreateDataJournalHeader(request.TanggalInput,request.Keterangan,request.TipeJournalId,request.UserInput);

            await _dbContext.DataJournalHeaders.AddAsync(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return entity.DataJournalHeaderId;
        }
    }
}