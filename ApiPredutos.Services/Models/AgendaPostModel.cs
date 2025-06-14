using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ApiPredutos.Services.Models
{
    public class AgendaPostModel
    {
      
        [MaxLength(60, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do Pet.")]
        public string? NomePet {  get; set; }

       
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe uma data.")]
        public string? Data {  get; set; }

        
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe um horaio.")]
        public string? Time { get; set; }

       
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe uma tipo de servico .")]
        public string? Tipo { get; set; }

       
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
          public string? Obs {  get; set; }

        [Required(ErrorMessage = "Por favor, informe o id do cliente.")]
        public Guid? IdCliente { get; set; }

    }
}
