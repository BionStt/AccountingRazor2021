using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using MediatR;

namespace AccountingRazor2021.ServiceApplication.DataJournalsDetails.Queries.ListDataJournalDetailsByAkun
{
    public class ListDataJournalDetailsByAkunQuery:IRequest<IReadOnlyCollection<ListDataJournalDetailsByAkunResponse>>
    {
        public string NoUrutId { get; set; }
    }
}
