using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormSubmission
{
    public class Starship
    {

        [Required]
        [StringLength(16, ErrorMessage = "Identifier too long (16 character limit).")]
        public string Identifier { get; set; }

        public bool BoolProperty { get; set; } = false;

        //[Required]
        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email Address")]
        //[StringLength(20, ErrorMessage = "Identifier too long (16 character limit).")]
        //public string CaptainsEmail { get; set; }

        //public string Description { get; set; }

        //[Required]
        //public string Classification { get; set; }

        //[Range(1, 100000, ErrorMessage = "Accommodation invalid (1-100000).")]
        //public int MaximumAccommodation { get; set; }

        //[Required]
        //[Range(typeof(bool), "true", "true", ErrorMessage = "This form disallows unapproved ships.")]
        //public bool IsValidatedDesign { get; set; }

        //[Required]
        //public DateTime ProductionDate { get; set; }

        //public DateTime? FirstFlightDate { get; set; }

        //public int? SubLightEngines { get; set; }
    }
}
