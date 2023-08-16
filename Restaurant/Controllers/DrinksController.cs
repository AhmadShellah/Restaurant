using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
using Contracts.UpdateObject;
using Microsoft.AspNetCore.Mvc;
using Service;

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
            var DrinkGot = _drinkService.GetDrinks();

            return DrinkGot;
        }

        [HttpPost]
        [Route("api/Drinks/CreateDrinks")]

        public List<DrinksDto> CreateDrink(CreateDrinkDto createDrinkDto)
        {
            var createdDrinkDto = _drinkService.CreateDrink(createDrinkDto);
            return createdDrinkDto;
        }

        [HttpPut]
        [Route("api/Drinks/UpdateDrinks")]

        public List<DrinksDto> UpdateDrink(UpdateDrinkDto updateDrinkDto)
        {
            var updatedDrinkDto = _drinkService.UpdateDrink(updateDrinkDto);
            return updatedDrinkDto;
        }


        [HttpGet]
        [Route("api/Drinks/GetDrinksById")]
        public DrinksDto GetDrinkById(int id)
        {
            var DrinkGotById = _drinkService.GetDrinkById(id);

            return DrinkGotById;
        }
    }
}
