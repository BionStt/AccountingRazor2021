using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.ServiceApplication.DataJournals.Queries.ListDataJournalHeaders;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccountingRazor2021.Pages.DataJournals
{
    public class IndexModel : PageModel
    {
        private readonly IMediator _mediator;
        [BindProperty(SupportsGet = true)]
        public IReadOnlyCollection<ListDataJournalHeadersResponse> model { get; set; }
        public IndexModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task OnGetAsync()
        {
            model = await _mediator.Send(new ListDataJournalHeadersQuery());
        }
    }
}
