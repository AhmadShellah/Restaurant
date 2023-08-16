using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.UpdateObject;

namespace Contracts.InterFaces
{
    public interface IFoodService
    {
        public List<FoodDto> GetFoods();
       List<FoodDto> CreateFood(CreateFoodDto createFoodDto);
       List<FoodDto> UpdateFood(UpdateFoodDto updateFoodDto);


    }
}
