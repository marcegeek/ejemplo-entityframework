using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EjemploEF.Models
{
    public class User
    {
        [Key]
        [Display(Name = "Usuario")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [Display(Name = "Nombre")]
        [StringLength(50, ErrorMessage = "El campo debe tener entre 3 y 50 caracteres",
            MinimumLength = 3)]
        [RegularExpression("^[a-zA-Z''-'\\s]{1,50}$",
            ErrorMessage = "El nombre no es válido")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [Display(Name = "Apellido")]
        [StringLength(50, ErrorMessage = "El campo debe tener entre 3 y 50 caracteres",
            MinimumLength = 3)]
        [RegularExpression("^[a-zA-Z''-'\\s]{1,50}$",
            ErrorMessage = "El apellido no es válido")]
        public string LastName { get; set; }

        [NotMapped]
        [Display(Name = "Apellido y nombre")]
        public string Name { get { return LastName + ", " + FirstName; } }

        [Required(ErrorMessage = "El campo es requerido")]
        [Display(Name = "E-mail")]
        [StringLength(100, ErrorMessage = "El campo debe tener como máximo 100 caracteres")]
        [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?",
            ErrorMessage = "El e-mail no tiene un formato válido")]
        [Index("UserEmail_Index", IsUnique = true)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",
            ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

        [Required]
        [Display(Name = "Ciudad")]
        [Range(1, int.MaxValue, ErrorMessage = "Seleccione una ciudad")]
        public int CityId { get; set; }

        public virtual City City { get; set; }
    }
}