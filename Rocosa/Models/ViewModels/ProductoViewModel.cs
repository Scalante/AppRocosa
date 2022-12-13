﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Rocosa.Models.ViewModels
{
    public class ProductoViewModel
    {
        public Producto Producto { get; set; }
        public IEnumerable<SelectListItem>? CategoriaLista { get; set; }
        public IEnumerable<SelectListItem>? TipoAplicacionLista { get; set; }
    }
}
