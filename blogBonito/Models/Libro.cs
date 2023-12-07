using System;
using System.Collections.Generic;

namespace blogBonito.Models
{
    public partial class Libro
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Reseña { get; set; }
        public decimal? Calificacion { get; set; }
        public string? UrlImagen { get; set; }
    }
}
