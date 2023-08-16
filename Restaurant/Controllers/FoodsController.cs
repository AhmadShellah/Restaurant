using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
using Contracts.UpdateObject;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Restaurant.Controllers
{
    [ApiController]
    public class FoodsController : ControllerBase, IFoodService
    {
        private readonly IFoodService _foodService;

        public FoodsController(IFoodService FoodService)
        {
            _foodService = FoodService;
        }

        [HttpGet]
        [Route("api/Food/GetFoods")]
        public List<FoodDto> GetFoods()
        {
            var FoodGot = _foodService.GetFoods();

            return FoodGot;
        }

        [HttpPost]
        [Route("api/Food/CreateFood")]
        public List<FoodDto> CreateFood(CreateFoodDto createFoodDto)
        {
            var createdFoodDto = _foodService.CreateFood(createFoodDto);
            return createdFoodDto;
        }

        [HttpPut]
        [Route("api/Drinks/UpdateFoods")]

        public List<FoodDto> UpdateFood(UpdateFoodDto updateFoodDto)
        {
            var updatedDrinkDto = _foodService.UpdateFood(updateFoodDto);
            return updatedDrinkDto;
        }



        [HttpGet]
        [Route("api/Drinks/GetFoodById")]
        public FoodDto GetFoodById(int id)
        {
            var FoodGotById = _foodService.GetFoodById(id);

            return FoodGotById;
        }

    }
}
