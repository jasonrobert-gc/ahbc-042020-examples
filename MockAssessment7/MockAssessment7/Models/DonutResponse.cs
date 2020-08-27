using System.Collections.Generic;

namespace MockAssessment7.Models
{
    public class DonutResponse
    {
        public int Count { get; set; }
        public IEnumerable<Donut> Results { get; set; }
    }
}
