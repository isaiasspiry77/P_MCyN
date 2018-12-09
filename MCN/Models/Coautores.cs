using System;
using System.Collections.Generic;

namespace MCN.Models
{
    public partial class Coautores
    {
        public Coautores()
        {
            RCaAr = new HashSet<RCaAr>();
        }

        public int IdCoautores { get; set; }
        public string NombreCa { get; set; }
        public string ApellidosCa { get; set; }
        public string CorreoElectronico { get; set; }
        public int? RAutor { get; set; }
        public int? RArticulo { get; set; }
        public int? Rtipo { get; set; }
        public int? Status { get; set; }

        public Articulo RArticuloNavigation { get; set; }
        public Autores RAutorNavigation { get; set; }
        public TipoPersonal RtipoNavigation { get; set; }
        public Estados StatusNavigation { get; set; }
        public ICollection<RCaAr> RCaAr { get; set; }
    }
}
