using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using MediatR;

namespace AccountingRazor2021.ServiceApplication.DataJournals.Queries.GetLaporanNeraca2
{
    public class GetLaporanNeraca2Query:IRequest<IReadOnlyCollection<GetLaporanNeraca2Response>>
    {
        public DateTime Tanggal1 { get; set; }
        public DateTime Tanggal2 { get; set; }
    }
}
