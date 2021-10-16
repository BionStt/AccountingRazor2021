using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingRazor2021.Domain
{
    public class DataAccount
    {
        private DataAccount(string parent, string kodeAccount, string account, int? normalPos, string kelompok)
        {
            Parent = parent;
            KodeAccount = kodeAccount;
            Account = account;
            NormalPos = normalPos;
            Kelompok = kelompok;
        }

        protected DataAccount()
        {

        }
        public Guid DataAccountId { get; set; }
        public int NoUrutId { get; set; }


        public int? Lft { get; set; }
        public int? Rgt { get; set; }
        public int? Depth { get; set; }

        public string Parent { get; set; }      
        public string KodeAccount { get; set; }
        public string Account { get; set; }
        public int? NormalPos { get; set; }
        public string Kelompok { get; set; }
        public string Aktif { get; set; }
        // public string Alias {get;set;} //utk bhs inggris ?
        //  public int? DataMataUangId { get; set; }

        public static DataAccount CreateDataAccount(string parent, string kodeAccount, string account, int? normalPos, string kelompok)
        {
            return new DataAccount(parent,kodeAccount,account,normalPos,kelompok);
        }
    }
}
