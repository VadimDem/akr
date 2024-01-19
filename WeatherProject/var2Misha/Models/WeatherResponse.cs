using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherProject.Models
{
    internal class WeatherResponse
    {
        [JsonPropertyName("weather")]
        public List<Weather>? Weather {  get; set; }

        [JsonPropertyName("main")]
        public Main? Main {  get; set; }
    }
}
