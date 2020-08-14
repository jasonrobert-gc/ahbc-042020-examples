using Class54.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Class54.Services
{
    public class MockPersonService : IPersonService
    {
        public Task<IEnumerable<Person>> GetAll()
        {
            var result = new List<Person>
            {
                new Person
                {
                    Name = "Jason Robert",
                    Height = "100",
                    EyeColor = "Hazel",
                    HairColor = "Dark Brown"
                }
            } as IEnumerable<Person>;

            return Task.FromResult(result);
        }
    }
}
