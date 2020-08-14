using Class54.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Class54.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPersonService _personService;

        public PeopleController(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _personService.GetAll();
            return View(model);
        }
    }
}
