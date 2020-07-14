using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Class40.Models
{
    public class CalculateRequest
    {
        [Required]
        public int FirstNumber { get; set; }
        
        [Required]
        public int SecondNumber { get; set; }
        public CalculateType Type { get; set; }
    }
}
