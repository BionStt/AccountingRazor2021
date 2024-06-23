using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingRazor2021.Dto
{
    public class CreateDataJournalsRequest
    {
        //public string NoBuktiJournal { get; set; }
        public string Keterangan { get; set; }
        public int TipeJournalId { get; set; }
        public string UserInput { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal TotalRupiah { get; set; }
        public DateTime TanggalInput { get; set; }
    }
}
