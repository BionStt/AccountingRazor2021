using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccountingRazor2021.Pages.DataJournals
{
    public class CreateJournalHeadersModel : PageModel
    {
        private readonly IMediator _mediator;

        [BindProperty]
        public CreateDataJournalsRequest DataJournalHeaders { get; set; }
        public CreateJournalHeadersModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void OnGet()
        {
        }
    }
}
