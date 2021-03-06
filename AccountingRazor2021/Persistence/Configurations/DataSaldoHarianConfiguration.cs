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
    public class DataSaldoHarianConfiguration : IEntityTypeConfiguration<DataSaldoHarian>
    {
        public void Configure(EntityTypeBuilder<DataSaldoHarian> builder)
        {
            builder.ToTable("DataSaldoHarian", "Accounting");

            // builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("AccountingDataSaldoAwal_hilo").IsRequired();
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd().IsRequired();
            //  builder.Property(e => e.DataPeriodeId);
            builder.Property(e => e.DataAccountId);
            builder.Property(e => e.Debet).HasColumnName("Debet").HasColumnType("money");
            builder.Property(e => e.Kredit).HasColumnName("Kredit").HasColumnType("money");
            builder.Property(e => e.Saldo).HasColumnName("Saldo").HasColumnType("money");
            // builder.Property(e => e.DataMataUangId);
            //  builder.Property(e => e.UserInput).HasColumnName("UserInput").HasMaxLength(50).IsUnicode(false);
            //  builder.Property(e => e.NilaiKurs).HasColumnName("NilaiKurs").HasColumnType("money");


            builder.Property(e => e.TanggalInput)
                .HasColumnName("TanggalInput")
                .HasColumnType("datetime").HasDefaultValue(DateTime.Now);


        }
    }
}
