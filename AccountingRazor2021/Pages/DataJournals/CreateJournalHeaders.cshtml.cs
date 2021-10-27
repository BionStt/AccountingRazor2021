using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.Mapping;
using AccountingRazor2021.ServiceApplication.TipeJournal.Queries.ListTIpeJournal;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public async Task OnGetAsync()
        {
            var dataJournal = await _mediator.Send(new ListTIpeJournalQuery());
            ViewData["TipeJournalId"] = new SelectList(dataJournal, "NoUrutId", "NamaJournal");

        }
        public async Task<IActionResult> OnPostAsync(CreateDataJournalsRequest DataJournalHeaders)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var xx = DataJournalHeaders.ToCommand();
            var bb = await _mediator.Send(xx);

            return RedirectToPage("/DataJournalsDetail/CreateDataJournalsDetail",  new { KodeJournalHeaderId = bb });
            // return RedirectToPage("./DataJournalsDetail/CreateDataJournalsDetail", "SingleOrder", new { orderId = order.Id });
            //return RedirectToPage();

        }
    }
}
