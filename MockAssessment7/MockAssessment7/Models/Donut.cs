using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MockAssessment7.Models
{
    public class Donut
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        [DisplayName("Photo")]
        [JsonPropertyName("photo")]
        public string PhotoUrl { get; set; }
        public string[] Extras { get; set; }
    }
}
