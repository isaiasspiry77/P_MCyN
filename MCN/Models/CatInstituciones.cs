using System;
using System.Collections.Generic;

namespace MCN.Models
{
    public partial class CatInstituciones
    {
        public CatInstituciones()
        {
            CatExtenciones = new HashSet<CatExtenciones>();
        }

        public int IdInstituto { get; set; }
        public string NombreInstituto { get; set; }
        public int Status { get; set; }

        public Estados StatusNavigation { get; set; }
        public ICollection<CatExtenciones> CatExtenciones { get; set; }
    }
}
