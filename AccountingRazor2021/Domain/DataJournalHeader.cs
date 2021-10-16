using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingRazor2021.Domain
{
    public class DataJournalHeader
    {
        public Guid DataJournalHeaderId { get; set; }
        public int NoUrutId { get; set; }



        public int? DataPeriodeId { get; set; }
        public DateTime TanggalInput { get; set; }
        public string NoBuktiJournal { get; set; }
        public string Keterangan { get; set; }
        public int TipeJournalId { get; set; }
        public string UserInput { get; set; }
        public DateTime? Validasi { get; set; }
        public string ValidasiOleh { get; set; }
        public string Aktif { get; set; }


        private string GenerateNBJ(DateTime TanggalInput)
        {
            var bln = TanggalInput.Month;
            var thn = TanggalInput.Year;
            var NoBuktiJurnal = string.Empty;

            if (bln == 1) { NoBuktiJurnal = "NBJ/" + "/I/" + thn; }
            else if (bln == 2) { NoBuktiJurnal = "NBJ/" + "/II/" + thn; }
            else if (bln == 3) { NoBuktiJurnal = "NBJ/" + "/III/" + thn; }
            else if (bln == 4) { NoBuktiJurnal = "NBJ/" + "/IV/" + thn; }
            else if (bln == 5) { NoBuktiJurnal = "NBJ/" + "/V/" + thn; }
            else if (bln == 6) { NoBuktiJurnal = "NBJ/" + "/VI/" + thn; }
            else if (bln == 7) { NoBuktiJurnal = "NBJ/" + "/VII/" + thn; }
            else if (bln == 8) { NoBuktiJurnal = "NBJ/" + "/VIII/" + thn; }
            else if (bln == 9) { NoBuktiJurnal = "NBJ/" + "/IX/" + thn; }
            else if (bln == 10) { NoBuktiJurnal = "NBJ/" + "/X/" + thn; }
            else if (bln == 11) { NoBuktiJurnal = "NBJ/" + "/XI/" + thn; }
            else if (bln == 12) { NoBuktiJurnal = "NBJ/" + "/XII/" + thn; }

            return NoBuktiJurnal;
        }


    }
}
