using Class56.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Class56.Services
{
    public class ApiBooksService : IBooksService
    {
        private readonly HttpClient _client;

        public ApiBooksService(HttpClient client)
        {
            _client = client;
        }

        public async Task Create(Book book)
        {
            await _client.PostAsJsonAsync("books", book);
        }

        public async Task<Book> Get(int id)
        {
            return await _client.GetFromJsonAsync<Book>($"books/{id}");
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _client.GetFromJsonAsync<IEnumerable<Book>>($"books");
        }
    }
}
