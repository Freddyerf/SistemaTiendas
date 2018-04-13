using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models.Entities
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [Phone]
        [StringLength(20)]
        public string Telephone { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
