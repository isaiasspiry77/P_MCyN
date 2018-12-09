using System;
using System.Collections.Generic;

namespace MCN.Models
{
    public partial class RCaAr
    {
        public int IdTb { get; set; }
        public int? RCoautor { get; set; }
        public int? RArticulo { get; set; }

        public Articulo RArticuloNavigation { get; set; }
        public Coautores RCoautorNavigation { get; set; }
    }
}
