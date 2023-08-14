using Contracts.Dtos;
using Contracts.InterFaces;
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
        public List<FoodDto> GetFoods()
        {
            var hh = _foodService.GetFoods();

            return hh;
        }

        
    }
}
