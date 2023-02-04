using System;
using System.Collections.Generic;

namespace BaseDeDatosPrueba.Models
{
    public partial class UvwSalesByTerritory
    {
        public int TerritoryId { get; set; }
        public string TerritoryName { get; set; } = null!;
        public decimal? SalesTotal { get; set; }
    }
}
