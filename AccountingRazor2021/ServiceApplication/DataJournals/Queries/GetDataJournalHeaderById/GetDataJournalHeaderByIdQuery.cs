﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using MediatR;

namespace AccountingRazor2021.ServiceApplication.DataJournals.Queries.GetDataJournalHeaderById
{
    public class GetDataJournalHeaderByIdQuery:IRequest<GetDataJournalHeaderByIdResponse>
    {
        public Guid KodeJournalHeaderId { get; set; }

    }
}
