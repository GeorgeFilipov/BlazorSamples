using MentorMate.Shared.Models;
using System.Net.Http.Json;

namespace MentorMate.Shared
{
    public class DataService
    {
        private readonly HttpClient httpClient;

        public DataService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<WeatherForecast[]?> GetWeatherForecastAsync()
        {
            return httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }

        public Uri ToAbsoluteUri(string relativeUri)
        {
            if(httpClient.BaseAddress == null)
            {
                return new Uri(relativeUri);
            }

            return new Uri(httpClient.BaseAddress, relativeUri);
        }
    }
}