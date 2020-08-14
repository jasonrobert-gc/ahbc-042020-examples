using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Class54.Models
{
    public class Person
    {
        public string Name { get; set; }

        [JsonPropertyName("eye_color")]
        [DisplayName("Eye Color")]
        public string EyeColor { get; set; }

        [JsonPropertyName("hair_color")]
        [DisplayName("Hair Color")]
        public string HairColor { get; set; }
        public string Height { get; set; }
    }
}
