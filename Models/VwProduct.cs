using System;
using System.Collections.Generic;

namespace BaseDeDatosPrueba.Models
{
    public partial class VwProduct
    {
        public int? Idproducto { get; set; }
        public string? Producto { get; set; }
        public int? CategoriaId { get; set; }
        public string? Categoria { get; set; }
        public int? SubCategoriaId { get; set; }
        public string? Subcategoria { get; set; }
        public int? ModeloId { get; set; }
        public string? Modelo { get; set; }
    }
}
