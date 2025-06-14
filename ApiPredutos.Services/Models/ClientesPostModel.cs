using System.ComponentModel.DataAnnotations;

namespace ApiPredutos.Services.Models
{
    public class ClientesPostModel
    {
       
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do pet.")]
        public string? NomePet { get; set; }

       
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a data de nascimento do pet.")]
        public string? AnoNascimentoPet {  get; set; }

       
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a raca do pet.")]
        public string? Raca { get; set; }

       
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do tutor.")]
        public string? Tutor { get; set; }


        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o numero do tutor.")]
        public string? NumeroTutor { get; set; }
    }
}
