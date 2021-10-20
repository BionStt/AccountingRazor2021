using AccountingRazor2021.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingRazor2021.ServiceApplication.DataJournalsDetails.Queries.ListDataJournalDetailsByHeaderId
{
    public class ListDataJournalDetailsByHeaderIdQuery : IRequest<IReadOnlyCollection<ListDataJournalDetailsByHeaderIdQueryResponse>>
    {
        public Guid KodeJournalHeaderId { get; set; }

    }
}
