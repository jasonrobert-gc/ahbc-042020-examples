using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentPrep6.Models
{
    public class Assessment
    {
        public int AssessmentId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Points { get; set; }
    }
}
