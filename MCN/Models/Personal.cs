using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MCN.Models
{
    public partial class Personal
    {
        public Personal()
        {
            DetalleArticulos = new HashSet<DetalleArticulos>();
        }

        public int IdPersonal { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Nombre")]
        [StringLength(30)]
        public string NombreP { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Apellidos")]
        [StringLength(60)]
        public string ApellidoP { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Nombre de Usuario")]
        [StringLength(20)]
        public string NombreUsuarioP { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Correo Electrónico")]
        [StringLength(30)]
        public string CorreoElectronicoP { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Contraseña")]
        [StringLength(25)]
        public string Contrasenia { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Tipo de Usuario")]
        public int TipoP { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Dependencia")]
        public int? RExtencionesP { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Nivel Academico")]
        public int? RGradoEstudio { get; set; }
        [Required(ErrorMessage = "Campo Requerido!")]
        [Display(Name = "Linea de Trabajo")]
        public int? RLineaTrabajo { get; set; }
        [Display(Name = "Estado")]
        public int Status { get; set; }

        public CatExtenciones RExtencionesPNavigation { get; set; }
        public CatGradoEstudio RGradoEstudioNavigation { get; set; }
        public CatLineaTrabajo RLineaTrabajoNavigation { get; set; }
        public Estados StatusNavigation { get; set; }
        public TipoPersonal TipoPNavigation { get; set; }
        public ICollection<DetalleArticulos> DetalleArticulos { get; set; }
    }
}
