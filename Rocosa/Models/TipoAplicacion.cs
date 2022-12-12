using System.ComponentModel.DataAnnotations;

namespace Rocosa.Models
{
    public class TipoAplicacion
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre del tipo de aplicación es obligatorio.")]
        public string? Nombre { get; set; }
    }
}
