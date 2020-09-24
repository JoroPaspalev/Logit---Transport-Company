using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Logit_Transport.DataProcessor.ImportDto
{
    public class ImportAddressDto
    {
        [Required]
        public string Town { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z .]+$")]
        public string Street { get; set; }

        [Required]
        public string StreetNumber { get; set; }

        public string Block { get; set; }

        public int? Floor { get; set; }

        public string Entrance { get; set; }
    }
}
