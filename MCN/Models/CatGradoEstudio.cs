using System;
using System.Collections.Generic;

namespace MCN.Models
{
    public partial class CatGradoEstudio
    {
        public CatGradoEstudio()
        {
            Personal = new HashSet<Personal>();
        }

        public int IdGradoEst { get; set; }
        public string NivelEstudio { get; set; }
        public int Status { get; set; }

        public Estados StatusNavigation { get; set; }
        public ICollection<Personal> Personal { get; set; }
    }
}
