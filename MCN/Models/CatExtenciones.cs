using System;
using System.Collections.Generic;

namespace MCN.Models
{
    public partial class CatExtenciones
    {
        public CatExtenciones()
        {
            Personal = new HashSet<Personal>();
        }

        public int IdExtenciones { get; set; }
        public string NombreExtencion { get; set; }
        public int RInstituciones { get; set; }
        public int Status { get; set; }

        public CatInstituciones RInstitucionesNavigation { get; set; }
        public Estados StatusNavigation { get; set; }
        public ICollection<Personal> Personal { get; set; }
    }
}
