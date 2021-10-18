using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingRazor2021.Dto
{
    public class GetDataJournalHeaderQueryResponse
    {
        public Guid DataJournalHeaderId { get; set; }
        public int NoUrutId { get; set; }
        public string JournalHeaders { get; set; }
    }
}
