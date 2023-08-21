using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
using Contracts.UpdateObject;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Restaurant.Controllers
{
    [ApiController]
    public class HotDrinksController : ControllerBase, IHotDrinkService
    {
        private readonly IHotDrinkService _hotDrinkService;

        public HotDrinksController(IHotDrinkService hotDrinkService)
        {
            _hotDrinkService = hotDrinkService;
        }

        [HttpGet]
        [Route("api/HotDrink/GetHotDrinks")]
        public List<HotDrinkDto> GetHotDrink()
        {
            var hotDrink = _hotDrinkService.GetHotDrink();
            return hotDrink;
        }

        [HttpPost]
        [Route("api/HotDrink/CreateHotDrink")]
        public List<HotDrinkDto> CreateHotDrink(CreateHotDrinkDto createHotDrinkDto)
        {
            var createdHotDrinkDto = _hotDrinkService.CreateHotDrink(createHotDrinkDto);
            return createdHotDrinkDto;
        }

        [HttpPut]
        [Route("api/HotDrink/UpdateHotDrink")]
        public List<HotDrinkDto> UpdateHotDrink(UpdateHotDrinkDto updateHotDrinkDto)
        {
            var updatedHotDrinkDto = _hotDrinkService.UpdateHotDrink(updateHotDrinkDto);
            return updatedHotDrinkDto;
        }

        [HttpGet]
        [Route("api/HotDrink/GetHotDrink")]
        public HotDrinkDto GetHotDrinkById(int id)
        {
            var hotDrinkGotById = _hotDrinkService.GetHotDrinkById(id);
            return hotDrinkGotById;
        }

   
    }
}
