using Contracts.Dtos;
using Contracts.InterFaces;
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

        [HttpGet]
        [Route("api/Drinks/GetDrinks")]
        public List<DrinksDto> GetDrinks()
        {
            var hh = _drinkService.GetDrinks();

            return hh;
        }

      
    }
}
