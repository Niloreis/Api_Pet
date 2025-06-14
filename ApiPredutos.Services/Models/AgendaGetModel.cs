using System.ComponentModel.DataAnnotations;

namespace ApiPredutos.Services.Models
{
    public class AgendaGetModel
    {
        public Guid? IdAgenda { get; set; }
        public string? NomePet { get; set; }

        public string? Data { get; set; }

        public string? Time { get; set; }

        public string? Tipo { get; set; }

        public string? Obs {  get; set; }
    
        public Guid? IdCliente { get; set; }
    }
}
