using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.ServiceApplication.DataAccount.Queries.GetNamaAkunByNoUrutId;
using AccountingRazor2021.ServiceApplication.DataAccount.Queries.LIstDataAccountForDepthNum3;
using AccountingRazor2021.ServiceApplication.DataJournalsDetails.Queries.ListDataJournalDetailsByAkunTanggal;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccountingRazor2021.Pages.BukuBesar
{
    public class LaporanAkunBukuBesarByAkunTanggalModel : PageModel
    {

        private readonly IMediator _mediator;

        public IReadOnlyCollection<ListDataJournalDetailsByAkunTanggalResponse> listDataJournalDetailsByAkunTanggalResponse { get; set; }

        public LaporanAkunBukuBesarByAkunTanggalModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task OnGetAsync(string NamaAkun2, DateTime PeriodeAwal2, DateTime PeriodeAkhir2)
        {
            var DataAccounting = await _mediator.Send(new LIstDataAccountForDepthNum3Query());
            ViewData["Akun1"] = new SelectList(DataAccounting, "NoUrutId", "NamaAkun");

            if (!string.IsNullOrEmpty(NamaAkun2))
            {
                listDataJournalDetailsByAkunTanggalResponse = await _mediator.Send(new ListDataJournalDetailsByAkunTanggalQuery { NoUrutId = NamaAkun2 });
                var dtNamaAkun = await _mediator.Send(new GetNamaAkunByNoUrutIdQuery { NoUrutId = NamaAkun2 });
                ViewData["dtNamaAkun2"] = dtNamaAkun.NamaAkun;
            }



        }



        public async Task<IActionResult> OnPostAsync(string Akun1,DateTime PeriodeAwal, DateTime PeriodeAkhir)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            return RedirectToPage("/BukuBesar/LaporanAkunBukuBesarByAkunTanggal", new { NamaAkun2 = Akun1 , PeriodeAwal2 = PeriodeAwal, PeriodeAkhir2 = PeriodeAkhir });
            //  return Page();



        }


    }
}
