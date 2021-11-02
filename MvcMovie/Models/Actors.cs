using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Actors
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Must only use letters or spaces")]
        [Required]
        [StringLength(30)]
        public string Skill { get; set; }

        [Display(Name = "Birth Place")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Must Begin with uppercase letter")]
        [StringLength(30)]
        public string Birthplace { get; set; }
        // 1
        [Range(0, int.MaxValue, ErrorMessage = "Can't be negative")]
        [Display(Name = "Net Worth")]
        [DataType(DataType.Currency)]
        public decimal Networth { get; set; }
    }
}
