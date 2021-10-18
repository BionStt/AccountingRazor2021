using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.Mapping;
using AccountingRazor2021.ServiceApplication.DataAccount.Queries.GetDataAccountByDepth;
using AccountingRazor2021.ServiceApplication.DataJournals.Queries.GetDataJournalHeader;
using AccountingRazor2021.ServiceApplication.DataJournals.Queries.GetDataJournalHeaderById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccountingRazor2021.Pages.DataJournalsDetail
{
    public class CreateDataJournalsDetailModel : PageModel
    {
        private readonly IMediator _mediator;

        public CreateDataJournalsDetailModel(IMediator mediator)
        {
            _mediator = mediator;
        }
        [BindProperty]
        public CreateDataJournalsDetailsRequest DataJournalDetails { get; set; }
        public async Task OnGetAsync(Guid KodeJournalHeaderId)
        {
            var DataJournalHeader = await _mediator.Send(new GetDataJournalHeaderQuery());
            ViewData["DataJournalHeader1"] = new SelectList(DataJournalHeader.OrderByDescending(x => x.NoUrutId).Take(10).ToList(), "NoUrutId", "JournalHeaders");


            var bb = await _mediator.Send(new GetDataAccountByDepthQuery());
            var aa = bb.OrderBy(X => X.KodeAccount).GroupBy(x => x.DataAkun2).ToList();


            var model = new AccountClientViewModel()
            {
                AccountIdList = new List<SelectListItem>()

            };
            foreach (var akunGroup in aa)
            {
                var OptionGroup = new SelectListGroup() { Name = akunGroup.Key };
                foreach ( var akun1 in akunGroup)
                {
                    model.AccountIdList.Add(new SelectListItem() { Value = akun1.NoUrutId.ToString(), Text = akun1.DataAkun1, Group = OptionGroup });
                }
            }
            ViewData["Account1"] = model.AccountIdList;

             var DataJournalHeader1 = await _mediator.Send(new GetDataJournalHeaderByIdQuery { KodeJournalHeaderId = KodeJournalHeaderId });

            ViewData["Keterangan1"] = DataJournalHeader1.Keterangan;
          //  ViewData["IDHeader1"] = KodeIdHeader1;
            ViewData["NoBuktij11"] = DataJournalHeader1.NoBuktiJournalHeader;
            ViewData["TglInputjournal"] = DataJournalHeader1.TanggalInput;
        }
        public class AccountClientViewModel
        {
            public IList<SelectListItem> AccountIdList { get; set; }
        }
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            //DataAccount.Kelompok = Kelompok1;

            //DataAccount.NormalPos = int.Parse(NormalPos1);

            var xx = DataJournalDetails.ToCommand();
            await _mediator.Send(xx);



            return RedirectToPage();
            //  return RedirectToPage("./Index");

        }

    }
}
