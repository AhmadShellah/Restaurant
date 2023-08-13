using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    [ApiController]
    public class DrinksController : ControllerBase, IDrinkService
    {
        private readonly IDrinkService _drinkService;

        public DrinksController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        public List<Class1.DrinksDto> GetDrinks()
        {
            var hh = _drinkService.GetDrinks();

            return hh;
        }
    }
}
