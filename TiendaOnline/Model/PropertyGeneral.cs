using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class PropertyGeneral
    {
        [Required]
        public bool Status { get; set; }
        [Required]
        public DateTime DateCreation { get; set; }
        [Required]
        [StringLength(128)]
        public string UserCreation { get; set; }
    }
}
