using Contracts.Dtos;
using Contracts.InterFaces;

namespace Service
{
    public class FoodService : IFoodService
    {
        public List<FoodDto> GetFoods()
        {
            List<FoodDto> foods = new List<FoodDto>
            {
                new FoodDto { Id = 1, Name = "orange", Price = 1.99 },
                new FoodDto { Id = 2, Name = "burger", Price = 2.49 },

            };

            return foods;
        }
    }
}
