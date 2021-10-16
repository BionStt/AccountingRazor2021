using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingRazor2021.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingRazor2021.Persistence.Configurations
{
    public class TipeJournalConfiguration : IEntityTypeConfiguration<TipeJournal>
    {
        public void Configure(EntityTypeBuilder<TipeJournal> builder)
        {
            builder.ToTable("TipeJournal");

            //builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("AccountingTipeJournal_hilo").IsRequired();
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd().IsRequired();
            builder.Property(e => e.KodeJournal)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.NamaJournal)
                .HasColumnName("NamaJournal")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
