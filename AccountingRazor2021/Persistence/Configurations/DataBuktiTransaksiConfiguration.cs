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
    public class DataBuktiTransaksiConfiguration : IEntityTypeConfiguration<DataBuktiTransaksi>
    {
        public void Configure(EntityTypeBuilder<DataBuktiTransaksi> builder)
        {
            builder.ToTable("DataBuktiTransaksi");

            //builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("AccountingDataBuktiTransaksi_hilo").IsRequired();

            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd().IsRequired();
            builder.Property(e => e.TipeJournalId);
            builder.Property(e => e.NoBukti).HasColumnName("NoBukti");

            builder.Property(e => e.TanggalInput)
                .HasColumnName("TanggalInput")
                .HasColumnType("datetime");

            builder.Property(e => e.Keterangan).HasColumnName("Keterangan");
            builder.Property(e => e.ValidateBy).HasColumnName("ValidateBy");

            builder.Property(e => e.ValidatedDate)
                .HasColumnName("ValidatedDate")
                .HasColumnType("datetime");

            builder.Property(e => e.Total)
                .HasColumnName("Total")
                .HasColumnType("money");
        }
    }
}
