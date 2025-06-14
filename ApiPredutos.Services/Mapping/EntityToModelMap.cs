using ApiPredutos.Data.Entities;
using ApiPredutos.Services.Models;
using AutoMapper;

namespace ApiPredutos.Services.Mapping
{
    public class EntityToModelMap : Profile
    {
        public EntityToModelMap() 
        { 
           CreateMap<Clientes, ClientesGetModel>();
            CreateMap<Agenda, AgendaGetModel>();
        }
    }
}
