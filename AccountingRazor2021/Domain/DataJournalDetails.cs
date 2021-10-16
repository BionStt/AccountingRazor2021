using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingRazor2021.Domain
{
    public class DataJournalDetails
    {
        public Guid DataJournalDetailsId { get; set; }
        public int NoUrutId { get; set; }

        public Guid DataJournalHeaderId { get; set; }
        public Guid DataAccountId { get; set; }
        public Decimal? Debit { get; set; }
        public Decimal? Kredit { get; set; }
        public string Keterangan { get; set; }





    }
}
