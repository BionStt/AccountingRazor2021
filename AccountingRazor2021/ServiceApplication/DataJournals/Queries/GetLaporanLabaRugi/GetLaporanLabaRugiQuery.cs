using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using MediatR;

namespace AccountingRazor2021.ServiceApplication.DataJournals.Queries.GetLaporanLabaRugi
{
    public class GetLaporanLabaRugiQuery : IRequest<IReadOnlyCollection<GetLaporanLabaRugiResponse>>
    {
        public DateTime Tanggal1 { get; set; }
        public DateTime Tanggal2 { get; set; }
    }
}
