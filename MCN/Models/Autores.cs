using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MCN.Models
{
    public partial class Autores
    {
        public Autores()
        {
            Articulo = new HashSet<Articulo>();
            Coautores = new HashSet<Coautores>();
        }

        public int IdAutores { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Nombre")]
        [StringLength(30)]
        public string NombreA { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Apellidos")]
        [StringLength(60)]
        public string ApellidosA { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Nombre de Usuario")]
        [StringLength(20)]
        public string NombreUsuarioA { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Correo Electrónico")]
        [StringLength(30)]
        public string CorreoElectronicoA { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Contraseña")]
        [StringLength(25)]
        public string ContraseniaA { get; set; }
        [Display(Name = "Tipo")]
        public int TipoA { get; set; }
        [Display(Name = "Estado")]
        public int Status { get; set; }

        public Estados StatusNavigation { get; set; }
        public TipoPersonal TipoANavigation { get; set; }
        public ICollection<Articulo> Articulo { get; set; }
        public ICollection<Coautores> Coautores { get; set; }
    }
}
