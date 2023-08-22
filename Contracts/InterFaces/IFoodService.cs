using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.UpdateObject;

namespace Contracts.InterFaces
{
    public interface IFoodService
    {
        public Task<List<FoodDto>> GetFoods();
       public Task CreateFood(CreateFoodDto createFoodDto);
        public Task UpdateFood(UpdateFoodDto updateFoodDto);
        public Task<FoodDto> GetFoodById(int id);
        public Task DeleteFoodById(int id);


    }
}
