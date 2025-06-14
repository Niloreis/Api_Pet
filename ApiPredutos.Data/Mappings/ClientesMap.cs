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
    public class ClientesMap : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> builder)
        {
                 //Nome da Tabela 
            builder.ToTable("CLIENTES");

                 //Chave Primaria
            builder.HasKey(c => c.IdCliente);

                    //Campos
            builder.Property(c => c.IdCliente)
                .HasColumnName("IDCLIENTE");

            builder.Property(c => c.NomePet)
                .HasColumnName("NOMEPET")
                .HasMaxLength (100)
                .IsRequired();

            builder.Property(c => c.AnoNascimentoPet)
                .HasColumnName("ANONASCIMENTOPET")
                .HasMaxLength (20)
                .IsRequired();

            builder.Property(c => c.Raca)
                .HasColumnName("RACA")
                .HasMaxLength (100)
                .IsRequired();

            builder.Property(c => c.Tutor)
                .HasColumnName("TUTOR")
                .HasMaxLength (100)
                .IsRequired();

            builder.Property(C => C.NumeroTutor)
                .HasColumnName("NUMEROTUTOR")
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
