using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingRazor2021.Dto
{
    public class CreateDataJournalsDetailsRequest
    {
        public Guid DataJournalHeaderId { get; set; }
        public int DataAccountId { get; set; }
        public Decimal? Debit { get; set; }
        public Decimal? Kredit { get; set; }
        public string Keterangan { get; set; }

    }
}
