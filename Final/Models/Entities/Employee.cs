using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        
        
        public decimal Salary { get; set; }
        public string Position { get; set; }

        [Required]
        [Phone]
        [Display(Name ="Phone number")]
        public string Telephone { get; set; }

        [ValidarCedula]
        [MaxLength(13)]
        public string Cedula { get; set; }
    }
}
