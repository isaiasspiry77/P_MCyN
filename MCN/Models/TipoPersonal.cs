using System;
using System.Collections.Generic;

namespace MCN.Models
{
    public partial class TipoPersonal
    {
        public TipoPersonal()
        {
            Autores = new HashSet<Autores>();
            Coautores = new HashSet<Coautores>();
            Personal = new HashSet<Personal>();
        }

        public int IdTipoP { get; set; }
        public string TipoUsuarios { get; set; }
        public int Status { get; set; }

        public Estados StatusNavigation { get; set; }
        public ICollection<Autores> Autores { get; set; }
        public ICollection<Coautores> Coautores { get; set; }
        public ICollection<Personal> Personal { get; set; }
    }
}
