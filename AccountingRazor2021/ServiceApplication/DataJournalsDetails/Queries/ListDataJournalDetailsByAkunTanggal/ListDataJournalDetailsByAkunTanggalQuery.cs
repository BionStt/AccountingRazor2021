using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using MediatR;

namespace AccountingRazor2021.ServiceApplication.DataJournalsDetails.Queries.ListDataJournalDetailsByAkunTanggal
{
    public class ListDataJournalDetailsByAkunTanggalQuery:IRequest<IReadOnlyCollection<ListDataJournalDetailsByAkunTanggalResponse>>
    {
        public string NoUrutId { get; set; }
        public DateTime PeriodeAwal{ get; set; }
        public DateTime PeriodeAkhir { get; set; }
    }
}
