using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingRazor2021.Dto
{
    public class GetDataJournalHeaderByIdResponse
    {
        public string NoBuktiJournalHeader { get; set; }
        public DateTime TanggalInput { get; set; }
        public string Keterangan { get; set; }



    }
}
