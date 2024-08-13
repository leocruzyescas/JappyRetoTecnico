using System.Text.Json.Serialization;

namespace JappyRetoTecnico.Models
{
    public class IpApiResponse
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("zip")]
        public string Zip { get; set; }    
    }
}
