using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.ServiceApplication.DataAccount.Queries.ListDataAccount;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccountingRazor2021.Pages.DataSaldoAwal
{
    public class DataSaldoAwalIndexModel : PageModel
    {
        private readonly IMediator _mediator;
        [BindProperty(SupportsGet = true)]
        public IReadOnlyCollection<ListDataAccountQueryResponse> Item { get; set; }

        public DataSaldoAwalIndexModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task OnGetAsync()
        {

            Item = await _mediator.Send(new ListDataAccountQuery());


        }
    }
}
