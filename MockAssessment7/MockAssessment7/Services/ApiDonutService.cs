using MockAssessment7.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MockAssessment7.Services
{
    public class ApiDonutService : IDonutService
    {
        private readonly HttpClient _client;

        public ApiDonutService(HttpClient client)
        {
            _client = client;
        }

        public async Task<Donut> Get(int id)
        {
            return await _client.GetFromJsonAsync<Donut>($"donuts/{id}.json");
        }
    }
}
