using ApiPredutos.Data.Entities;
using ApiPredutos.Services.Models;
using AutoMapper;

namespace ApiPredutos.Services.Mapping
{
    public class ModelToEntityMap : Profile
    {
        public ModelToEntityMap() 
        {
            CreateMap<ClientesPostModel, Clientes>().AfterMap((src, dest) =>
            {
                dest.IdCliente = Guid .NewGuid();
            });

            CreateMap<ClientesPutModel, Clientes>();

            CreateMap<AgendaPostModel, Agenda>().AfterMap((src,dest) =>
            {
                dest.IdAgenda = Guid .NewGuid();
            });

            CreateMap<AgendaPutModel, Agenda>();
        }
    }
}
