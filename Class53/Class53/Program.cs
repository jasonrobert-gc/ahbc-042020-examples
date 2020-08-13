using Class53.Model;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Class53
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.dev/api/");
            //var options = new JsonSerializerOptions
            //{
            //    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            //};

            //using (var response = await client.GetAsync("starships/9/"))
            //{
            //    response.EnsureSuccessStatusCode();

            //    //// BAD WAY - since we pull the entire content into memory 
            //    //var result = await response.Content.ReadAsStringAsync();
            //    //var starship = await JsonSerializer.DeserializeAsync<Starship>(result, options);

            //    // Better way - since we use a stream
            //    using (var stream = await response.Content.ReadAsStreamAsync())
            //    {
            //        var ship = await JsonSerializer.DeserializeAsync<Starship>(stream, options);
            //        //Console.WriteLine(ship.Name);
            //    }
            //}

            // Using System.Net.Http.Json!
            var starship = await client.GetFromJsonAsync<Starship>("starships/9/");
            Console.WriteLine(starship.Name);
        }
    }
}
