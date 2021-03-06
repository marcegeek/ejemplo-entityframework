﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EjemploEF.Models
{
    public class City
    {
        [Key]
        [Display(Name = "Ciudad")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [Display(Name = "Ciudad")]
        [StringLength(50, ErrorMessage = "El campo tiene que tener entre 3 y 50 caracteres",
            MinimumLength = 3)]
        [Index("CityName_Index", IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}