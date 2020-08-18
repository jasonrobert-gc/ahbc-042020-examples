using Class54.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Class54.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetAll();
    }
}
