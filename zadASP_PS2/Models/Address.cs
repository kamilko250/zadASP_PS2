using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace zadASP_PS2.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage ="Pole jest obowiązkowe")]
        public string Street { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string  ZipCode { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string City { get; set; }

        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        public int Number { get; set; }
    }
}
