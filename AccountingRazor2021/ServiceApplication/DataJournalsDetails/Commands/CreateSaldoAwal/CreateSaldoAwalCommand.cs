using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace AccountingRazor2021.ServiceApplication.DataJournalsDetails.Commands.CreateSaldoAwal
{
    public class CreateSaldoAwalCommand : IRequest<Guid>
    {
        public decimal Debit { get;  set; }
        public decimal Kredit { get;  set; }
        public Guid DataAccountId { get;  set; }
    }
}
