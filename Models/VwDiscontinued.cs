using System;
using System.Collections.Generic;

namespace BaseDeDatosPrueba.Models
{
    public partial class VwDiscontinued
    {
        public int ProductoId { get; set; }
        public string Producto { get; set; } = null!;
        public DateTime? Estado { get; set; }
    }
}
