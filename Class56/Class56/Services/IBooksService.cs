using Class56.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Class56.Services
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetAll();
        Task<Book> Get(int id);
        Task Create(Book book);
    }
}
