using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace AccountingRazor2021.ServiceApplication.DataJournals.Commands.CreateDataJournals
{
    public class CreateDataJournalsCommand : IRequest<Guid>
    {
       // public string NoBuktiJournal { get; set; }
        public string Keterangan { get; set; }
        public int TipeJournalId { get; set; }
        public string UserInput { get; set; }
    }
}
