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
    public class LaporanAkunBukuBesarAll2Model : PageModel
    {
        private readonly IMediator _mediator;

        public LaporanAkunBukuBesarAll2Model(IMediator mediator)
        {
            _mediator = mediator;
        }

        [BindProperty(SupportsGet = true)]
        public IReadOnlyCollection<GetDataJournalAllResponse> Item { get; set; }

        public async Task OnGetAsync()
        {
            var aa1 = await _mediator.Send(new GetDataJournalAllQuery());
            Item = aa1.OrderBy(x => x.TanggalInput).OrderBy(x => x.DataAkun).ToList();

        }
    }
}
