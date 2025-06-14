using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiPredutos.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiPredutos.Data.Mappings
{
    public class AgendaMap : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
                   //Nome da Tabela
            builder.ToTable("AGENDA");

                    //Chave Primaria
            builder.HasKey(a => a.IdAgenda);

                    //Campos
            builder.Property(a => a.IdAgenda)
                .HasColumnName("IDAGENDA");

            builder.Property(a => a.NomePet)
                .HasColumnName("NOMEPET")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.Time)
               .HasColumnName("TIME")
               .HasMaxLength(20)
               .IsRequired();

            builder.Property(a => a.Data)
               .HasColumnName("DATA")
               .HasMaxLength(20)
               .IsRequired();

            builder.Property(a => a.Tipo)
               .HasColumnName("TIPO")
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(a => a.Obs)
               .HasColumnName("OBS")
               .HasMaxLength(150)
               .IsRequired();

                    //map para o relacionameno 1 para *
            builder.HasOne(a => a.Cliente)
                .WithMany(c => c.Agenda)
                .HasForeignKey(a => a.IdCliente);
        }
    }
}
