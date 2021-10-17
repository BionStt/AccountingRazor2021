using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingRazor2021.Domain
{
    public class DataJournalDetails
    {
        protected DataJournalDetails()
        {

        }
        private DataJournalDetails(Guid dataJournalHeaderId, Guid dataAccountId, decimal? debit, decimal? kredit, string keterangan)
        {
            DataJournalHeaderId = dataJournalHeaderId;
            DataAccountId = dataAccountId;
            Debit = debit;
            Kredit = kredit;
            Keterangan = keterangan;
        }
        public static DataJournalDetails CreateDataJournalDetails(Guid dataJournalHeaderId, Guid dataAccountId, decimal? debit, decimal? kredit, string keterangan)
        {
            return new DataJournalDetails(dataJournalHeaderId,dataAccountId,debit,kredit,keterangan);
        }
        public Guid DataJournalDetailsId { get; private set; }
        public int NoUrutId { get; private set; }

        public Guid DataJournalHeaderId { get; private set; }
        public Guid DataAccountId { get; private set; }
        public Decimal? Debit { get; private set; }
        public Decimal? Kredit { get; private set; }
        public string Keterangan { get; private set; }





    }
}
