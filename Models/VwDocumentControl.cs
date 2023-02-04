using System;
using System.Collections.Generic;

namespace BaseDeDatosPrueba.Models
{
    public partial class VwDocumentControl
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Departamento { get; set; }
        public string? SegundoNombre { get; set; }
        public string Apellido { get; set; } = null!;
        public DateTime Nacimiento { get; set; }
        public string Genero { get; set; } = null!;
    }
}
