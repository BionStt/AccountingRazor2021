using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingRazor2021.Domain
{
    public class DataPeriode
    {
        public Guid DataPeriodeId{ get; set; }
        public int NoUrutId { get; set; }

        public DateTime Mulai { get; set; }
        public DateTime Berakhir { get; set; }
        public string Aktif { get; set; }
        public string UserInput { get; set; }
    }
}
