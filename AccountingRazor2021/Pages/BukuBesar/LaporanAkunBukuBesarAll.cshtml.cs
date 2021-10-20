using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.ServiceApplication.DataJournals.Queries.GetDataJournalAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccountingRazor2021.Pages.BukuBesar
{
    public class LaporanAkunBukuBesarAllModel : PageModel
    {
        private readonly IMediator _mediator;
        [BindProperty(SupportsGet = true)]
        public IReadOnlyCollection<GetDataJournalAllResponse> Item { get; set; }


        public LaporanAkunBukuBesarAllModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task OnGetAsync()
        {
            var aa1 = await _mediator.Send(new GetDataJournalAllQuery());
            Item = aa1.OrderBy(x => x.TanggalInput).OrderBy(x => x.DataAkun).ToList();
        }
    }
}
