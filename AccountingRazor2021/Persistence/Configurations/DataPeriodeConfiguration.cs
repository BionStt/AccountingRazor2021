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
    public class DataPeriodeConfiguration : IEntityTypeConfiguration<DataPeriode>
    {
        public void Configure(EntityTypeBuilder<DataPeriode> builder)
        {
            builder.ToTable("DataPeriode");

            //builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("AccountingDataPeriode_hilo").IsRequired();

            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd().IsRequired();
            builder.Property(e => e.Mulai)
                .HasColumnName("Mulai")
                .HasColumnType("datetime");

            builder.Property(e => e.Berakhir)
                .HasColumnName("Berakhir")
                .HasColumnType("datetime");
            builder.Property(e => e.Aktif).HasColumnName("IsAktif").HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.UserInput).HasColumnName("UserInput").HasMaxLength(50).IsUnicode(false);
        }
    }
}
