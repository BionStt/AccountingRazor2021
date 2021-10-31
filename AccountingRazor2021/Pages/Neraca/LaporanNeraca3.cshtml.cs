using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.ServiceApplication.DataJournals.Queries.GetLaporanNeraca;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccountingRazor2021.Pages.Neraca
{
    public class LaporanNeraca3Model : PageModel
    {
        private readonly IMediator _mediator;

        [BindProperty(SupportsGet = true)]
        public IReadOnlyCollection<GetLaporanNeracaResponse> Item { get; set; }
        [BindProperty]
        public DateTime Tanggal1 { get; set; }
        [BindProperty]
        public DateTime Tanggal2 { get; set; }
        public LaporanNeraca3Model(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task OnGetAsync(DateTime Tgl1, DateTime Tgl2)
        {

            if (Tgl1 != new DateTime() && Tgl2 != new DateTime())
            {

                var LapNeraca = await _mediator.Send(new GetLaporanNeracaQuery { Tanggal1 = Tgl1, Tanggal2 = Tgl2 });
                //Item = LapNeraca.OrderBy(x => x.KodeAccountParent).OrderBy(x => x.KodeAccount1).ToList();
                Item = LapNeraca;
            }


        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (Tanggal1 != new DateTime() && Tanggal2 != new DateTime())
            {
                return RedirectToPage("/Neraca/LaporanNeraca3", new { Tgl1 = Tanggal1, Tgl2 = Tanggal2 });
            }
            return RedirectToPage("/Neraca/LaporanNeraca3");
        }
    }
}
