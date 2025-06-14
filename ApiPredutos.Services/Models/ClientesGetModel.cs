namespace ApiPredutos.Services.Models
{
    public class ClientesGetModel
    {
        public Guid? IdCLiente { get; set; }

        public string? NomePet { get; set; }
        
        public string? AnoNascimentoPet { get; set; }

        public  string? Raca {  get; set; }

        public string? Tutor { get; set; }

        public string? NumeroTutor { get; set; }
    }
}
