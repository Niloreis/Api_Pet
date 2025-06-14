using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiPredutos.Data.Entities;
using ApiPredutos.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ApiPredutos.Data.Contexts
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD_ApiPredutos;
            Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;
            Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AgendaMap());
            modelBuilder.ApplyConfiguration(new ClientesMap());
        }

        public DbSet<Agenda> agendas { get; set; }

        public DbSet<Clientes> clientes { get; set; }
    }
}
