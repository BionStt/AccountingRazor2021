using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.ServiceApplication.DataAccount.Queries.GetDataAccountByDepth;
using AccountingRazor2021.ServiceApplication.DataAccount.Queries.GetNamaAkunByNoUrutId;
using AccountingRazor2021.ServiceApplication.DataAccount.Queries.LIstDataAccountForDepthNum3;
using AccountingRazor2021.ServiceApplication.DataJournalsDetails.Queries.ListDataJournalDetailsByAkun;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace AccountingRazor2021.Pages.BukuBesar
{
    public class LaporanAkunBukuBesarByAkunModel : PageModel
    {
        private readonly IMediator _mediator;

       
        public IReadOnlyCollection<ListDataJournalDetailsByAkunResponse> listDataJournalDetailsByAkunResponse { get; set; }

        public LaporanAkunBukuBesarByAkunModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task OnGetAsync(string NamaAkun2)
        {
            var DataAccounting = await _mediator.Send(new LIstDataAccountForDepthNum3Query());
            ViewData["Akun1"] = new SelectList(DataAccounting, "NoUrutId", "NamaAkun");

            if (!string.IsNullOrEmpty(NamaAkun2) )
            {
                listDataJournalDetailsByAkunResponse = await _mediator.Send(new ListDataJournalDetailsByAkunQuery { NoUrutId = NamaAkun2 });
                var dtNamaAkun = await _mediator.Send(new GetNamaAkunByNoUrutIdQuery { NoUrutId = NamaAkun2 });
                ViewData["dtNamaAkun2"] = dtNamaAkun.NamaAkun;
            }
            

             

        }

        public async Task<IActionResult> OnPostAsync(string Akun1)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
         

            return RedirectToPage("/BukuBesar/LaporanAkunBukuBesarByAkun", new { NamaAkun2 = Akun1 });
          //  return Page();



        }



    }
}
