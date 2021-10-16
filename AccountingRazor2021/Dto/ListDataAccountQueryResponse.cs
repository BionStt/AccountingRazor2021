using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingRazor2021.Dto
{
    public class ListDataAccountQueryResponse
    {
        public string Parent { get; set; }
        public string KodeAccount { get; set; }
        public string Account { get; set; }
        public int? NormalPos { get; set; }
        public string Kelompok { get; set; }
    }
}
