using BencmarkProcessor.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace BencmarkProcessor.Clients
{
    public class RestClient
    {
        private static readonly HttpClient _client = new HttpClient();
        public async Task<IEnumerable<WeatherForecast>> GetSmallPayloadAsync()
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _client.GetFromJsonAsync<IEnumerable<WeatherForecast>>($"http://localhost:5103/WeatherForecast");
            return response;
        }
    }
}
