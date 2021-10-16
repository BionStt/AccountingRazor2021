using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace AccountingRazor2021.ServiceApplication.DataAccount.Commands.CreateDataAccount
{
    public class CreateDataAccountCommand:IRequest<Guid>
    {
        public string Parent { get; set; }
        public string KodeAccount { get; set; }
        public string Account { get; set; }
        public int? NormalPos { get; set; }
        public string Kelompok { get; set; }
    }
}
