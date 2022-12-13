using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rocosa.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Nombre del producto es requerido.")]
        public string NombreProducto { get; set; }

        [Required(ErrorMessage = "Descripción corta del producto es requerida.")]
        public string DescripcionCorta { get; set; }
        [Required(ErrorMessage = "Descripción del producto es requerida.")]
        public string DescripcionProducto { get; set; }

        [Required(ErrorMessage = "El precio del producto es requerido.")]
        [Range(1, double.MaxValue, ErrorMessage ="El precio debe ser mayor a cero.")]
        public double Precio { get; set; }

        public string? ImagenUrl { get; set; }

        //Foreign Key

        public int  CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public virtual Categoria? Categoria { get; set; }

        public int TipoAplicacionId { get; set; }

        [ForeignKey("TipoAplicacionId")]
        public virtual TipoAplicacion? TipoAplicacion { get; set; }

    }
}
