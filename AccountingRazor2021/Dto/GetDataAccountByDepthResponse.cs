using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingRazor2021.Dto
{
    public class GetDataAccountByDepthResponse
    {
        public int NoUrutId { get; set; }
        public string Account { get; set; }
        public string KodeAccount { get; set; }
        public string DataAkun1 { get; set; }
        public string DataAkun2 { get; set; }

    }
}
