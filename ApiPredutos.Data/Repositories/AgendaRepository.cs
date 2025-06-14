using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiPredutos.Data.Contexts;
using ApiPredutos.Data.Entities;
using ApiPredutos.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiPredutos.Data.Repositories
{
    public class AgendaRepository : IRepository<Agenda>
    {
        public void Add(Agenda entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.agendas.Add(entity);
                dataContext.SaveChanges();
            }
        }

        public void Delete(Agenda entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.agendas.Remove(entity);
                dataContext.SaveChanges();
            }
        }

        public List<Agenda> GetAll()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.agendas
                     .OrderBy(c => c.NomePet)
                    .ToList();
            }
        }

        public Agenda GetById(Guid? id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.agendas
                    .Where(c => c.IdAgenda == id)
                    .FirstOrDefault();
            }
        }

        public void Update(Agenda entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.agendas.Entry(entity).State = EntityState.Modified;
                dataContext.SaveChanges();
            }
        }
    }
}
