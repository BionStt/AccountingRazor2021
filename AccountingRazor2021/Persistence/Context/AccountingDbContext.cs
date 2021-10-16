using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingRazor2021.Domain;
using Microsoft.EntityFrameworkCore;

namespace AccountingRazor2021.Persistence.Context
{
    public class AccountingDbContext : DbContext
    {
        public AccountingDbContext(DbContextOptions<AccountingDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AccountingDbContext).Assembly);
        }
        public DbSet<DataAccount> DataAccounts { get; set; }
        public DbSet<DataBuktiTransaksi> DataBuktiTransaksi { get; set; }
        public DbSet<DataJournalDetails> DataJournal { get; set; }
        public DbSet<DataJournalHeader> DataJournalHeaders { get; set; }
        public DbSet<DataPeriode> DataPeriodes { get; set; }
        public DbSet<DataSaldoAwal> DataSaldoAwals { get; set; }
        public DbSet<TipeJournal> TipeJournals { get; set; }




    }
}
