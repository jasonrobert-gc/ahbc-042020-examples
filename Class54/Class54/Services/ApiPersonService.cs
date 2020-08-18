using Class54.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Class54.Services
{
    public class ApiPersonService : IPersonService
    {
        private readonly HttpClient _client;

        public ApiPersonService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            var response = await _client.GetFromJsonAsync<ApiPersonGetAllResult>("people/");
            return response.Results ?? Enumerable.Empty<Person>();
            //// Same as ...
            //if (response.Results == null)
            //{
            //    return Enumerable.Empty<Person>();
            //}

            //return response.Results;
        }
    }

    public class ApiPersonGetAllResult
    {
        public IEnumerable<Person> Results { get; set; }
    }
}
