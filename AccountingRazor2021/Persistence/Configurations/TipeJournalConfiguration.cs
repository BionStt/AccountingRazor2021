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
            builder.HasData(
                TipeJournal.CreateTipeJournal("JU","JURNAL UMUM"),
                TipeJournal.CreateTipeJournal("JPMB", "JURNAL PEMBELIAN"),
                  TipeJournal.CreateTipeJournal("JPJ", "JURNAL PENJUALAN"),
                    TipeJournal.CreateTipeJournal("JPNK", "JURNAL PENERIMAAN KAS"),
                      TipeJournal.CreateTipeJournal("JPGNK", "JURNAL PENGELUARAN KAS"),
                        TipeJournal.CreateTipeJournal("JPEY", "JURNAL PENYESUAIAN"),
                          TipeJournal.CreateTipeJournal("JPMBK", "JURNAL PEMBUKA"),
                            TipeJournal.CreateTipeJournal("JPNTP", "JURNAL PENUTUP"),
                              TipeJournal.CreateTipeJournal("JPMBLK", "JURNAL PEMBALIK")
                );
        }
    }
}
