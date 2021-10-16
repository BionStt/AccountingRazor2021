using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingRazor2021.Domain
{
    public class DataBuktiTransaksi
    {
        public Guid DataBuktiTransaksiId { get; set; }
        public int NoUrutId { get; set; }

        public int TipeJournalId { get; set; }
        public string NoBukti { get; set; }
        public DateTime TanggalInput { get; set; }
        public string Keterangan { get; set; }
        public string ValidateBy { get; set; }
        public DateTime ValidatedDate { get; set; }
        public Decimal Total { get; set; }
    }
}
