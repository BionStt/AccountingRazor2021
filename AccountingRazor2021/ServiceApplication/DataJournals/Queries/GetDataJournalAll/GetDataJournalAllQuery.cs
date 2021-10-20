using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using MediatR;

namespace AccountingRazor2021.ServiceApplication.DataJournals.Queries.GetDataJournalAll
{
    public class GetDataJournalAllQuery : IRequest<IReadOnlyCollection<GetDataJournalAllResponse>>
    {
        
    }
}
