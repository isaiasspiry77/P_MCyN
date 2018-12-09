using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MCN.Models
{
    public partial class Articulo
    {
        public Articulo()
        {
            Coautores = new HashSet<Coautores>();
            DetalleArticulos = new HashSet<DetalleArticulos>();
            RCaAr = new HashSet<RCaAr>();
        }

        public int IdArticulo { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Titulo del Articulo")]
        [StringLength(50)]
        public string TituloArticulo { get; set; }
        [Display(Name = "Autor")]
        public int RAutor { get; set; }
        [Display(Name = ("Fecha de Publicación"))]
        [StringLength(30)]
        public string FechaPublicacionA { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Documento")]
        [StringLength(300)]
        public string RutaDocumentoA { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Imagenes")]
        [StringLength(300)]
        public string RutaZipImagenesA { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Comentarios del Autor")]
        [StringLength(250)]
        public string ComentariosAutor { get; set; }
        [Display(Name = "Fecha de Edición")]
        [StringLength(30)]
        public string FechaEdicionA { get; set; }
        [Display(Name = "Estado")]
        public int Status { get; set; }

        public Autores RAutorNavigation { get; set; }
        public Estados StatusNavigation { get; set; }
        public ICollection<Coautores> Coautores { get; set; }
        public ICollection<DetalleArticulos> DetalleArticulos { get; set; }
        public ICollection<RCaAr> RCaAr { get; set; }
    }
}
