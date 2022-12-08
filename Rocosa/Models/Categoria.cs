﻿using System.ComponentModel.DataAnnotations;

namespace Rocosa.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre de categoria es obligatorio.")]
        public string NombreCategoria { get; set; }
        [Required(ErrorMessage = "Orden es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El orden debe ser mayor a cero.")]
        public int MostrarOrden { get; set; }
    }
}
