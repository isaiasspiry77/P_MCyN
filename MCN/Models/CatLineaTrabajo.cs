using System;
using System.Collections.Generic;

namespace MCN.Models
{
    public partial class CatLineaTrabajo
    {
        public CatLineaTrabajo()
        {
            Personal = new HashSet<Personal>();
        }

        public int IdLineaTrabajp { get; set; }
        public string LineasTrabajo { get; set; }
        public int Status { get; set; }

        public Estados StatusNavigation { get; set; }
        public ICollection<Personal> Personal { get; set; }
    }
}
