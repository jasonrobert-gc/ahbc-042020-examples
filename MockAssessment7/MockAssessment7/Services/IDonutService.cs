using MockAssessment7.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MockAssessment7.Services
{
    public interface IDonutService
    {
        Task<IEnumerable<Donut>> Get();
        Task<Donut> Get(int id);
    }
}
