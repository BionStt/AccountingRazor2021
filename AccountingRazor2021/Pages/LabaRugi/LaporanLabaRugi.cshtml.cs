using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.ServiceApplication.DataJournals.Queries.GetLaporanLabaRugi;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccountingRazor2021.Pages.LabaRugi
{
    public class LaporanLabaRugiModel : PageModel
    {
        private readonly IMediator _mediator;
        [BindProperty(SupportsGet = true)]
        public IReadOnlyCollection<GetLaporanLabaRugiResponse> Item { get; set; }
   
        [BindProperty]
        public DateTime Tanggal1 { get; set; }
        [BindProperty]
        public DateTime Tanggal2 { get; set; }


        public LaporanLabaRugiModel(IMediator mediator)
        {
            _mediator = mediator;
        }
     
        public async Task OnGetAsync(DateTime Tgl1, DateTime Tgl2)
        {
            if (Tgl1 != new DateTime() && Tgl2 != new DateTime())
            {
                //  if (Tanggal1 != null) { }
                var LapLabaRugi = await _mediator.Send(new GetLaporanLabaRugiQuery { Tanggal1 = Tgl1, Tanggal2 = Tgl2 });
                Item = LapLabaRugi.OrderBy(x => x.KodeAccountParent).OrderBy(x => x.KodeAccount1).ToList();
            }
            //return Page();//perlukah ini ?
        }
        public async Task<IActionResult> OnPostAsync()
        {
            return RedirectToPage("/LabaRugi/LaporanLabaRugi", new { Tgl1 = Tanggal1, Tgl2 = Tanggal2 });

        }
    }
}
