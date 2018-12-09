using System;
using System.Collections.Generic;

namespace MCN.Models
{
    public partial class Estados
    {
        public Estados()
        {
            Articulo = new HashSet<Articulo>();
            Autores = new HashSet<Autores>();
            CatExtenciones = new HashSet<CatExtenciones>();
            CatGradoEstudio = new HashSet<CatGradoEstudio>();
            CatInstituciones = new HashSet<CatInstituciones>();
            CatLineaTrabajo = new HashSet<CatLineaTrabajo>();
            Coautores = new HashSet<Coautores>();
            DetalleArticulos = new HashSet<DetalleArticulos>();
            Personal = new HashSet<Personal>();
            TipoPersonal = new HashSet<TipoPersonal>();
        }

        public int IdEstado { get; set; }
        public string Lestados { get; set; }
        public string DescEstados { get; set; }

        public ICollection<Articulo> Articulo { get; set; }
        public ICollection<Autores> Autores { get; set; }
        public ICollection<CatExtenciones> CatExtenciones { get; set; }
        public ICollection<CatGradoEstudio> CatGradoEstudio { get; set; }
        public ICollection<CatInstituciones> CatInstituciones { get; set; }
        public ICollection<CatLineaTrabajo> CatLineaTrabajo { get; set; }
        public ICollection<Coautores> Coautores { get; set; }
        public ICollection<DetalleArticulos> DetalleArticulos { get; set; }
        public ICollection<Personal> Personal { get; set; }
        public ICollection<TipoPersonal> TipoPersonal { get; set; }
    }
}
