using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MCN.Models
{
    public partial class DetalleArticulos
    {
        public int IdDetalleArt { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name ="Personal a Cargo")]
        public int? IdPersonal { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name ="Fecha de Revisión")]
        public string FechaRevision { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name ="Comentario de Retroalimentación")]
        [StringLength(250)]
        public string ComentariosRetroaliment { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name ="Articulo")]
        public int? IdArticulo { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name ="Estado")]
        public int Status { get; set; }

        public Articulo IdArticuloNavigation { get; set; }
        public Personal IdPersonalNavigation { get; set; }
        public Estados StatusNavigation { get; set; }
    }
}
