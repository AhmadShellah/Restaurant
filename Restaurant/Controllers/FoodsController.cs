using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
using Contracts.UpdateObject;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<List<FoodDto>> GetFoods()
        {
            var FoodGot = await _foodService.GetFoods();

            return FoodGot;
        }

        [HttpPost]
        [Route("api/Food/CreateFood")]
        public async Task CreateFood(CreateFoodDto createFoodDto)
        {
            await _foodService.CreateFood(createFoodDto);
            
        }

        [HttpPut]
        [Route("api/Food/UpdateFoods")]

        public async Task UpdateFood(UpdateFoodDto updateFoodDto)
        {
            await _foodService.UpdateFood(updateFoodDto);
            
        }



        [HttpGet]
        [Route("api/Food/GetFoodById")]
        public async Task<FoodDto> GetFoodById(int id)
        {
            var FoodGotById = await _foodService.GetFoodById(id);

            return FoodGotById;
        }

        [HttpDelete]
        [Route("api/Food/DeleteById")]
        public async Task DeleteFoodById(int id)
        {
            await _foodService.DeleteFoodById(id);

        }
    }
}
