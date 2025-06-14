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
    public class ClientesRepository : IRepository<Clientes>
    {
        public void Add(Clientes entity)
        {
            using (var dataContext = new DataContext())
            { 
                dataContext.clientes.Add(entity);
                dataContext.SaveChanges();
            }
        }

        public void Delete(Clientes entity)
        {
            using (var dataContext = new DataContext())
            { 
                dataContext.clientes.Remove(entity);
                dataContext.SaveChanges();
            }  
        }

        public List<Clientes> GetAll()
        {
            using (var dataContext = new DataContext()) 
            {
                return dataContext.clientes
                     .OrderBy(c => c.NomePet)
                    .ToList();
            }
        }

        public Clientes GetById(Guid? id)
        {
            using (var dataContext =new DataContext()) 
            {
                return dataContext.clientes
                    .Where(c => c.IdCliente == id)
                    .FirstOrDefault();
            }
        }

        public void Update(Clientes entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.clientes.Entry(entity).State = EntityState.Modified;
                dataContext.SaveChanges();
            }
        }
    }
}
