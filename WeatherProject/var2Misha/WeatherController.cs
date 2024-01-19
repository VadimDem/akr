using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WeatherProject.Models;

namespace WeatherProject
{
    internal class WeatherController
    {
        HttpClient client = new HttpClient();

        public async Task<WeatherResponse?> GetWeather(string city)
        {
            try
            {
                var response = await client.GetFromJsonAsync<WeatherResponse>(
                    $"https://api.openweathermap.org/data/2.5/weather?q={city}" +
                    "&units=metric" +
                    "&appid=d397a995d6b587ba479889ad3dc3cf56" +
                    "&lang=ru"
                    );
                return response;
            } catch
            {
                return null;
            }
        }
    }
}
